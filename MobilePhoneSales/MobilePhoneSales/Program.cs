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
        static void Main(string[] args)
        {
        }
    }
}
