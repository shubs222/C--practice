using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _12th_Sep2018.ExceptionHandling;

namespace _12th_Sep2018.CustomExceptions
{
    class EmployeeException:Exception
    {
        //public override string Message => base.Message;
        public EmployeeException(string msg):base(msg)
        {
            //Message = msg;
            //Console.WriteLine("Invalid : "+message);
        }
    }
}
