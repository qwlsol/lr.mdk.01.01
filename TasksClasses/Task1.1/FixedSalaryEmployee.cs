using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1._1
{
    public class FixedSalaryEmployee : Employee
    {
        private double monthySalary;

        public void SetMonthySalary(double salary)
        { monthySalary = salary;}
        public double GetMonthySalary()
        { return monthySalary; }

        public override double CalculateSalary()
        {
            return monthySalary;
        }
    }
}
