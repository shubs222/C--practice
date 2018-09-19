using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticKeyword
{
    static class InterestRate
    {
        static float interestRate=7.3f;
       
        public static void display()
        {
            Console.WriteLine("Static class: "+interestRate);
        }
    }
    class StaticConstructor
    {
        static string val=null;
        static StaticConstructor()
        {
            Console.WriteLine("enter value: ");
            val = Console.ReadLine();
            Display();


        }
        public static void Display()
        {
            Console.WriteLine("value is: "+ val);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            StaticConstructor s = new StaticConstructor();
           
            InterestRate.display();
            Console.ReadKey();
        }
    }
}
