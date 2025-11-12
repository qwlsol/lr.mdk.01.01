using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhoneSales
{
    internal class Program
    {
        
        static int AllSums(int[] price, int[] AmountSaled, DateTime[] Time)
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
        }
        static void TopTwoProfitable(string[] phones, int[] sales, int[] prices, int[] costs)
        {
            int[] profits = new int[phones.Length];

            for (int i = 0; i < phones.Length; i++)
            {
                profits[i] = (prices[i] - costs[i]) * sales[i];
            }
            int firstMax = 0;
            int secondMax = 0;
            string firstPhone = "";
            string secondPhone = "";
            for (int i = 0; i < profits.Length; i++)
            {
                if (profits[i] > firstMax)
                {
                    secondMax = firstMax;
                    secondPhone = firstPhone;
                    firstMax = profits[i];
                    firstPhone = phones[i];
                }
                else if (profits[i] > secondMax)
                {
                    secondMax = profits[i];
                    secondPhone = phones[i];
                }
            }
            Console.WriteLine($"Топ 2 по прибыли:");
            Console.WriteLine($"Первый. {firstPhone} - {firstMax} руб.");
            Console.WriteLine($"Второй. {secondPhone} - {secondMax} руб.");
        }
        static void Main(string[] args)
        {
            string[] phoneModels = { "iPhone 17", "Samsung A24", "Huawei P60", "iPhone 8", "Xiaomi Redmi Note 10", "OnePlus 11" };
            int[] phonePrices = { 120000, 90000, 25000, 80000, 60000, 75000 };
            int[] phoneCosts = { 85000, 65000, 18000, 55000, 42000, 52000 };
            int[] totalSales = { 35, 42, 95, 28, 45, 32 };

            DateTime[] dates = {new DateTime(2025, 11, 1), new DateTime(2025, 11, 2), new DateTime(2025, 12, 3), new DateTime(2025, 11, 4),new DateTime(2025, 11, 5) };
            int[] dayPrices = { 120000, 90000, 25000, 80000, 60000 };
            int[] daySales = { 3, 4, 8, 2, 5 };
            
        }



    }
}