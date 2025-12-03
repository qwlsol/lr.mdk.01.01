using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1._1
{
    public class FreelancerEmployee : Employee
    {
        private double projectPayament_;
        private int projectCount_;
        private double taxRate_ = 0.13; //налоговая ставка ндфл составляет 13%

        public void SetProjectPayament(double projectPayament)
        {
            projectPayament_ = projectPayament;
        }
        public double GetProjectPayament()
        {
            return projectPayament_;
        }
        public void SetProjectCount(int projectCount) 
        {
            projectCount_ = projectCount;
        }
        public int GetProjectCount() 
        {
            return projectCount_ ;
        }
        public void SetTaxRate(double taxRate) 
        {
            taxRate_ = taxRate;
        }
        public double GetTaxRate()
        {
            return taxRate_;
        }
        public override double CalculateSalary()
        {
            double total = projectPayament_ * projectCount_;
            double tax = total * taxRate_;
            return total - tax;
        }
    }
}
