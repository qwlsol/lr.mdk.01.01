using System.Collections.Generic;
using System.Windows.Forms;

namespace LR3 
{
    public partial class MainForm : Form
    {
        private Dictionary<string, List<Dish>> menuCategories;
        private Dictionary<string, int> orderQuantities;
        public MainForm()
        {
            InitializeComponent();
        }
    }
}
