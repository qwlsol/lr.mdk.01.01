using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lr2
{
    internal class MobileSalesSystem
    {
        public class InputModule
        {
            static public (List<string>[], List<double>[]) InputPhonesByBrand()
            {
                List<string>[] phonesByBrand = new List<string>[3] { new List<string>(),
                                                                new List<string>(),
                                                                new List<string>()
            };

                List<double>[] weeklySales = new List<double>[3]{ new List<double>(),
                                                   new List<double>(),
                                                   new List<double>()
            };

                phonesByBrand[0].Add("iPhone 14");
                weeklySales[0].Add(15);
                phonesByBrand[0].Add("iPhone 13");
                weeklySales[0].Add(8);
                phonesByBrand[0].Add("iPhone SE");
                weeklySales[0].Add(3);

                phonesByBrand[1].Add("Galaxy S23");
                weeklySales[1].Add(12);
                phonesByBrand[1].Add("Galaxy A54");
                weeklySales[1].Add(18);

                phonesByBrand[2].Add("P60 Pro");
                weeklySales[2].Add(6);

                return (phonesByBrand, weeklySales);
            }

            static public string InputUserQuery()
            {
                Console.Write("Введите, пожалуйста, марку телефона (IPhone/Samsung/Huawei): ");
                return Console.ReadLine();
            }
            public class AnalysisDataModule
            {
                static public void SortPhones(List<string> phones, List<double> sales)
                {
                    for (int i = 0; i < sales.Count; ++i)
                    {
                        for (int j = 0; j < sales.Count - 1; ++j)
                        {
                            bool condition = sales[j + 1] > sales[j];
                            if (condition)
                            {
                                double temp_sales = sales[j];
                                sales[j] = sales[j + 1];
                                sales[j + 1] = temp_sales;

                                string temp_phones = phones[j];
                                phones[j] = phones[j + 1];
                                phones[j + 1] = temp_phones;
                            }
                        }
                    }
                }
            }
            static public double CalculateAverage(List<double> sales)
            {
                double sum = 0;
                foreach (double sale in sales)
                {
                    sum += sale;
                }

                return sum / sales.Count;
            }
        }
    }
}