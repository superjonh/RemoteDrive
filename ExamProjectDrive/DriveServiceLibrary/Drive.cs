using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DriveServiceLibrary
{
    public class Drive : IDriveService
    {
        private ExamDriveEntities context;
        //private string allUsersRoot = @"D:\DRIVEUSERS\";
        private string allUsersRoot = @"d:\DZHosts\LocalUser\superjohn\www.DriveService.somee.com\Users\";

        private static Regex loginRegex;

   
        public Drive()
        {
            context = new ExamDriveEntities();
            loginRegex = new Regex(@"^(?=[a-zA-Z])[-\w.]{0,23}([a-zA-Z\d]|(?<![-.])_)$", RegexOptions.Compiled);

            if (!Directory.Exists(allUsersRoot))
                Directory.CreateDirectory(allUsersRoot);
        }


        private static bool IsStringAllowed(string name)
        {
            if (string.IsNullOrEmpty(name) || !loginRegex.IsMatch(name))
                return false;
            return true;
        }

        private string shrinkRoot(string root)
        {
            return root.Substring(allUsersRoot.Length, root.Length - allUsersRoot.Length);
        }

        public string GetUserRoot(string userName)
        {                      
            foreach (string var in Directory.GetDirectories(allUsersRoot))
                if (var.Substring(var.LastIndexOf(@"\") + 1, var.Length - var.LastIndexOf(@"\") - 1) == userName)                
                    return shrinkRoot(@"\"+var);                               
            return null;
        }

        public List<ContractUser> GetAllUsers()
        {
            List<ContractUser> tmpList = new List<ContractUser>();
            foreach (Users var in context.Users)
            {
                tmpList.Add(CpyUserData(var));
            }
            return tmpList;
        }

        private ContractUser CpyUserData(Users inputUser)
        {
            return new ContractUser()
            {
                ID = inputUser.ID,
                Login = inputUser.Login,
                Password = inputUser.Password,
                Name = inputUser.Name,
                Surname = inputUser.Surname,
                Age = inputUser.Age,
                Image = inputUser.Image,
                Access_level_ID = inputUser.Access_level_ID
            };
        }

        public ContractUser CheckLoggedUser(string login, string password)
        {
            foreach (Users var in context.Users)
            {
                if (var.Login == login && var.Password == password)
                    return CpyUserData(var);
            }
            return null;
        }

        public int GetLastAccessID()
        {
            using (ExamDriveEntities context = new ExamDriveEntities())
            {
                return context.Access_level.ToList()[context.Access_level.Count()-1].ID;
            }         
        }

        public bool AddUser(Users user)
        {
            if (IsStringAllowed(user.Login) && IsStringAllowed(user.Password))
            {
                using (ExamDriveEntities context = new ExamDriveEntities())
                {
                    foreach (Users var in context.Users)
                        if (var.Login == user.Login)
                            return false;

                    context.Users.Add(user);
                    context.SaveChanges();

                    if (!Directory.Exists(allUsersRoot + user.Login))
                        Directory.CreateDirectory(allUsersRoot + user.Login);

                    return true;
                }
            }
            else throw new Exception("\nLogin and password should be from 1 to 24 character in length, \n" +
                                             "starts with letter a-z A-Z , contain letters, numbers or '.','-' or '_'\n");
           
        }


        public bool ChangeUserData(ContractUser user)
        {
            foreach (Users var in context.Users)
            {
                if (var.Login == user.Login)
                {
                    var.Password=user.Password;
                    var.Name = user.Name;
                    var.Surname = user.Surname;
                    var.Age = user.Age;
                    var.Image = user.Image;

                    break;
                }
            }
            context.SaveChanges();
            return true;
        }

        public void AddAccessLevel(Access_level level)
        {
            using (ExamDriveEntities context = new ExamDriveEntities())
            {
                context.Access_level.Add(level);
                context.SaveChanges();             
            }
        }

        public bool WriteFile(string filePath, byte[] fileBytes)
        {
            if (!File.Exists(allUsersRoot + filePath))
            {
                File.WriteAllBytes(allUsersRoot + filePath, fileBytes);
                return true;
            }
            return false;
        }

        public bool DeleteFile(string filePath)
        {
            if (File.Exists(allUsersRoot + filePath))
            {
                File.Delete(allUsersRoot + filePath);
                return true;
            }              
            return false;
        }

        public bool DeleteFolder(string folderPath)
        {
            if (Directory.Exists(allUsersRoot + folderPath))
            {
                Directory.Delete(allUsersRoot + folderPath, true);
                return true;
            }              
            return false;
        }

        public bool CreateFolder(string folderPath)
        {
            if (!Directory.Exists(allUsersRoot + folderPath))
            {
                Directory.CreateDirectory(allUsersRoot + folderPath);
                return true;
            }
            return false;   
        }

        public bool IfExists(string path)
        {
            return Directory.Exists(allUsersRoot + path);
        }

        public byte[] GetFileBytes(string filePath)
        {
            if (File.Exists(allUsersRoot+filePath))
                return File.ReadAllBytes(allUsersRoot + filePath);
            return null;
        }


        public byte[] GetFileBytesDirect(string filePath)
        {
            if (File.Exists(filePath))
                return File.ReadAllBytes(filePath);
            return null;
        }

        public DirectoryInfo GetDirectoryInfo(string userFolder)
        {
            if (Directory.Exists(allUsersRoot + userFolder))
                return new DirectoryInfo(allUsersRoot + userFolder);
            else return null;
        }

        public List<DirectoryInfo> GetDirectoriesList(string userFolder)
        {
            if (Directory.Exists(allUsersRoot+userFolder))
            {
                List<DirectoryInfo> tmpDirectoryInfo = new List<DirectoryInfo>();
              
                 foreach (string varInfo in Directory.GetDirectories(allUsersRoot + userFolder))                             
                    tmpDirectoryInfo.Add(new DirectoryInfo(varInfo));
                
                return tmpDirectoryInfo;
            }               
            else return null;
        }


        public List<DirectoryInfo> GetDirectoriesListDirect(string userFolder)
        {
            if (Directory.Exists(userFolder))
            {
                List<DirectoryInfo> tmpDirectoryInfo = new List<DirectoryInfo>();

                foreach (string varInfo in Directory.GetDirectories(userFolder))
                    tmpDirectoryInfo.Add(new DirectoryInfo(varInfo));

                return tmpDirectoryInfo;
            }
            else return null;
        }

        public List<MyFileInfo> GetFilesList(string userFolder)
        {
            if (Directory.Exists(allUsersRoot + userFolder))
            {
                List<MyFileInfo> tmpFileInfoContracts = new List<MyFileInfo>();

                foreach (string varInfo in Directory.GetFiles(allUsersRoot + userFolder))
                {
                    FileInfo tmp=new FileInfo(varInfo);
                    tmpFileInfoContracts.Add(new MyFileInfo() {Name = tmp.Name,Size = tmp.Length,Time = tmp.LastWriteTime}); 
                }                           
 
                return tmpFileInfoContracts;
            }
            else return null;
        }

        public MyFileInfo GetFileInfo(string filepath)
        {
            if (File.Exists(allUsersRoot + filepath))
            {
                FileInfo tmp=new FileInfo(allUsersRoot + filepath);
                return new MyFileInfo() {Name = tmp.Name,Size = tmp.Length,Time = tmp.LastWriteTime};
            }               
            return null;
        }
    }
}
