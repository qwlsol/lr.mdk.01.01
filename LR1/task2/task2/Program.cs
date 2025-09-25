using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///вариант 5

            Random rnd = new Random();
            int[] random = new int[3000];

            for (int i = 0; i < random.Length; i++)
            random[i] = rnd.Next(10, 10000);

            List<int> sum = new List<int>();

            for (int i = 0; i + 1 < random.Length; i += 2)
            {
                sum.Add(random[i] + random[i + 1]);
            }
        }
    }
}
