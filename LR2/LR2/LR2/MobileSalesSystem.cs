using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR2
{
    internal class MobileSalesSystem
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
        }

    }
}
