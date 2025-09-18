using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test.aray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] aray = new string[3];
            aray[0] = "A";
            aray[1] = "B";
            aray[2] = "C";

            aray[1] = "не А";

            Console.WriteLine(aray[0]);
            Console.WriteLine(aray[1]);
            Console.WriteLine(aray[2]);

            string[] aray2 = new string[3];
            aray2[0] = aray[2];
            aray2[1] = aray[1];
            aray2[2] = aray[0];

            Console.WriteLine(aray2[0]);
            Console.WriteLine(aray2[1]);
            Console.WriteLine(aray2[2]);

            int[] a = new int[10000];
            for (int i = 0; i < 10000; i++)
            { 
                a[i] = (i + 1)*2;
            }
                Console.Write("[");

            for (int i = 0; i < a.Length - 1; i++)
            {
                Console.Write($"{a[i]},");    
            }
            Console.Write(a.Length*2);
            { 
            Console.Write("]");
            
               
            }
               
        }
    }
}
