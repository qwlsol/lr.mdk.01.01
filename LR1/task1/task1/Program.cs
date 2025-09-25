using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //вариант 5

            Console.Write("Введите размер массива N: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{i + 1}-ое число: ");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            int eNumb = 0;//четные
            int oNumb = 0;//нечетные

            foreach (var num in a)
            {
                if (num % 2 == 0)
                    eNumb++;
                else
                    oNumb++;
            }
            Console.WriteLine($"Количество чётных: {eNumb}");
            Console.WriteLine($"Количество нечётных: {oNumb}");
        }
    }
}
