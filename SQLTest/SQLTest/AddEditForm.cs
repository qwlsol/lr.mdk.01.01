using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLTest
{
    public partial class AddEditForm : Form
    {
        public User CurrentUser { get; private set; }
        public AddEditForm()
        {
            InitializeComponent();
            CurrentUser = new User();
            Data();
        }
        public AddEditForm(User user)
        {
            InitializeComponent();
            CurrentUser = user;
            Data();
        }
        private void Data()
        {
            textBoxLogin.DataBindings.Add("Text", CurrentUser, "Login");
            textBoxPassword.DataBindings.Add("Text", CurrentUser, "Password");
            textBoxName.DataBindings.Add("Text", CurrentUser, "Name");
            numericUpDownAge.DataBindings.Add("Value", CurrentUser, "Age");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
