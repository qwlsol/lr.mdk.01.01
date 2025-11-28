using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2new
{
    internal class TestDataCreator
    {
        public void CreateTestData(ApplicantManager manager)
        {
            manager.AddApplicant("Иванов Иван", "Программирование", new int[] { 5, 4, 5, 4 });
            manager.AddApplicant("Петров Петр", "Программирование", new int[] { 4, 4, 3, 5 });
            manager.AddApplicant("Сидорова Анна", "Программирование", new int[] { 5, 5, 5, 5 });

            manager.AddApplicant("Козлова Мария", "Дизайн", new int[] { 4, 5, 4, 4 });
            manager.AddApplicant("Николаев Алексей", "Дизайн", new int[] { 3, 4, 4, 3 });
        }
    }
}
