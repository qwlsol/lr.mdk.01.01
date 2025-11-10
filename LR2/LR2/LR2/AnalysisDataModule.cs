using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR2
{
    internal class AnalysisDataModule
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
}
