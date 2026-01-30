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
        private void CompletionMenu()
        {
            menuCategories = new Dictionary<string, List<Dish>>();

            string category1 = "Горячие блюда";
            List<Dish> dishes1 = new List<Dish>();

            Dish dish1 = new Dish("Стейк Рибай", "Нежный говяжий стейк с овощами", 1250, "Говядина, соль, перец, овощи");
            dishes1.Add(dish1);

            Dish dish2 = new Dish("Курица гриль", "Курица с травами и картофелем", 850, "Курица, травы, картофель");
            dishes1.Add(dish2);

            menuCategories.Add(category1, dishes1);



        }
    }
}