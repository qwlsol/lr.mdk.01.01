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
    {IUsersModel model_ = new MemoryUsersModel();
        UserPresenter presenter_;
        public MainForm()
        {
            InitializeComponent();

            UsersTableView tableView = new UsersTableView();
            Controls.Add(tableView);

            tableView.Dock = DockStyle.Fill;

            UserPresenter user = new UserPresenter(new MemoryUsersModel(), tableView);
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            List<User> selectedUsers = UsersView.GetSelectedUsers();
            presenter_.Remove(selectedUsers);
        }
    }
}
