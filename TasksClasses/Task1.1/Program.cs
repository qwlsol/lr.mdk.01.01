using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            FixedSalaryEmployee employee1 = new FixedSalaryEmployee();
            employee1.SetId(1);
            employee1.SetFullName("Антон Петров");
            employee1.SetEmail("antonPe@gmail.com");
            employee1.SetMonthySalary(50000);

            HourlySalaryEmployee employee2 = new HourlySalaryEmployee();
            employee2.SetId(2);
            employee2.SetFullName("Анна Рябинова");
            employee2.SetEmail("anyrabina@mail.ru");
            employee2.SetHourRate(650);
            employee2.SetHours(150);
            employee2.SetOvertimeHours(20);

            FreelancerEmployee employee3 = new FreelancerEmployee();
            employee3.SetId(3);
            employee3.SetFullName("Иван Игнатьев");
            employee3.SetEmail("ignivan@gmail.com");
            employee3.SetProjectPayament(2300);
            employee3.SetProjectCount(5);

            Console.WriteLine($"{employee1.GetFullName()} : {employee1.GetMonthySalary()} руб.");
            Console.WriteLine($"{employee2.GetFullName()} : {employee2.CalculateSalary()} руб.");
            Console.WriteLine($"{employee3.GetFullName()} : {employee3.CalculateSalary()} руб.");
        }
    }
}
