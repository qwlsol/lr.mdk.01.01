using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2new
{
    public class DisplayManager
    {
        private GradeCalculator calculator;

        public DisplayManager()
        {
            calculator = new GradeCalculator();
        }
        public void ShowApplicants(List<Applicant> applicants, string specialty)
        {
            Console.WriteLine($"Абитуриенты специальности - {specialty}:");

            for (int i = 0; i < applicants.Count; i++)
            {
                double avg = calculator.CalculateAverage(applicants[i].grades);
                Console.WriteLine($"{i + 1}. {applicants[i].fullName} - средний балл: {avg:F2}");
            }
        }
        public void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }

    }
}

