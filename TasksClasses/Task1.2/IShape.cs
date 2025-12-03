using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1._2
{
    interface IShape
    {
        void Accept(IVisitor visitor);
    }
}
