using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieShow
{
    internal class StorageDish : IDish
    {
        public List<Dish> LoadAllDish()
        {
            List<Dish> allDish = new List<Dish>();
            string path = @"E:\репозиторий\LR3\VARIANT 3\MovieShow\data.csv";
            StreamReader info = new StreamReader(path);
            string line;
            while ((line = info.ReadLine()) != null)
            {
                string[] lines = line.Split(';');
                allDish.Add(new Dish(lines[1], Convert.ToInt32(lines[2]), lines[3], lines[4], lines[5], lines[0]));
            }
            info.Close();
            return allDish;
        }
    }
}
    

