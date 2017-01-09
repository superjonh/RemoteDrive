using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DriveServiceLibrary
{

    [DataContract]
    public class FileInfoContract
    {
         [DataMember]
         public string Name { get; set; }
         [DataMember]
         public long Length { get; set; }
         [DataMember]
         public string LastWriteTime { get; set; }
    }
}
