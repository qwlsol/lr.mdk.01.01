using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace function
{
    class ListStringsModule
    {
        static public List<string> StringsModule()
        {
            List<string> list = new List<string>();

            Console.Write("Введите количество строк: ");
            while (true)
            {
                string i = Console.ReadLine();
                list.Add(i);
                break;
            }
            return list;
        }
        static public List<int> Search(List<string> StringsModule, string text)
        {
            List<int> result = new List<int>();

            for (int i = 0; i < StringsModule.Count; i++)
            {

            }
            
            return result;
        }

        
    }
}