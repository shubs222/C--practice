using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12th_Sep2018.CustomExceptions
{
    class SalesMan:Employee
    {
        float cmm;
        public override float GetSalary()
        {
            //Console.WriteLine();
            if (Salary <= 0)
            {
                throw new EmployeeException("invalid Salary");
            }
            return Salary+cmm;
        }
        public override void GetBounus()
        {
            if (Bonus > (Salary / 10))
            {
                throw new EmployeeException("Bonus is not valid: ");
            }
            else
            {
                Console.WriteLine(" Bonus is: " + Bonus + " Total Salary inculding bonus is: " + (Bonus + Salary));
            }
        }
    }
}
