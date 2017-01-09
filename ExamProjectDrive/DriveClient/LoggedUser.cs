using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using DriveClient.DriveServiceReference;

namespace DriveClient
{
    public class LoggedUser
    {
        public ContractUser contractUser { get; set; }
        public string selectedImage { get; set; }
        private Form1 myForm;

        private string root;


        public LoggedUser(Form1 myForm)
        {
            this.myForm = myForm;
        }

        public string Root
        {
            get { return root; }
            set { root = value; }
        }


        public void loadPath(ListView listView1, string loadPath)
        {
            using (DriveServiceClient client = new DriveServiceClient())
            {

                listView1.Invoke((Action)(() =>
                {
                    if (listView1.Items.Count > 0)
                        listView1.Items.Clear();

                }));


                if (contractUser.Login != null)
                {
                    //Task.Run(() => loadDirectories(listView1, client.GetDirectoriesList(loadPath)));
                    //Task.Run(() => loadFiles(listView1, client.GetFilesList(loadPath)));

                    loadDirectories(listView1, client.GetDirectoriesList(loadPath));
                    loadFiles(listView1, client.GetFilesList(loadPath));
                }
            }
        }

        public void loadFiles(ListView listView, MyFileInfo[] files)
        {
            foreach (MyFileInfo file in files)
            {
                try
                {
                    ListViewItem tmp = new ListViewItem();
                    listView.Invoke((Action)(() =>
                    {
                        tmp.Group = listView.Groups[1];
                        tmp.Text = file.Name;
                        tmp.ImageIndex = 1;
                        tmp.SubItems.Add(Math.Round((Convert.ToDouble(file.Size) / 1024), 2) + " KB");
                       // tmp.SubItems.Add("Exception KB");
                        tmp.SubItems.Add(file.Time.ToString());
                        listView.Items.Add(tmp);
                    }));
                }
                catch (Exception)
                {

                }
            }
        }
        public void loadDirectories(ListView listView, DirectoryInfo[] dirs)
        {
            foreach (DirectoryInfo dir in dirs)
            {
                try
                {
                    ListViewItem tmp = new ListViewItem();
                    listView.Invoke((Action)(() =>
                    {
                        tmp.Group = listView.Groups[0];
                        tmp.Text = dir.Name;
                        tmp.ImageIndex = 0;
                        tmp.SubItems.Add("");
                        tmp.SubItems.Add(dir.LastWriteTime.ToString());
                        listView.Items.Add(tmp);
                    }));
                }
                catch (Exception)
                {

                }
            }
        }


        public void WriteDirectory(string folderPath, string parent, string destinationFolder)
        {
            using (DriveServiceClient client = new DriveServiceClient())
            {
                DirectoryInfo tmpDirInfo = new DirectoryInfo(folderPath);
                client.CreateFolder(getPathSubstring(tmpDirInfo.FullName, parent, destinationFolder));
               
                foreach (FileInfo var in tmpDirInfo.GetFiles())
                {
                    byte[] fileBytes = File.ReadAllBytes(var.FullName);
                    if (client.WriteFile(getPathSubstring(var.FullName, parent, destinationFolder), fileBytes))
                        myForm.richTextBox1.Invoke((Action)(() => { myForm.richTextBox1.AppendText("File : " + getPathSubstring(var.FullName, parent, destinationFolder) + "  was loaded...\n"); myForm.richTextBox1.ScrollToCaret(); }));

                    Array.Clear(fileBytes, 0, fileBytes.Length);
                }


                foreach (DirectoryInfo var in tmpDirInfo.GetDirectories())
                    WriteDirectory(var.Parent.FullName + @"\" + var.Name, parent, destinationFolder);            
            }
        }


        public string getPathSubstring(string path, string parent,string destinationFolder)
        {
            return destinationFolder + path.Substring(parent.Length, path.Length - parent.Length);
        }


        public void WriteFile(string filePath)
        {
            FileInfo tmpFileInfo = new FileInfo(filePath);
            byte[] fileBytes = File.ReadAllBytes(filePath);

            using (DriveServiceClient client = new DriveServiceClient())
            {
                try
                {
                    if (client.WriteFile(root + @"\" + tmpFileInfo.Name, fileBytes))
                        myForm.richTextBox1.Invoke((Action)(() => { myForm.richTextBox1.AppendText("File : " + tmpFileInfo.Name + "  was loaded...\n"); myForm.richTextBox1.ScrollToCaret(); }));
                    else myForm.richTextBox1.Invoke((Action)(() => { myForm.richTextBox1.AppendText("File : " + tmpFileInfo.Name + "  already exists...\n"); myForm.richTextBox1.ScrollToCaret(); }));
                    Array.Clear(fileBytes, 0, fileBytes.Length);
                }
                catch (Exception ex)
                {
                    Array.Clear(fileBytes, 0, fileBytes.Length);
                    MessageBox.Show(ex.Message);
                }              
            }
        }


        public void UploadFolder(string folderName, string destination,string currentRoot)
        {
            using (DriveServiceClient client = new DriveServiceClient())
            {
                DirectoryInfo tmpDirInfo = client.GetDirectoryInfo(currentRoot + @"\" + folderName);
                if (tmpDirInfo != null)
                {
                  if (!Directory.Exists(destination + @"\" + folderName))
                        Directory.CreateDirectory(destination + @"\" + folderName);


                  foreach (MyFileInfo var in client.GetFilesList(currentRoot + @"\" + folderName))
                  {
                      byte[] fileBytes = client.GetFileBytes(currentRoot + @"\" + folderName + @"\" + var.Name);
                      if (fileBytes != null)
                      {
                          File.WriteAllBytes(destination + @"\" + folderName + @"\" + var.Name, fileBytes);
                          myForm.richTextBox1.Invoke((Action)(() => { myForm.richTextBox1.AppendText(@"File : " + destination + @"\" + folderName + @"\" + var.Name + "  was uploaded...\n"); myForm.richTextBox1.ScrollToCaret(); }));
                      }

                      Array.Clear(fileBytes, 0, fileBytes.Length);
                  } 


                  foreach (DirectoryInfo var in client.GetDirectoriesListDirect(tmpDirInfo.FullName))
                      UploadFolder(folderName + @"\" + var.Name, destination, currentRoot);
                }              
            }
        }

        public void UploadFile(string fileName,string destination)
        {

            using (DriveServiceClient client = new DriveServiceClient())
            {
                byte[] tmpBytes = client.GetFileBytes(root + @"\" + fileName);
                File.WriteAllBytes(destination + @"\" + fileName, tmpBytes);
                Array.Clear(tmpBytes, 0, tmpBytes.Length);
                myForm.richTextBox1.Invoke((Action)(() => { myForm.richTextBox1.AppendText("File : " + fileName + "  was uploaded...\n"); }));
            }      
        }


        public Image ConvertBinaryToImage(byte[] dataBytes)
        {
            using (MemoryStream ms = new MemoryStream(dataBytes))
            {
                return Image.FromStream(ms);
            }
        }

        public void checkUser()
        {
            using (DriveServiceClient client = new DriveServiceClient())
            {

                myForm.richTextBox1.Invoke((Action)(() => { myForm.richTextBox1.AppendText("Processing...\n"); }));

                contractUser = client.CheckLoggedUser(myForm.textBox1.Text, myForm.textBox2.Text);
                if (contractUser != null)
                {
                    Root = client.GetUserRoot(contractUser.Login);

                    if (root != null)
                    {
                        loadPath(myForm.listView1, root);
                        myForm.textBox8.Invoke((Action)(() => { myForm.textBox8.Text = root; }));


                        //myForm.listView1.Invoke((Action)(() =>
                        //{
             
                        //   // myForm.listView1.BackgroundImage = new Bitmap(ConvertBinaryToImage(contractUser.Image));
                        //    // myForm.listView1.BackgroundImageLayout=ImageLayout.Center;
                        //}));
                    }
                    Task.Run(() => FillUserHomeTab());
                    myForm.richTextBox1.Invoke((Action)(() => { myForm.richTextBox1.AppendText("User logged: name: " + contractUser.Name + " , surname: " + contractUser.Surname + '\n'); myForm.richTextBox1.ScrollToCaret(); }));
                }
                else
                    myForm.richTextBox1.Invoke((Action)(() => { myForm.richTextBox1.AppendText("Wrong login or password!!!\n"); myForm.richTextBox1.ScrollToCaret(); }));

            }

        }


        private void FillUserHomeTab()
        {
            myForm.Invoke((Action)(() =>
            {
                myForm.label13.Text = contractUser.Login;
                myForm.textBox12.Text = contractUser.Password;
                myForm.textBox11.Text = contractUser.Name;
                myForm.textBox10.Text = contractUser.Surname;
                myForm.textBox9.Text = contractUser.Age.ToString();
                myForm.pictureBox2.BackgroundImage = new Bitmap(ConvertBinaryToImage(contractUser.Image));
            }));


        }

    }
}
