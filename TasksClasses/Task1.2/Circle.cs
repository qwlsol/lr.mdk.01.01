using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1._2
{
    public class Circle : IShape
    {
        private double radius_;

        public Circle(double radius)
        {
            if (radius <= 0) 
            radius_ = radius;
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit();
        }
    }
}

