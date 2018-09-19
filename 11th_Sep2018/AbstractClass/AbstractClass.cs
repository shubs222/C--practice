using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11th_Sep2018.AbstractClass
{
    class AbstractClass
    {
        public static void Main
            (string[] args)
        {
            Console.WriteLine("\t\t\t\t\t\tAbstract class Practice");
            SalesMan Sm1 = new SalesMan();
            
            Sm1.Salary = 100;
            Sm1.Commn = 100;
            Console.WriteLine("\n\nAbstarct Mathod \nSales man slary+conmm: " + Sm1.GetSalary());
            Sm1.Display();


            Manager M1 = new Manager();
            M1.Salary = 200;
            M1.Stock = 10;
          
            Console.WriteLine("\n\nAbstarct Mathod \n\nManager slary : "+M1.GetSalary());
            
            Console.WriteLine("name is : "+ M1.GetData("shubham torvi"));
            M1.GetSalaryByVirtual();
            //M1.Display();


            Staff St1 = new Staff();
            St1.Salary = 20;
            Console.WriteLine("\n\nAbstarct Mathod \n\nSalary  of tha staff is : " + St1.GetSalary());
            St1.Display();

            Console.ReadKey();
            //Staff s = new Staff();
            
        }
    }
}
