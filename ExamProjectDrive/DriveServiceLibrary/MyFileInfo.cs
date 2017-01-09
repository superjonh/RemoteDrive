using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DriveServiceLibrary
{
    [DataContract]
    public class MyFileInfo
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public long Size { get; set; }
        [DataMember]
        public DateTime Time { get; set; }

    }
}
