using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddForm
{
    public partial class AddUserForm: Form
    {
        public string UserLogin;
        public string UserPassword;
        public string UserName;
        public AddUserForm()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            UserLogin = textBoxLogin.Text;
            UserPassword = textBoxPassword.Text;
            UserName = textBoxName.Text;
            //DialogResult = DialogResult.Cancel;
            if (ShowDialog() == DialogResult.OK)
            {
                Close();
            }
            
        }
    }
}
