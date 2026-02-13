using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModelViewLib;
using ModelViewLib.Views;


namespace WindowsFormsApp1
{
    public class UsersTableView : DataGridView, IUsersView
    {
        public void DisplayUsers(List<User> users)
        {
           DataSource = users;
        }
    }
}
