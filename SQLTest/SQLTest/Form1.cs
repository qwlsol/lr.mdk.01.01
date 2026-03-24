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
        }

        private void button2_Click(object sender, EventArgs e)
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
            AddForm addForm = new AddForm();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                pgUsersLoader.AddUser(addForm.textBox1.Text, addForm.textBox2.Text, Convert.ToInt32(addForm.numericUpDown1.Text), addForm.textBox4.Text);
                List<User> users = pgUsersLoader.Load();
                userDataGridView.DataSource = users;
            }
        }
    }
}
