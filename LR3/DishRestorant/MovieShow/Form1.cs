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

            // Проверяем, что компоненты существуют
            if (ListBoxGroup != null)
            {
                ListBoxGroup.Items.Add("Закуски");
                ListBoxGroup.Items.Add("Горячее");
            }

            if (totalOrdersDish != null)
            {
                totalOrdersDish.Minimum = 1;
                totalOrdersDish.Value = 1;
            }

            // Загружаем данные
            try
            {
                IDish dishLoader = new StorageDish();
                allDishes = dishLoader.LoadAllDish();

                if (allDishes.Count == 0)
                {
                    MessageBox.Show("Не удалось загрузить блюда. Проверьте файл data2.csv",
                        "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при создании загрузчика: {ex.Message}",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ListBoxGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListBoxGroup.SelectedItem == null) return;

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

                    // Обновляем статистику (если нужно)
                    if (selectedGroup == "Закуски")
                    {
                        totalOrdersAppetizer += orders;
                    }
                    else if (selectedGroup == "Горячее")
                    {
                        totalOrdersMainCourse += orders;
                    }

                    RichTextBoxInfo.Text = selectedDish.GetInfo();
                    RichTextBoxInfo.Text += $"\nЗаказано порций: {orders}";
                }
            }
            else
            {
                MessageBox.Show("Выберите группу и блюдо!", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ComboBoxDish_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxDish.SelectedItem == null) return;

            string dishName = ComboBoxDish.SelectedItem.ToString();

            foreach (Dish dish in allDishes)
            {
                if (dish.Name == dishName)
                {
                    try
                    {
                        // Проверяем, существует ли файл изображения
                        if (System.IO.File.Exists(dish.Photo))
                        {
                            PictureBoxDish.Load(dish.Photo);
                        }
                        else
                        {
                            // Если файл не найден, очищаем PictureBox
                            PictureBoxDish.Image = null;
                            MessageBox.Show($"Файл изображения не найден: {dish.Photo}",
                                "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    catch (Exception ex)
                    {
                        PictureBoxDish.Image = null;
                        MessageBox.Show($"Ошибка загрузки изображения: {ex.Message}",
                            "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                }
            }
        }
    }
}