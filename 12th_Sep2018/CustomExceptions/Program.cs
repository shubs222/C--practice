using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _12th_Sep2018.ExceptionHandling;
namespace _12th_Sep2018.CustomExceptions
{
    class Program
    {
        public static void Main(string[] args)
        {
            
            SalesMan sm1 = new SalesMan();
            sm1.Salary = 100;
            sm1.Bonus = 10;
            try
            {
                Console.WriteLine("Salary: "+sm1.GetSalary());
                sm1.GetBounus();
            }
            catch (EmployeeException e1)
            {
                Console.WriteLine("Error:  "+e1.Message);
            }
            Console.ReadKey();
        }
    }
    class Emp
    {

    }
}
