using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Net.Mime;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ExamProjectDrive
{
   
    [ServiceContract]
    public interface IDriveService
    {
        [OperationContract]
        List<Users> GetAllUsers();

        [OperationContract]
        void AddUser(Users user);

        [OperationContract]
        void AddAccessLevel(Access_level level);

    }

  
    //[DataContract]
    //public class User
    //{
    //    [DataMember]
    //    public int UserId { get; set; }
    //    [DataMember]
    //    public string Name { get; set; }
    //    [DataMember]
    //    public string SurName { get; set; }
    //    [DataMember]
    //    public string Login { get; set; }
    //    [DataMember]
    //    public string Password { get; set; }      
    //    [DataMember]
    //    public int AccessLevelId { get; set; }              
    //}

    //[DataContract]
    //public class AccessLevel
    //{
    //    [DataMember]
    //    public int AccessLevelId { get; set; }
    //    [DataMember]
    //    public bool Read { get; set; }
    //    [DataMember]
    //    public bool Write { get; set; }
    //    [DataMember]
    //    public bool FullAccess { get; set; }

    //}


    //[DataContract]
    //public class DriveContext : DbContext
    //{
    //    public DbSet<User> Users { get; set; }
    //    public DbSet<AccessLevel> AccessLevels { get; set; }
    //}

}
