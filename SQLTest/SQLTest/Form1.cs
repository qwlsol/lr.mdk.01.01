using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace SQLTest
{
    public partial class Form1: Form
    {
        PgUsersLoader pgUsersLoader = new PgUsersLoader();
        
        public Form1()
        {
            InitializeComponent();
            List<User> users = pgUsersLoader.Load();
            userDataGridView.DataSource = users;
            userDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
          
        }
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (userDataGridView.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in userDataGridView.SelectedRows)
                {
                    User user = row.DataBoundItem as User;
                    if (user != null)
                    {
                        pgUsersLoader.DeleteUser(user.Login);
                    }
                }
                List<User> users = pgUsersLoader.Load();
                userDataGridView.DataSource = users;


            }
            
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            AddEditForm addForm = new AddEditForm();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                pgUsersLoader.AddUser(addForm.textBoxLogin.Text, addForm.textBoxPassword.Text, Convert.ToInt32(addForm.numericUpDownAge.Text), addForm.textBoxName.Text);
                List<User> users = pgUsersLoader.Load();
                userDataGridView.DataSource = users;
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (userDataGridView.SelectedRows.Count > 0)
            {
                User selectedUser = userDataGridView.SelectedRows[0].DataBoundItem as User;
                
                AddEditForm editForm = new AddEditForm(selectedUser);
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    pgUsersLoader.UpdateUser(selectedUser);
                    userDataGridView.DataSource = pgUsersLoader.Load();
                }
                else 
                {
                    MessageBox.Show("Изменения не были применены.");
                }

            }
        }
    }
}
