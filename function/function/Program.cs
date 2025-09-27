using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace function
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> name = ListStringsModule.StringsModule();
            Console.WriteLine("Последний элемент списка:" + name[name.Count-1]);
            Console.WriteLine("Размер списка: " + name.Count);


        }
    }
}
