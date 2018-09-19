using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11th_Sep2018.AbstractClass
{
    class SalesMan:Employee
    {
        //public  string WorkingLocn;
        public float Commn;
        public override string _Name { get => "shubham sales"; }
        public void Display()
        {
            Console.WriteLine("NAme : " + _Name);
        }
        public override float GetSalary()
        {
            return Salary + Commn;
        }
    }
}
