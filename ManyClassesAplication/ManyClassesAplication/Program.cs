using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManyClassesAplication
{
    internal class Program
    {
        static void Main()
        {
            Warehouse warehouse = new Warehouse();
            warehouse.SetId(1);
            warehouse.SetLocation("Торжок, ул Студенческая 3");

            Product car1 = new Product();
            car1.SetName("МерседесБендс");
            car1.SetPrice(1200000);
            Product car2 = new Product();
            car2.SetName("Уазик");
            car2.SetPrice(10000000);

            warehouse.SetProductCount(car1, 2);
            warehouse.SetProductCount(car2, 5);

            Console.WriteLine($"Уникальный код склада: {warehouse.GetId()}. Адрес склада: {warehouse.GetLocation()}");
            Console.WriteLine("Информация о товарах на складе");
            warehouse.PrintAllProduct();
            Console.WriteLine();
            warehouse.PrintTotalMoney();
            Console.WriteLine();

            Console.WriteLine("ОТЧЕТ");
            Report dailyReport = new Report();
            
            StructProduct sampleRow = new StructProduct();
            sampleRow.Name = "Ручка";
            sampleRow.Price = 50;
            sampleRow.Quantity = 7;

            string formattedRow = Report.ConvertRowToString(sampleRow);
            Console.WriteLine($"{formattedRow}");
        }
    }
}
