using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11th_Sep2018.AbstractClass
{
    
    abstract class Employee
    {
        
        public abstract string _Name { get;  }
       
        public float Salary;
        //public override void Method()
        //{

        //}
        public virtual float GetSalaryByVirtual()
        {
            return Salary;
        }
        abstract public float GetSalary();

    }
}
