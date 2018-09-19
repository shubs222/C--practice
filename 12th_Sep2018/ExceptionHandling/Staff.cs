using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12th_Sep2018.ExceptionHandling
{
    class Staff:Employee
    {
        //public string dept;
        bool invalidinput = true;
        public override void GetData()
        {
            while (invalidinput == true)
            {
                invalidinput = false;
                try
                {
                    Name = "shubham";
                    //Salary = sal;
                    Console.WriteLine(" name: " + Name);
                    
                    Console.WriteLine("Salary: ");
                    Salary = int.Parse(Console.ReadLine());
                    Console.WriteLine("Salary: "+ Salary);
                    //int a = 10, b = 0;
                    //int result = a / b;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("invalid input for salarty ");
                    //Exception ex1 = new Exception("asd", ex);
                    WriteToLog.WriteToLogs(ex);
                    invalidinput = true;
                }
                finally { Console.WriteLine("This is finally block of staff"); }
                
            }
            
           
        }
        //public void GetDataStaff()
        //{
        //    try
        //    {
        //        GetData();
        //        Console.WriteLine("this is try block of getDatastaff method");
        //    }
        //    catch (Exception e2)
        //    {
        //        Console.WriteLine("this is catch of getdatastaff method");
        //    }
        //    finally
        //    {
        //        Console.WriteLine("getdatastaff finally");
        //    }
        //}
    }
}
