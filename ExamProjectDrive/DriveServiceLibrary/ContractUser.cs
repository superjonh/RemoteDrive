using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DriveServiceLibrary
{

    [DataContract]
    public class ContractUser
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
        public Nullable<int> Age { get; set; }
        [DataMember]
        public byte[] Image { get; set; }
        [DataMember]
        public int Access_level_ID { get; set; }

    }
}
