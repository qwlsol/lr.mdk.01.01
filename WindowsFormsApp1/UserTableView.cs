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
    public class UserTableView : DataGridView, IUsersView
    {
        
        public void DisplayUsers(List<User> users)
        {
            DataSource = null;
           DataSource = users;
        }

        public List<User> GetSelectedUsers()
        {
          List<User> result = new List<User>();
            foreach (DataGridViewRow row in SelectedRows) 
            {
                result.Add(row.DataBoundItem as User);
            }
            return result;
        }
    }
}
