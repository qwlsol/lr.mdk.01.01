using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class HomoSapiens
    {
        protected string name_;
        protected int age_;

        public HomoSapiens(string name, int age)
        {
            name_ = name;
            age_ = age;
        }
        public string GetName()
        { return name_; }

        public override string ToString()
        {
            return $"{GetName()}, {age_} лет " ;
        }
        
    }
}
