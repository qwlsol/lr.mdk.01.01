using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR2
{
    internal class Program
    {
        static void Sale(List<string> phones, List<double> averages)
        {
            Console.WriteLine("Список телефонов от самых продаваемых к наименее популярным:");

            for (int i = 0; i < phones.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {phones[i]} - средние продажи: {averages[i]} шт./неделю");
            }
        }
        
        static void Main(string[] args)
        {

        }
    }
}
