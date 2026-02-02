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
                "Яйца, Ветчина, Молоко, Зелень") });

            dish_.Add("Основные Блюда", new List<Dish>(){new Dish("Паста Карбонара", 450, "Паста со сливочным соусом и беконом", "Паста, Бекон, Сливки, Сыр") });

        }
    }
}
