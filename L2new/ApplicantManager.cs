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
        public void AddApplicant(string name, string specialty, int[] grades)
        {
            Applicant person = new Applicant();
            person.fullName = name;
            person.specialty = specialty;
            person.grades = grades;

            if (!applicants.ContainsKey(specialty))
            {
                applicants[specialty] = new List<Applicant>();
            }

            applicants[specialty].Add(person);
        }
        public void SortApplicantsBySpecialty(string specialty)
        {
            if (applicants.ContainsKey(specialty))
            {
                List<Applicant> list = applicants[specialty];

                for (int i = 0; i < list.Count - 1; i++)
                {
                    for (int j = i + 1; j < list.Count; j++)
                    {
                        double avg1 = calculator.CalculateAverage(list[i].grades);
                        double avg2 = calculator.CalculateAverage(list[j].grades);

                        if (avg1 < avg2)
                        {
                            Applicant temp = list[i];
                            list[i] = list[j];
                            list[j] = temp;
                        }
                    }
                }
            }
        }
    } 
}
