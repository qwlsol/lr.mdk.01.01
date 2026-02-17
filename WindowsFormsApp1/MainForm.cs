using ModelViewLib;
using ModelViewLib.Models;
using ModelViewLib.Presenters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        private UserPresenter presenter_;
        public MainForm()
        {
            InitializeComponent();

            presenter_ = new UserPresenter(new MemoryUsersModel(), UsersView);
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы точно хотите удалить пользователя?", "Внимание!!", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                List<User> selectedUsers = UsersView.GetSelectedUsers();
                presenter_.RemoveUser(selectedUsers);
            }
        }
    }
}
