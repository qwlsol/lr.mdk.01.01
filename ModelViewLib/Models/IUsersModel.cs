using System.Collections.Generic;

namespace ModelViewLib.Models
{
    public interface IUsersModel
    {
        List<User> UserUpload();

        bool UserRegistration(User user);
        void RemoveUsers(List<User> users);
    }
}
