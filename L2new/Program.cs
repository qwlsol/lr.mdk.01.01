using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2new
{
    internal class Program
    {
        static void AddApplicant(Dictionary<string, List<Applicant>> applicants, string name, string specialty, int[] grades)
        {
            Applicant newApplicant = new Applicant();
            newApplicant.fullName = name;
            newApplicant.specialty = specialty;
            newApplicant.grades = grades;

            if (!applicants.ContainsKey(specialty))
            {
                applicants[specialty] = new List<Applicant>();
            }
            applicants[specialty].Add(newApplicant);
        }
        static void Main(string[] args)
        {

        }
    }
}
