﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DriveClient.DriveServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ContractUser", Namespace="http://schemas.datacontract.org/2004/07/DriveServiceLibrary")]
    [System.SerializableAttribute()]
    public partial class ContractUser : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Access_level_IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> AgeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private byte[] ImageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LoginField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SurnameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Access_level_ID {
            get {
                return this.Access_level_IDField;
            }
            set {
                if ((this.Access_level_IDField.Equals(value) != true)) {
                    this.Access_level_IDField = value;
                    this.RaisePropertyChanged("Access_level_ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> Age {
            get {
                return this.AgeField;
            }
            set {
                if ((this.AgeField.Equals(value) != true)) {
                    this.AgeField = value;
                    this.RaisePropertyChanged("Age");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ID {
            get {
                return this.IDField;
            }
            set {
                if ((this.IDField.Equals(value) != true)) {
                    this.IDField = value;
                    this.RaisePropertyChanged("ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public byte[] Image {
            get {
                return this.ImageField;
            }
            set {
                if ((object.ReferenceEquals(this.ImageField, value) != true)) {
                    this.ImageField = value;
                    this.RaisePropertyChanged("Image");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Login {
            get {
                return this.LoginField;
            }
            set {
                if ((object.ReferenceEquals(this.LoginField, value) != true)) {
                    this.LoginField = value;
                    this.RaisePropertyChanged("Login");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Password {
            get {
                return this.PasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.PasswordField, value) != true)) {
                    this.PasswordField = value;
                    this.RaisePropertyChanged("Password");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Surname {
            get {
                return this.SurnameField;
            }
            set {
                if ((object.ReferenceEquals(this.SurnameField, value) != true)) {
                    this.SurnameField = value;
                    this.RaisePropertyChanged("Surname");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Users", Namespace="http://schemas.datacontract.org/2004/07/DriveServiceLibrary")]
    [System.SerializableAttribute()]
    public partial class Users : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Access_level_IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> AgeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private byte[] ImageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LoginField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SurnameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Access_level_ID {
            get {
                return this.Access_level_IDField;
            }
            set {
                if ((this.Access_level_IDField.Equals(value) != true)) {
                    this.Access_level_IDField = value;
                    this.RaisePropertyChanged("Access_level_ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> Age {
            get {
                return this.AgeField;
            }
            set {
                if ((this.AgeField.Equals(value) != true)) {
                    this.AgeField = value;
                    this.RaisePropertyChanged("Age");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ID {
            get {
                return this.IDField;
            }
            set {
                if ((this.IDField.Equals(value) != true)) {
                    this.IDField = value;
                    this.RaisePropertyChanged("ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public byte[] Image {
            get {
                return this.ImageField;
            }
            set {
                if ((object.ReferenceEquals(this.ImageField, value) != true)) {
                    this.ImageField = value;
                    this.RaisePropertyChanged("Image");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Login {
            get {
                return this.LoginField;
            }
            set {
                if ((object.ReferenceEquals(this.LoginField, value) != true)) {
                    this.LoginField = value;
                    this.RaisePropertyChanged("Login");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Password {
            get {
                return this.PasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.PasswordField, value) != true)) {
                    this.PasswordField = value;
                    this.RaisePropertyChanged("Password");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Surname {
            get {
                return this.SurnameField;
            }
            set {
                if ((object.ReferenceEquals(this.SurnameField, value) != true)) {
                    this.SurnameField = value;
                    this.RaisePropertyChanged("Surname");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Access_level", Namespace="http://schemas.datacontract.org/2004/07/DriveServiceLibrary")]
    [System.SerializableAttribute()]
    public partial class Access_level : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<bool> Full_accessField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<bool> ReadField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<bool> WriteField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<bool> Full_access {
            get {
                return this.Full_accessField;
            }
            set {
                if ((this.Full_accessField.Equals(value) != true)) {
                    this.Full_accessField = value;
                    this.RaisePropertyChanged("Full_access");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ID {
            get {
                return this.IDField;
            }
            set {
                if ((this.IDField.Equals(value) != true)) {
                    this.IDField = value;
                    this.RaisePropertyChanged("ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<bool> Read {
            get {
                return this.ReadField;
            }
            set {
                if ((this.ReadField.Equals(value) != true)) {
                    this.ReadField = value;
                    this.RaisePropertyChanged("Read");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<bool> Write {
            get {
                return this.WriteField;
            }
            set {
                if ((this.WriteField.Equals(value) != true)) {
                    this.WriteField = value;
                    this.RaisePropertyChanged("Write");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="MyFileInfo", Namespace="http://schemas.datacontract.org/2004/07/DriveServiceLibrary")]
    [System.SerializableAttribute()]
    public partial class MyFileInfo : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long SizeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime TimeField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long Size {
            get {
                return this.SizeField;
            }
            set {
                if ((this.SizeField.Equals(value) != true)) {
                    this.SizeField = value;
                    this.RaisePropertyChanged("Size");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Time {
            get {
                return this.TimeField;
            }
            set {
                if ((this.TimeField.Equals(value) != true)) {
                    this.TimeField = value;
                    this.RaisePropertyChanged("Time");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="DriveServiceReference.IDriveService")]
    public interface IDriveService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDriveService/GetAllUsers", ReplyAction="http://tempuri.org/IDriveService/GetAllUsersResponse")]
        DriveClient.DriveServiceReference.ContractUser[] GetAllUsers();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDriveService/GetAllUsers", ReplyAction="http://tempuri.org/IDriveService/GetAllUsersResponse")]
        System.Threading.Tasks.Task<DriveClient.DriveServiceReference.ContractUser[]> GetAllUsersAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDriveService/AddUser", ReplyAction="http://tempuri.org/IDriveService/AddUserResponse")]
        bool AddUser(DriveClient.DriveServiceReference.Users user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDriveService/AddUser", ReplyAction="http://tempuri.org/IDriveService/AddUserResponse")]
        System.Threading.Tasks.Task<bool> AddUserAsync(DriveClient.DriveServiceReference.Users user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDriveService/ChangeUserData", ReplyAction="http://tempuri.org/IDriveService/ChangeUserDataResponse")]
        bool ChangeUserData(DriveClient.DriveServiceReference.ContractUser user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDriveService/ChangeUserData", ReplyAction="http://tempuri.org/IDriveService/ChangeUserDataResponse")]
        System.Threading.Tasks.Task<bool> ChangeUserDataAsync(DriveClient.DriveServiceReference.ContractUser user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDriveService/AddAccessLevel", ReplyAction="http://tempuri.org/IDriveService/AddAccessLevelResponse")]
        void AddAccessLevel(DriveClient.DriveServiceReference.Access_level level);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDriveService/AddAccessLevel", ReplyAction="http://tempuri.org/IDriveService/AddAccessLevelResponse")]
        System.Threading.Tasks.Task AddAccessLevelAsync(DriveClient.DriveServiceReference.Access_level level);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDriveService/GetLastAccessID", ReplyAction="http://tempuri.org/IDriveService/GetLastAccessIDResponse")]
        int GetLastAccessID();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDriveService/GetLastAccessID", ReplyAction="http://tempuri.org/IDriveService/GetLastAccessIDResponse")]
        System.Threading.Tasks.Task<int> GetLastAccessIDAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDriveService/CheckLoggedUser", ReplyAction="http://tempuri.org/IDriveService/CheckLoggedUserResponse")]
        DriveClient.DriveServiceReference.ContractUser CheckLoggedUser(string login, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDriveService/CheckLoggedUser", ReplyAction="http://tempuri.org/IDriveService/CheckLoggedUserResponse")]
        System.Threading.Tasks.Task<DriveClient.DriveServiceReference.ContractUser> CheckLoggedUserAsync(string login, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDriveService/WriteFile", ReplyAction="http://tempuri.org/IDriveService/WriteFileResponse")]
        bool WriteFile(string filePath, byte[] fileBytes);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDriveService/WriteFile", ReplyAction="http://tempuri.org/IDriveService/WriteFileResponse")]
        System.Threading.Tasks.Task<bool> WriteFileAsync(string filePath, byte[] fileBytes);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDriveService/DeleteFile", ReplyAction="http://tempuri.org/IDriveService/DeleteFileResponse")]
        bool DeleteFile(string filePath);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDriveService/DeleteFile", ReplyAction="http://tempuri.org/IDriveService/DeleteFileResponse")]
        System.Threading.Tasks.Task<bool> DeleteFileAsync(string filePath);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDriveService/DeleteFolder", ReplyAction="http://tempuri.org/IDriveService/DeleteFolderResponse")]
        bool DeleteFolder(string folderPath);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDriveService/DeleteFolder", ReplyAction="http://tempuri.org/IDriveService/DeleteFolderResponse")]
        System.Threading.Tasks.Task<bool> DeleteFolderAsync(string folderPath);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDriveService/CreateFolder", ReplyAction="http://tempuri.org/IDriveService/CreateFolderResponse")]
        bool CreateFolder(string folderPath);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDriveService/CreateFolder", ReplyAction="http://tempuri.org/IDriveService/CreateFolderResponse")]
        System.Threading.Tasks.Task<bool> CreateFolderAsync(string folderPath);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDriveService/IfExists", ReplyAction="http://tempuri.org/IDriveService/IfExistsResponse")]
        bool IfExists(string path);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDriveService/IfExists", ReplyAction="http://tempuri.org/IDriveService/IfExistsResponse")]
        System.Threading.Tasks.Task<bool> IfExistsAsync(string path);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDriveService/GetFileBytes", ReplyAction="http://tempuri.org/IDriveService/GetFileBytesResponse")]
        byte[] GetFileBytes(string filePath);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDriveService/GetFileBytes", ReplyAction="http://tempuri.org/IDriveService/GetFileBytesResponse")]
        System.Threading.Tasks.Task<byte[]> GetFileBytesAsync(string filePath);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDriveService/GetFileBytesDirect", ReplyAction="http://tempuri.org/IDriveService/GetFileBytesDirectResponse")]
        byte[] GetFileBytesDirect(string filePath);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDriveService/GetFileBytesDirect", ReplyAction="http://tempuri.org/IDriveService/GetFileBytesDirectResponse")]
        System.Threading.Tasks.Task<byte[]> GetFileBytesDirectAsync(string filePath);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDriveService/GetDirectoryInfo", ReplyAction="http://tempuri.org/IDriveService/GetDirectoryInfoResponse")]
        System.IO.DirectoryInfo GetDirectoryInfo(string userFolder);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDriveService/GetDirectoryInfo", ReplyAction="http://tempuri.org/IDriveService/GetDirectoryInfoResponse")]
        System.Threading.Tasks.Task<System.IO.DirectoryInfo> GetDirectoryInfoAsync(string userFolder);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDriveService/GetDirectoriesList", ReplyAction="http://tempuri.org/IDriveService/GetDirectoriesListResponse")]
        System.IO.DirectoryInfo[] GetDirectoriesList(string userFolder);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDriveService/GetDirectoriesList", ReplyAction="http://tempuri.org/IDriveService/GetDirectoriesListResponse")]
        System.Threading.Tasks.Task<System.IO.DirectoryInfo[]> GetDirectoriesListAsync(string userFolder);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDriveService/GetDirectoriesListDirect", ReplyAction="http://tempuri.org/IDriveService/GetDirectoriesListDirectResponse")]
        System.IO.DirectoryInfo[] GetDirectoriesListDirect(string userFolder);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDriveService/GetDirectoriesListDirect", ReplyAction="http://tempuri.org/IDriveService/GetDirectoriesListDirectResponse")]
        System.Threading.Tasks.Task<System.IO.DirectoryInfo[]> GetDirectoriesListDirectAsync(string userFolder);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDriveService/GetFilesList", ReplyAction="http://tempuri.org/IDriveService/GetFilesListResponse")]
        DriveClient.DriveServiceReference.MyFileInfo[] GetFilesList(string userFolder);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDriveService/GetFilesList", ReplyAction="http://tempuri.org/IDriveService/GetFilesListResponse")]
        System.Threading.Tasks.Task<DriveClient.DriveServiceReference.MyFileInfo[]> GetFilesListAsync(string userFolder);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDriveService/GetUserRoot", ReplyAction="http://tempuri.org/IDriveService/GetUserRootResponse")]
        string GetUserRoot(string userName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDriveService/GetUserRoot", ReplyAction="http://tempuri.org/IDriveService/GetUserRootResponse")]
        System.Threading.Tasks.Task<string> GetUserRootAsync(string userName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDriveService/GetFileInfo", ReplyAction="http://tempuri.org/IDriveService/GetFileInfoResponse")]
        DriveClient.DriveServiceReference.MyFileInfo GetFileInfo(string filepath);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDriveService/GetFileInfo", ReplyAction="http://tempuri.org/IDriveService/GetFileInfoResponse")]
        System.Threading.Tasks.Task<DriveClient.DriveServiceReference.MyFileInfo> GetFileInfoAsync(string filepath);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IDriveServiceChannel : DriveClient.DriveServiceReference.IDriveService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DriveServiceClient : System.ServiceModel.ClientBase<DriveClient.DriveServiceReference.IDriveService>, DriveClient.DriveServiceReference.IDriveService {
        
        public DriveServiceClient() {
        }
        
        public DriveServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public DriveServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DriveServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DriveServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public DriveClient.DriveServiceReference.ContractUser[] GetAllUsers() {
            return base.Channel.GetAllUsers();
        }
        
        public System.Threading.Tasks.Task<DriveClient.DriveServiceReference.ContractUser[]> GetAllUsersAsync() {
            return base.Channel.GetAllUsersAsync();
        }
        
        public bool AddUser(DriveClient.DriveServiceReference.Users user) {
            return base.Channel.AddUser(user);
        }
        
        public System.Threading.Tasks.Task<bool> AddUserAsync(DriveClient.DriveServiceReference.Users user) {
            return base.Channel.AddUserAsync(user);
        }
        
        public bool ChangeUserData(DriveClient.DriveServiceReference.ContractUser user) {
            return base.Channel.ChangeUserData(user);
        }
        
        public System.Threading.Tasks.Task<bool> ChangeUserDataAsync(DriveClient.DriveServiceReference.ContractUser user) {
            return base.Channel.ChangeUserDataAsync(user);
        }
        
        public void AddAccessLevel(DriveClient.DriveServiceReference.Access_level level) {
            base.Channel.AddAccessLevel(level);
        }
        
        public System.Threading.Tasks.Task AddAccessLevelAsync(DriveClient.DriveServiceReference.Access_level level) {
            return base.Channel.AddAccessLevelAsync(level);
        }
        
        public int GetLastAccessID() {
            return base.Channel.GetLastAccessID();
        }
        
        public System.Threading.Tasks.Task<int> GetLastAccessIDAsync() {
            return base.Channel.GetLastAccessIDAsync();
        }
        
        public DriveClient.DriveServiceReference.ContractUser CheckLoggedUser(string login, string password) {
            return base.Channel.CheckLoggedUser(login, password);
        }
        
        public System.Threading.Tasks.Task<DriveClient.DriveServiceReference.ContractUser> CheckLoggedUserAsync(string login, string password) {
            return base.Channel.CheckLoggedUserAsync(login, password);
        }
        
        public bool WriteFile(string filePath, byte[] fileBytes) {
            return base.Channel.WriteFile(filePath, fileBytes);
        }
        
        public System.Threading.Tasks.Task<bool> WriteFileAsync(string filePath, byte[] fileBytes) {
            return base.Channel.WriteFileAsync(filePath, fileBytes);
        }
        
        public bool DeleteFile(string filePath) {
            return base.Channel.DeleteFile(filePath);
        }
        
        public System.Threading.Tasks.Task<bool> DeleteFileAsync(string filePath) {
            return base.Channel.DeleteFileAsync(filePath);
        }
        
        public bool DeleteFolder(string folderPath) {
            return base.Channel.DeleteFolder(folderPath);
        }
        
        public System.Threading.Tasks.Task<bool> DeleteFolderAsync(string folderPath) {
            return base.Channel.DeleteFolderAsync(folderPath);
        }
        
        public bool CreateFolder(string folderPath) {
            return base.Channel.CreateFolder(folderPath);
        }
        
        public System.Threading.Tasks.Task<bool> CreateFolderAsync(string folderPath) {
            return base.Channel.CreateFolderAsync(folderPath);
        }
        
        public bool IfExists(string path) {
            return base.Channel.IfExists(path);
        }
        
        public System.Threading.Tasks.Task<bool> IfExistsAsync(string path) {
            return base.Channel.IfExistsAsync(path);
        }
        
        public byte[] GetFileBytes(string filePath) {
            return base.Channel.GetFileBytes(filePath);
        }
        
        public System.Threading.Tasks.Task<byte[]> GetFileBytesAsync(string filePath) {
            return base.Channel.GetFileBytesAsync(filePath);
        }
        
        public byte[] GetFileBytesDirect(string filePath) {
            return base.Channel.GetFileBytesDirect(filePath);
        }
        
        public System.Threading.Tasks.Task<byte[]> GetFileBytesDirectAsync(string filePath) {
            return base.Channel.GetFileBytesDirectAsync(filePath);
        }
        
        public System.IO.DirectoryInfo GetDirectoryInfo(string userFolder) {
            return base.Channel.GetDirectoryInfo(userFolder);
        }
        
        public System.Threading.Tasks.Task<System.IO.DirectoryInfo> GetDirectoryInfoAsync(string userFolder) {
            return base.Channel.GetDirectoryInfoAsync(userFolder);
        }
        
        public System.IO.DirectoryInfo[] GetDirectoriesList(string userFolder) {
            return base.Channel.GetDirectoriesList(userFolder);
        }
        
        public System.Threading.Tasks.Task<System.IO.DirectoryInfo[]> GetDirectoriesListAsync(string userFolder) {
            return base.Channel.GetDirectoriesListAsync(userFolder);
        }
        
        public System.IO.DirectoryInfo[] GetDirectoriesListDirect(string userFolder) {
            return base.Channel.GetDirectoriesListDirect(userFolder);
        }
        
        public System.Threading.Tasks.Task<System.IO.DirectoryInfo[]> GetDirectoriesListDirectAsync(string userFolder) {
            return base.Channel.GetDirectoriesListDirectAsync(userFolder);
        }
        
        public DriveClient.DriveServiceReference.MyFileInfo[] GetFilesList(string userFolder) {
            return base.Channel.GetFilesList(userFolder);
        }
        
        public System.Threading.Tasks.Task<DriveClient.DriveServiceReference.MyFileInfo[]> GetFilesListAsync(string userFolder) {
            return base.Channel.GetFilesListAsync(userFolder);
        }
        
        public string GetUserRoot(string userName) {
            return base.Channel.GetUserRoot(userName);
        }
        
        public System.Threading.Tasks.Task<string> GetUserRootAsync(string userName) {
            return base.Channel.GetUserRootAsync(userName);
        }
        
        public DriveClient.DriveServiceReference.MyFileInfo GetFileInfo(string filepath) {
            return base.Channel.GetFileInfo(filepath);
        }
        
        public System.Threading.Tasks.Task<DriveClient.DriveServiceReference.MyFileInfo> GetFileInfoAsync(string filepath) {
            return base.Channel.GetFileInfoAsync(filepath);
        }
    }
}
