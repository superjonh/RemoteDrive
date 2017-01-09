using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService1
{
    public class Drive : IDriveService
    {
        public List<User> GetAllUsers()
        {
            using (var context = new ExamDriveEntities())
            {
                return context.Users.ToList();
            }
        }

        public void AddUser(User user)
        {
            using (var context = new ExamDriveEntities())
            {
          
            }
        }

        public void AddAccessLevel(AccessLevel level)
        {
            throw new NotImplementedException();
        }

    }
}
