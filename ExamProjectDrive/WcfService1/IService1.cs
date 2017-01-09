using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService1
{
    [ServiceContract]
    public interface IDriveService
    {
        [OperationContract]
        List<User> GetAllUsers();

        [OperationContract]
        void AddUser(User user);

        [OperationContract]
        void AddAccessLevel(AccessLevel level);

    }


    [DataContract]
    public class User
    {

        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public string Login { get; set; }
        [DataMember]
        public string Password { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Surname { get; set; }
        [DataMember]
        public int Age { get; set; }
        [DataMember]
        public byte[] Image { get; set; }

        [DataMember]
        public int AccessLevelId { get; set; }
        [DataMember]
        public virtual AccessLevel AccessLevel { get; set; }
    }


    [DataContract]
    public class AccessLevel
    {
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public bool Read { get; set; }
        [DataMember]
        public bool Write { get; set; }
        [DataMember]
        public bool FullAccess { get; set; }

        [DataMember]
        public virtual List<User> Users { get; set; }
    }

    [DataContract]
    public class ExamDriveEntities : DbContext
    {
        [DataMember]
        public virtual DbSet<AccessLevel> AccessLevels { get; set; }
        [DataMember]
        public virtual DbSet<User> Users { get; set; }
    }
}
