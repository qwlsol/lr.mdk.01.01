using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2new
{
    internal class Applicant
    {
        public string fullName;
        public string specialty;
        public int[] grades;

        public double GetAverageGrade()
        {
            if (grades == null || grades.Length == 0)
                return 0;
            double sum = 0;
            for (int i = 0; i < grades.Length; i++)
            {
                sum += grades[i];
            }
            return sum / grades.Length;

        }
    }
}
