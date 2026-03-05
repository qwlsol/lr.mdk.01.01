using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieShow
{
    public partial class MainForm : Form
    {
        List<Dish> allDishes = new List<Dish>();
        int totalOrdersAppetizer = 0;
        int totalOrdersMainCourse = 0;
        public MainForm()
        {
            InitializeComponent();
            ListBoxGroup.Items.Add("Закуски");
            ListBoxGroup.Items.Add("Горячее");

            totalOrdersDish.Minimum = 1;

            IDish dishLoader = new StorageDish();
            allDishes = dishLoader.LoadAllDish();
        }

        private void ListBoxGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxDish.Items.Clear();

            string selectedGroup = ListBoxGroup.SelectedItem.ToString();

            foreach (Dish dish in allDishes)
            {
                if (dish.Group == selectedGroup)
                {
                    ComboBoxDish.Items.Add(dish.Name);
                }
            }

            if (ComboBoxDish.Items.Count != 0)
            {
                ComboBoxDish.SelectedIndex = 0;
            }
        }

        private void ButtonOrderDish_Click(object sender, EventArgs e)
        {
            if (ComboBoxDish.SelectedItem != null && ListBoxGroup.SelectedItem != null)
            {
                string selectedDishName = ComboBoxDish.SelectedItem.ToString();
                string selectedGroup = ListBoxGroup.SelectedItem.ToString();

                Dish selectedDish = null;

                foreach (Dish dish in allDishes)
                {
                    if (dish.Name == selectedDishName && dish.Group == selectedGroup)
                    {
                        selectedDish = dish;
                        break;
                    }
                }

                if (selectedDish != null)
                {
                    int orders = (int)totalOrdersDish.Value;

                    RichTextBoxInfo.Text = selectedDish.GetInfo();
                    RichTextBoxInfo.Text += $"\nЗаказано порций: {orders}";
                }
            }
        }

        private void ComboBoxDish_SelectedIndexChanged(object sender, EventArgs e)
        {
            string dishName = ComboBoxDish.SelectedItem.ToString();

            foreach (Dish dish in allDishes)
            {
                if (dish.Name == dishName)
                {
                    PictureBoxDish.Load(dish.Photo);
                }
            }
        }
    }
}
