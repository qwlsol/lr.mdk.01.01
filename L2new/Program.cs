using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2new
{
    internal class Program
    {
        static void Main()
        {
            ApplicantManager applicantManager = new ApplicantManager();
            DisplayManager displayManager = new DisplayManager();
            TestDataCreator dataCreator = new TestDataCreator();

            dataCreator.CreateTestData(applicantManager);

            while (true)
            {
                displayManager.ShowMessage("Введите специальность:");
                string input = Console.ReadLine();

                applicantManager.SortApplicantsBySpecialty(input);

                List<Applicant> applicants = applicantManager.GetApplicantsBySpecialty(input);

                if (applicants.Count > 0)
                {
                    displayManager.ShowApplicants(applicants, input);
                }
                else
                {
                    displayManager.ShowMessage("Такой специальности не существует");
                }

            }
        }
    }
}