using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR2
{
    internal class SearchingModule
    {
        static public int FindIndexBrand(string userQuery, string[] brands)
        {
            for (int index = 0; index < brands.Length; ++index)
            {
                string valueBrand = brands[index].ToLower();
                if (valueBrand == userQuery.ToLower())
                {
                    return index;
                }
            }
            return -1;
        }

        static public (List<string>, List<double>) FindAllPhonesByBrand(int indexBrand,
                                                                     List<string>[] allPhones,
                                                                     List<double>[] counts)
        {
            List<string> phonesByBrand = new List<string>();
            List<double> salesByBrand = new List<double>();

            phonesByBrand = allPhones[indexBrand];
            salesByBrand = counts[indexBrand];

            return (phonesByBrand, salesByBrand);
        }
    }
}