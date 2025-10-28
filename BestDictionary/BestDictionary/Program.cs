using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BestDictionary
{
    internal class Program
    {
        static void Main()
        {
            Dictionary<string, List<string>> dictionaryBest = new Dictionary<string, List<string>>();

            dictionaryBest.Add("журналы", new List<string> { "Мурзилка", "Ералаш", "Садовод" });
            dictionaryBest.Add("газеты", new List<string> { "Спорт", "Взгляд" });
            dictionaryBest.Add("книги", new List<string> { "Война и мир" });

            Console.WriteLine(string.Join(", ", dictionaryBest.Keys));
            // Console.WriteLine(string.Join(", ", dictionaryBest["журналы"]));
            
            Console.Write("Введите ключ: ");
            string userKey = Console.ReadLine();
        
            if (dictionaryBest.ContainsKey(userKey))
            {
                int count = dictionaryBest[userKey].Count;
                Console.WriteLine("Ключ " + userKey + " содержит количество элементов " + count);
                Console.WriteLine("Значение выбранного ключа: " + (string.Join(", ", dictionaryBest.Keys)));
            }
            else
            {
                Console.WriteLine("Ключ: " + userKey + " не найден!");
            }
        }
    }
}