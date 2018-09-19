using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11th_Sep2018.AbstractClass
{
    class Staff:Employee
    {
        public string Department;
        public override string _Name { get { return "shubs staff"; } }
        public void Display()
        {
            Console.WriteLine("NAme : "+_Name + " base class name " + this.GetType().BaseType.BaseType.Name);
        }
        public override float GetSalary()
        {
            return Salary;
        }
       
    }
}
