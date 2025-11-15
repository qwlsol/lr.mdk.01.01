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
        static void SortApplicantsByAverage(List<Applicant> applicantList)
        {
            for (int i = 0; i < applicantList.Count - 1; i++)
            {
                for (int j = i + 1; j < applicantList.Count; j++)
                {
                    if (applicantList[i].GetAverageGrade() < applicantList[j].GetAverageGrade())
                    {
                        Applicant temp = applicantList[i];
                        applicantList[i] = applicantList[j];
                        applicantList[j] = temp;
                    }
                }
            }
        }
        static void ShowApplicantsBySpecialty(Dictionary<string, List<Applicant>> applicants, string specialty)
        {
            if (applicants.ContainsKey(specialty))
            {
                List<Applicant> specialtyApplicants = applicants[specialty];

                SortApplicantsByAverage(specialtyApplicants);

                Console.WriteLine("Абитуриенты специальности " + specialty + ":");

                for (int i = 0; i < specialtyApplicants.Count; i++)
                {
                    double average = specialtyApplicants[i].GetAverageGrade();
                    Console.WriteLine($"{i + 1}. {specialtyApplicants[i].fullName} - средний балл: {average:F2}");
                }
            }
            else
            {
                Console.WriteLine("Специальность " + specialty + " не найдена.");
            }
        }
        static Dictionary<string, List<Applicant>> CreateTestData()
        {
            Dictionary<string, List<Applicant>> applicants = new Dictionary<string, List<Applicant>>();

            AddApplicant(applicants, "Иванов Иван", "Программирование", new int[] { 5, 4, 5, 4 });
            AddApplicant(applicants, "Петров Петр", "Программирование", new int[] { 4, 4, 3, 5 });
            AddApplicant(applicants, "Сидорова Анна", "Программирование", new int[] { 5, 5, 5, 5 });

            AddApplicant(applicants, "Козлова Мария", "Дизайн", new int[] { 4, 5, 4, 4 });
            AddApplicant(applicants, "Николаев Алексей", "Дизайн", new int[] { 3, 4, 4, 3 });

            AddApplicant(applicants, "Федоров Дмитрий", "Экономика", new int[] { 5, 4, 5, 5 });

            return applicants;
        }
        static void Main()
        {
            Dictionary<string, List<Applicant>> applicants = CreateTestData();
            Console.WriteLine("Система учета абитуриентов");
            { 
                Console.WriteLine("Введите название специальности:");
                string input = Console.ReadLine();
                if (input.Length > 0)
                {
                    ShowApplicantsBySpecialty(applicants, input);
                }

            }
        }
    }
}
