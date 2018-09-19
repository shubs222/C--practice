using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorPractice
{
    class Acuvate
    {
        int id;
        string designation;
        int salary;
        //public Acuvate()
        //{
        //    //id = 1;
        //    //designation = "Software engineer trainee";
        //    //salary = 15000;
        //    Console.WriteLine("***default constructor***Enter your id ,Designation, and salary Respectively");
        //    id = Convert.ToInt32(Console.ReadLine());
        //    designation = Console.ReadLine();
        //    salary = Convert.ToInt32(Console.ReadLine());
        //}
        public Acuvate():this(2,"this in constructor parameter",25666)
        {
            Display();
        }
        public Acuvate(int a, string b, int c)
        {
            id = a;
            designation = b;
            salary = c;
            Console.WriteLine("Parameterised Cobnstructor");
            Display();
        }
        public Acuvate(string designation, int id, int salary)
        {
            this.designation = designation;
            this.id = id;
            this.salary = salary;
            Console.WriteLine("Using this");
            Display();
        }

        public void Display()
        {
            Console.WriteLine("Employee Id : " +id+"\tDesignation: "+ designation+"\tSalary: "+salary);
           
        }
    }

    class Program
    {
        
        static void Main(string[] args)
        {
            Acuvate acuvate = new Acuvate();
            acuvate.Display();
            Acuvate a = new Acuvate(2, "st", 25556);
            Acuvate b = new Acuvate("as", 2, 5446);
            Console.ReadKey();
        }
    }
}
