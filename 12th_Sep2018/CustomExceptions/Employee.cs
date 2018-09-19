using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _12th_Sep2018.ExceptionHandling;

namespace _12th_Sep2018.CustomExceptions
{
     class Employee
    {
        public string Name;
        public float Salary;
        public float Bonus;
        public virtual void GetBounus()
        {
            //Bonus = Bon;
            //if (Salary <= 0)
            //{
            //    throw new EmployeeException("invalid Salary");
            //}
            ////else
            //{
            //    if (Bonus > (Salary / 10))
            //    {
            //        throw new EmployeeException("Bonus is not valid: ");
            //    }
            //    else
            //    {
            //        Console.WriteLine(" Bonus is: " + Bonus+" Total Salary inculding bonus is: "+(Bonus+Salary)); 
            //    }
            //}
            throw new EmployeeException("Expetion");
        }
        public virtual float GetSalary()
        {
            return Salary;
        }
    }
}
