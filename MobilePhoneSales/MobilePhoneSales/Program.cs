using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhoneSales
{
    internal class Program
    {
        static int AllSums(int[] price, int[] AmountSaled, DataTime[] Time)
        {
            Console.WriteLine("Выберите номер нужного переода ");

            for (int index = 0; index < Time.Length; index++)
            {
                Console.WriteLine($"Период {index} - " + Time[index]);
            }
            int InputUser = Convert.ToInt32(Console.ReadLine());

            return price[InputUser] * AmountSaled[InputUser];
        }
        static void FindBestWorseSels(string[] phones, int[] sales)
        {
            int maxSales = sales[0];
            int minSales = sales[0];
            string bestPhone = phones[0];
            string worstPhone = phones[0];

            for (int i = 1; i < sales.Length; i++)
            {
                if (sales[i] > maxSales)
                {
                    maxSales = sales[i];
                    bestPhone = phones[i];
                }
                if (sales[i] < minSales)
                {
                    minSales = sales[i];
                    worstPhone = phones[i];
                }
                Console.WriteLine($"Самый продаваемый: {bestPhone} - {maxSales} шт.");
                Console.WriteLine($"Наименее продаваемый: {worstPhone} - {minSales} шт.");
            }
        static void Main(string[] args)
        {
        }
    }
}
