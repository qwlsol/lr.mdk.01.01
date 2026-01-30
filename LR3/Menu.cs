using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR3
{
    internal class Menu
    {
        public Dictionary<Menu, List<Dish>> menuDictionary;
        public Menu()
        {
            menuDictionary = new Dictionary<Menu, List<Dish>>();
            CreateMenu();
        }
    }
}
