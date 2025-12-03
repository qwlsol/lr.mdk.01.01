using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Task1._2
{
    public class Triangle : IShape
    {
        private double sideA_;
        private double sideB_;
        private double sideC_;
        public Triangle(double sideA, double sideB, double sideC)
        {
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)

            // Проверка на существование треугольника
            if (sideA + sideB <= sideC || sideA + sideC <= sideB || sideB + sideC <= sideA)

            sideA_ = sideA;
            sideB_ = sideB;
            sideC_ = sideC;
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit();
        }
    }
}
