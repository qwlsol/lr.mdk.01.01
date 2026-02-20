using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AddForm;
using ModelViewLib;
using ModelViewLib.Views;


namespace WindowsFormsApp1
{
    public class UserTableView : DataGridView, IUsersView
    {
        public bool Add(User user)
        {
            AddUserForm form = new AddUserForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
               
                    return true;
            }
            return false;
        }

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
