using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR3
{
    public partial class MainForm : Form
    {
        private Dictionary<string, List<Dish>> dish_ = new Dictionary<string, List<Dish>>();
        public MainForm()
        {
            InitializeComponent();

            dish_.Add("Завтраки", new List<Dish>(){new Dish("Омлет с ветчиной", 550, "Пышный омлет с ветчиной и зеленью",
                "Яйца, Ветчина, Молоко, Зелень", "E:\\мдк01.01\\LR3\\омлет.png") });

            dish_.Add("Основные Блюда", new List<Dish>(){new Dish("Паста Карбонара", 450, "Паста со сливочным соусом и беконом",
                "Паста, Бекон, Сливки, Сыр", "E:\\мдк01.01\\LR3\\карбонара.jfif") });

            List<string> allGroups = dish_.Keys.ToList();
            groupsDishLlistBox.DataSource = allGroups;
        }

        private void groupsDishLlistBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedGroups = groupsDishLlistBox.SelectedItem.ToString();
            List<Dish> dishSelectGroups = dish_[selectedGroups];

            dishComboBox.DataSource = dishSelectGroups;
            dishComboBox.DisplayMember = "Name";
        }

        private void dishComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Dish selectedDish = dishComboBox.SelectedItem as Dish;
            if (selectedDish != null)
            {
                priceLabel.Text = selectedDish.Price;
                descriptionLabel.Text = selectedDish.Discription;
                ingredientsLabel.Text = selectedDish.Ingredients;
                dishPictureBox.Load(selectedDish.ImagePath);
            }
        }
    }
}
