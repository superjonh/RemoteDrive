using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace DriveServiceLibrary
{
    [ServiceContract]
    public interface IDriveService
    {
        [OperationContract]
        List<ContractUser> GetAllUsers();

        [OperationContract]
        bool AddUser(Users user);

        [OperationContract]
        bool ChangeUserData(ContractUser user);

        [OperationContract]
        void AddAccessLevel(Access_level level);

        [OperationContract]
        int GetLastAccessID();

        [OperationContract]
        ContractUser CheckLoggedUser(string login, string password);

        [OperationContract]
        bool WriteFile(string filePath, byte[] fileBytes);

        [OperationContract]
        bool DeleteFile(string filePath);

        [OperationContract]
        bool DeleteFolder(string folderPath);

        [OperationContract]
        bool CreateFolder(string folderPath);

        [OperationContract]
        bool IfExists(string path);

        [OperationContract]
        byte[] GetFileBytes(string filePath);

        [OperationContract]
        byte[] GetFileBytesDirect(string filePath);

        [OperationContract]
        DirectoryInfo GetDirectoryInfo(string userFolder);

        [OperationContract]
        List<DirectoryInfo> GetDirectoriesList(string userFolder);

        [OperationContract]
        List<DirectoryInfo> GetDirectoriesListDirect(string userFolder);

        [OperationContract]
        List<MyFileInfo> GetFilesList(string userFolder);

        [OperationContract]
        string GetUserRoot(string userName);

        [OperationContract]
        MyFileInfo GetFileInfo(string filepath);

    }


  

}
