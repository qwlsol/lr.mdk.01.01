using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1._2
{
    public class Rectangle : IShape
    { private double widtg_;
        private double height_;

        public Rectangle(double width, double height)
        {
            if (width <= 0 || height <= 0)
            widtg_ = width;
            height_ = height;
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}

