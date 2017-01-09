using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Windows.Forms;

namespace ExamProjectDrive
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Drive : IDriveService
    {
        public List<Users> GetAllUsers()
        {
            //throw new NotImplementedException();
            using (var context = new ExamDriveEntities())
            {
                //var user = new User()
                //{
                //    Name = "Ivan",
                //    SurName = "Paber",
                //    Login = "LOGIN",
                //    Password = "PASS"
                //};

                //context.Users.Add(user);
                //context.SaveChanges();

                var query = from b in context.Users
                            orderby b.Name
                            select b;

                return (List<Users>)query;
            }
        }

        public void AddUser(Users user)
        {
            try
            {
                using (var context = new ExamDriveEntities())
                {
                    context.Users.Add(user);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                if (!File.Exists("ERRORS.txt"))
                {
                    File.Create("ERRORS.txt");
                }

                File.AppendAllText("ERRORS.txt", e.Message);
            }          
        }

        public void AddAccessLevel(Access_level level)
        {
            using (var context = new ExamDriveEntities())
            {
                context.Access_level.Add(level);
                context.SaveChanges();
            }
        }
    }
}
