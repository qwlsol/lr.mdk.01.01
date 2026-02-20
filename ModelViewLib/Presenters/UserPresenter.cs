using ModelViewLib.Models;
using ModelViewLib.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelViewLib.Presenters
{
    public class UserPresenter
    {
        private IUsersModel model_;
        private IUsersView view_;

        public UserPresenter(IUsersModel model, IUsersView view)
        {
            model_ = model;
            view_ = view;

            view_.DisplayUsers(model_.UserUpload());
        }

        public void RemoveUser(List<User> users)
        {
            model_.RemoveUsers(users);
            view_.DisplayUsers(model_.UserUpload());

        }
        public void AddUser()
        {
            User newUser = null;
            if (view_.Add(newUser))
            {
                if (model_.UserRegistration(newUser))
                {
                    view_.DisplayUsers(model_.UserUpload());
                }
            }
        }
    }
}