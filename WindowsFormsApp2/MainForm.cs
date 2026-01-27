using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class MainForm : Form
    {
        private List<HomoSapiens> peoples_ = new List<HomoSapiens>();
        public MainForm()
        {
            InitializeComponent();
            peoples_.Add(new HomoSapiens("Ольга", 20));
            peoples_.Add(new HomoSapiens("Олег", 19));
            peoples_.Add(new Student(1220));
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            foreach (HomoSapiens people in peoples_)
            {
                InfoRichTextBox.AppendText(people.ToString());
            }

        }
        public List<string> AllStudentsInfo()
        {
            List<string> result = new List<string>();
            foreach(HomoSapiens people in peoples_)
            {
                Student st = people as Student;
            }
            return result;

        }
    }
}
