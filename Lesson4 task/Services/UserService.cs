using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lesson4_task.Model.Lesson4_task.Database;
using Lesson4_task.Model;

namespace Lesson4_task.Services
{
    public class UserService
    {
        public void AddUser(User user)
        {
            DemirtegramDB.Users.Add(user);
        }
        public void DeleteUser(Guid id)
        {
            var user = DemirtegramDB.Users.FirstOrDefault(u => u.Id == id);
            if (user != null)
            {
                DemirtegramDB.Users.Remove(user);
            }
        }
        public void GetAllUsers()
        {
            foreach(var user in DemirtegramDB.Users)
            {
                Console.WriteLine(user);

                foreach (var post in user.Posts)
                {
                    Console.WriteLine(post);
                    foreach(var comment in post.Comments)
                    {
                        Console.WriteLine("\t"+comment);
                    }
                }
            }
        }
        public User GetUser(Guid userid)
        {
            var user= DemirtegramDB.Users.FirstOrDefault(u => u.Id == userid);
            return user;
        }
        public void UpdateUser(User newUser) {
            var user = DemirtegramDB.Users.FirstOrDefault(u => u.Id == newUser.Id);
            if (user != null) {
                user.Name = newUser.Name;
                user.Surname = newUser.Surname;
                user.Posts= newUser.Posts;  
            }
            else
            {
                Console.WriteLine("User tapilmadi");
            }
        
        }
    }
}
