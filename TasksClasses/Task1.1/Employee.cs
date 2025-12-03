using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1._1
{
    public abstract class Employee
    {
        private int id_;
        private string fullName_;
        private string email_;

        public void SetId(int id)
        {
            id_ = id;
        }
        public int GetId()
        {
            return id_;
        }
        public void SetFullName(string fullName) 
        {
            fullName_ = fullName;
        }
        public string GetFullName() 
        {
            return fullName_;
        }
        public void SetEmail(string email)
        {
            email_ = email;
        }
        public string GetEmail()
        {
            return email_;
        }

    }
}
