using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR2
{
    internal class Program
    {
        public static object InputModule { get; private set; }

        static void Sale(List<string> phones, List<double> averages)
        {
            Console.WriteLine("Список телефонов от самых продаваемых к наименее популярным:");

            for (int i = 0; i < phones.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {phones[i]} - средние продажи: {averages[i]} шт./неделю");
            }
        }
        
        static void Main(string[] args, (object phones, object counts) value)
        {
            string[] brands = new string[] { "IPhone", "Samsung", "Huawei" };
            var (phones, counts) = InputModule.InputPhonesByBrand();

            string userQuery = InputModule.InputUserQuery();

            int indexBrand = SearchingModule.FindIndexBrand(userQuery, brands);
            if (indexBrand < 0)
            {
                Console.WriteLine("Указана несуществующая марка");
                return;
            }
        }
    }
}
