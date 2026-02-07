using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace LR3
{
    public partial class MainForm : Form
    {
        private Dictionary<string, List<Dish>> dish_ = new Dictionary<string, List<Dish>>();
        private IDataLoader dataLoader;
        public MainForm()
        {
            InitializeComponent();
            dataLoader = new CsvDataLoader();


           try
            dish_ = dataLoader.LoadData();

            if (dish_.Count > 0)
            {
                List<string> allGroups = new List<string>(dish_.Keys);
                groupsDishLlistBox.DataSource = allGroups;
            }
            

        /* dish_.Add("Завтраки", new List<Dish>(){new Dish("Омлет с ветчиной", 550, "Пышный омлет с ветчиной и зеленью",
             "Яйца, Ветчина, Молоко, Зелень", "D:\\П-30\\реп\\LR3\\омлет.png"),

             new Dish("Гренки с авокадо", 420, "Хрустящие гренки с пюре из авокадо",
         "Хлеб, Авокадо, Лимонный сок, Специи", "D:\\П-30\\реп\\LR3\\гренки.png")});

         dish_.Add("Основные Блюда", new List<Dish>(){new Dish("Паста Карбонара", 450, "Паста со сливочным соусом и беконом",
             "Паста, Бекон, Сливки, Сыр", "D:\\П-30\\реп\\LR3\\карбонара.jfif"),
              new Dish("Курица терияки", 650, "Курица в соусе терияки с рисом",
         "Куриное филе, Соус терияки, Рис, Овощи", "D:\\П-30\\реп\\LR3\\терияки.jpg")});

         List<string> allGroups = dish_.Keys.ToList();
         groupsDishLlistBox.DataSource = allGroups;*/


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
