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
        }
    }
}