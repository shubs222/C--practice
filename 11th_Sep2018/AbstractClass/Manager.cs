using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11th_Sep2018.AbstractClass
{
    class Manager:Employee, IEmployee
    {
        public string HodOfDept;
        public  float Stock;
        public override string _Name { get => "shubham Manager"; }
        public void Display()
        {
            Console.WriteLine("Name : " + _Name);
        }
        public override float GetSalary()
        {
            return Salary*Stock;   
        }
        public  string GetData(string Name)
        {
            HodOfDept = Name;
           
            return HodOfDept;
        }
    }
}
