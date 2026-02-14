using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelViewLib.Models
{
    public class MemoryUsersModel : IUsersModel
    {   private List<User> users_ = new List<User>();
        public MemoryUsersModel() 
        {
            users_.Add(new User("Lush", "aaa123", "Луч"));
            users_.Add(new User("Forest", "bbb163", "Лес"));
            users_.Add(new User("House", "vvv113", "Дом"));
            users_.Add(new User("Elephant", "ccc124", "Слон"));

        }
        public bool UserRegistration(User user)
        {
            int count = users_.Count;
            users_.Add(user);
            if (users_.Count == count + 1)
            {
                return true;
            }
            return false;
        }

        public List<User> UserUpload()
        {
            return users_;
        }
    }
}
