using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1._1
{
    class HourlySalaryEmployee : Employee
    {
        private double hourRate_;
        private double hours_;
        private double overtimeHours_;

        public void SetHourRate(double hourRate)
        {
            hourRate_ = hourRate;
        }
        public double GetHourRate() 
        {
            return hourRate_;        
        }
        public void SetHours(double hours) 
        {
            hours_ = hours;
        }
        public double GetHours()
        {
            return hours_;
        }
        public void SetOvertimeHours(double overtimeHours)
        {
            overtimeHours_ = overtimeHours;
        }
        public double GetOvertimeHours()
        { 
            return overtimeHours_; 
        }
        public override double CalculateSalary()
        {
            return (hours_ * hourRate_) + (overtimeHours_ * hourRate_ * 1.5 );
        }
    }
}
