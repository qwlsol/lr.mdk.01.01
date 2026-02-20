
using System.Collections.Generic;

namespace ModelViewLib.Views
{
    public interface IUsersView
    {
        void DisplayUsers(List<User> users);
       
        List<User> GetSelectedUsers();

        bool Add(User user);
    }
}
