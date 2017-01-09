using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using DriveClient.DriveServiceReference;

namespace DriveClient
{
    public partial class Form1 : Form
    {
        private LoggedUser user;
    

        public Form1()
        {
            InitializeComponent();
            user = new LoggedUser(this);
         
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listView1.ContextMenuStrip = contextMenuStrip1;
            //using (DriveServiceClient client = new DriveServiceClient())
            //{
            //    MyFileInfo x= client.GetFileInfo(@"A007\Service.svc");
            //    Console.WriteLine(x);

            //}


        }

    


        private bool AddUser(string login, string password, string name, string surname, int age, string imagePath, int accessLevelId)
        {
            Users tmpUser = new Users();
            tmpUser.Login = login;
            tmpUser.Password = password;
            tmpUser.Name = name;
            tmpUser.Surname = surname;
            tmpUser.Age = age;
            tmpUser.Access_level_ID = accessLevelId;

            if (imagePath != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    Image testImage = Image.FromFile(imagePath);
                    testImage.Save(ms, ImageFormat.Jpeg);
                    tmpUser.Image = ms.ToArray();
                }
            }
            using (DriveServiceClient client = new DriveServiceClient())
            {
                try
                {
                    if (client.AddUser(tmpUser))
                    {
                        MessageBox.Show("Success!!!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return true;
                    }
                    else MessageBox.Show("Such user login already exists!!!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    richTextBox1.Invoke((Action)(() => { richTextBox1.AppendText(ex.Message); richTextBox1.ScrollToCaret(); }));
                }
                return false;
            }
        }

        private int AddAccessLevel()
        {
            using (DriveServiceClient client = new DriveServiceClient())
            {
                Access_level tmpLevel = new Access_level();
                tmpLevel.Read = true;
                tmpLevel.Write = true;
                tmpLevel.Full_access = true;

                client.AddAccessLevel(tmpLevel);
                return client.GetLastAccessID();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Filter = "JPEG files (.jpg)|*.jpg|All Files (*.*)|*.*";
                dialog.FilterIndex = 1;
                dialog.InitialDirectory = @"C:\";
                dialog.Title = "Please select logo image";
                dialog.ShowHelp = true;

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    user.selectedImage = dialog.FileName;
                    pictureBox1.BackgroundImage = Image.FromFile(dialog.FileName);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int tmpParse = 0;
                if (Int32.TryParse(textBox7.Text, out tmpParse))
                {
                    Task.Run((Action) (() =>
                    {
                        if (AddUser(textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, tmpParse, user.selectedImage, AddAccessLevel()))
                            clearRegisterTab();
                    }));                  
                }
            }
            catch (Exception ex)
            {           
                richTextBox1.AppendText(ex.Message);
                richTextBox1.ScrollToCaret();
            }
            
        }

        private void clearRegisterTab()
        {
            textBox3.Invoke((Action)(() => { textBox3.Clear(); }));
            textBox4.Invoke((Action)(() => { textBox4.Clear(); }));
            textBox5.Invoke((Action)(() => { textBox5.Clear(); }));
            textBox6.Invoke((Action)(() => { textBox6.Clear(); }));
            textBox7.Invoke((Action)(() => { textBox7.Clear(); }));
            pictureBox1.Invoke((Action)(() => { pictureBox1.BackgroundImage = null; }));
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {

            }
            else if (tabControl1.SelectedIndex == 1)
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (user != null)
                new Thread(() => user.checkUser()).Start();

        }


        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 1)
            {
                if (listView1.SelectedItems[0].SubItems[1].Text.Length == 0 && user.Root != null)
                {
                    user.Root += '\\' + listView1.SelectedItems[0].Text;
                    textBox8.Text = user.Root;
                    user.loadPath(listView1, user.Root);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (user.Root.LastIndexOf('\\') != user.Root.IndexOf('\\') && user.Root != null)
            {
                if (user.Root.Length != (user.Root + @"\" + user.contractUser.Login).Length)
                {
                    user.Root = user.Root.Substring(0, user.Root.LastIndexOf('\\'));
                    textBox8.Text = user.Root;
                    user.loadPath(listView1, user.Root);
                }
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsFileDropList())
            {
                StringCollection paste = Clipboard.GetFileDropList();

                foreach (String var in paste)
                {
                    FileAttributes attr;
                    attr = File.GetAttributes(@var);
                    if ((attr & FileAttributes.Directory) == FileAttributes.Directory)
                    {
                        DirectoryInfo tmpInfo = new DirectoryInfo(var);
                        Task.Run(() => user.WriteDirectory(var, tmpInfo.Parent.FullName,user.Root));
                    }
                    else
                        Task.Run(() => user.WriteFile(var));
                }
            }
            else
            {
                richTextBox1.AppendText("Clipboard empty!!!");
                richTextBox1.ScrollToCaret();
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (user.contractUser != null && user.Root != null)
            {

                Task.Run(() =>
                {
                    using (DriveServiceClient client = new DriveServiceClient())
                    {
                        if ((client.GetDirectoriesList(user.Root).Count() + client.GetFilesList(user.Root).Count()) !=
                            listView1.Items.Count)
                            user.loadPath(listView1, user.Root);

                    }
                });

            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (DriveServiceClient client = new DriveServiceClient())
            {
                foreach (ListViewItem selectedItem in listView1.SelectedItems)
                {
                    if (selectedItem.SubItems[1].Text.Length == 0)
                    {
                        client.DeleteFolderAsync(user.Root + @"\" + selectedItem.Text);
                        richTextBox1.Invoke((Action)(() => { richTextBox1.AppendText("Folder : " + user.Root + @"\" + selectedItem.Text + "  was deleted...\n"); richTextBox1.ScrollToCaret(); }));
                    }
                    else
                    {
                        client.DeleteFileAsync(user.Root + @"\" + selectedItem.Text);
                        richTextBox1.Invoke((Action)(() => { richTextBox1.AppendText("File : " + user.Root + @"\" + selectedItem.Text + "  was deleted...\n"); richTextBox1.ScrollToCaret(); }));
                    }
                }
            }
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                FolderBrowserDialog folderDialog = new FolderBrowserDialog();
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    foreach (ListViewItem selectedItem in listView1.SelectedItems)
                    {
                        if (selectedItem.Group.Header == listView1.Groups[0].Header)
                            Task.Run(() => user.UploadFolder(selectedItem.Text, folderDialog.SelectedPath, user.Root));
                        else
                            Task.Run(() => user.UploadFile(selectedItem.Text, folderDialog.SelectedPath));
                    }
                }
            }
            else
            {
                richTextBox1.AppendText("Select item(s) to upload!!!\n");richTextBox1.ScrollToCaret();
            }
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Filter = "JPEG files (.jpg)|*.jpg|All Files (*.*)|*.*";
                dialog.FilterIndex = 1;
                dialog.InitialDirectory = @"C:\";
                dialog.Title = "Please select logo image";
                dialog.ShowHelp = true;

                if (dialog.ShowDialog() == DialogResult.OK)
                {

                    byte[] imageBytes = null;
                    using (MemoryStream ms = new MemoryStream())
                    {
                        Image testImage = Image.FromFile(dialog.FileName);
                        testImage.Save(ms, ImageFormat.Jpeg);
                        imageBytes = ms.ToArray();
                    }
                    user.contractUser.Image = imageBytes;
                    user.selectedImage = dialog.FileName;
                    pictureBox2.BackgroundImage = Image.FromFile(dialog.FileName);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (DriveServiceClient client = new DriveServiceClient())
            {          
                try
                {
                    ContractUser tmpUser = new ContractUser()
                    {
                        Login = user.contractUser.Login,
                        Password = textBox12.Text,
                        Name = textBox11.Text,
                        Surname = textBox10.Text,
                        Age = Convert.ToInt32(textBox9.Text),
                        Image = user.contractUser.Image
                    };


                    Task.Run(() =>
                    {
                        if (client.ChangeUserData(tmpUser))
                            richTextBox1.Invoke((Action)(() => { richTextBox1.AppendText("User data changed...\n"); }));
                    });

                }
                catch (Exception ex)
                {
                    richTextBox1.Invoke((Action)(() =>{richTextBox1.AppendText(ex.Message);richTextBox1.ScrollToCaret();}));
                }         
               
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

            if (user.contractUser != null)
            {
                using (DriveServiceClient client = new DriveServiceClient())
                {
                    int counter = 0;
                    while (true)
                    {
                        if (!client.IfExists(user.Root + @"\" + "Нова папка " + counter))
                        {
                            client.CreateFolder(user.Root + @"\" + "Нова папка " + counter);
                            richTextBox1.AppendText("Folder  "+user.Root + @"\" + "Нова папка " + counter+"  was created!!!");
                            richTextBox1.ScrollToCaret();
                            break;
                        }                          
                        counter++;
                    }
                }
            }
        }

        private void listView1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect=DragDropEffects.All;
        }

        private void listView1_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            foreach (string var in files)
            {
                FileAttributes attr;
                attr = File.GetAttributes(@var);
                if ((attr & FileAttributes.Directory) == FileAttributes.Directory)
                {
                    DirectoryInfo tmpInfo = new DirectoryInfo(var);
                    Task.Run(() => user.WriteDirectory(var, tmpInfo.Parent.FullName,user.Root));
                }
                else
                    Task.Run(() => user.WriteFile(var));


            }
        }

        private void renameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not working yet","",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void splitContainer2_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                listView1.BackgroundImage = new Bitmap(user.ConvertBinaryToImage(user.contractUser.Image));
            }
            else listView1.BackgroundImage = null;
        }

        private void tabControl2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl2.SelectedIndex == 1)
                if (user.contractUser == null)
                    tabControl2.SelectedTab = tabControl2.TabPages[0];
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ColorDialog dialog=new ColorDialog();
            dialog.AllowFullOpen = true;
            dialog.FullOpen = true;
            dialog.ShowHelp = true;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                listView1.BackgroundImage = null;
                listView1.BackColor = dialog.Color;
            }
        }
    }
}
