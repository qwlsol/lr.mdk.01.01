using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieShow
{
    public class StorageDish : IDish
    {
        public List<Dish> LoadAllDish()
        {
            List<Dish> allDish = new List<Dish>();

           string path = Path.Combine(Application.StartupPath, "data2.csv");

            try
            {
                using (StreamReader info = new StreamReader(path))
                {
                    string line;
                    while ((line = info.ReadLine()) != null)
                    {
                        if (!string.IsNullOrWhiteSpace(line))
                        {
                            string[] lines = line.Split(';');
                            if (lines.Length >= 6)
                            {
                                allDish.Add(new Dish(
                                    lines[1],
                                    Convert.ToInt32(lines[2]),
                                    lines[3],
                                    lines[4],
                                    lines[5],
                                    lines[0]
                                ));
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки данных: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return allDish;
            /*
            List<Dish> allDish = new List<Dish>();
            string path = @"data2.csv";
            StreamReader info = new StreamReader(path);
            string line;
            while ((line = info.ReadLine()) != null)
            {
                string[] lines = line.Split(';');
                allDish.Add(new Dish(lines[0], Convert.ToInt32(lines[1]), lines[2], lines[3], lines[4], lines[5]));
            }
            info.Close();
            return allDish;*/
        }//C:\П-30\MDK01.01\LR3\DishRestorant\
    }
}
    

