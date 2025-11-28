using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2new
{
    internal class ApplicantManager
    {
        private Dictionary<string, List<Applicant>> applicants;
        private GradeCalculator calculator;

        public ApplicantManager()
        {
            applicants = new Dictionary<string, List<Applicant>>();
            calculator = new GradeCalculator();
        }
    }
}