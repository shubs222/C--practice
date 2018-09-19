using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11th_Sep2018.NewFolder1
{
    //class Supeerclass
    //{
    //    public int a=10;
    //    public virtual int A {
    //        get
    //        {
    //            return a;
    //        }
    //        set
    //        {
    //            a = value;
    //        }
    //    }
    //    public virtual void CD()
    //    {
    //        Console.WriteLine("super class cd method");
    //    }
    //}
    //class Subclass : Supeerclass
    //{
    //    public override int A
    //    {
    //        get
    //        {
    //            return a;
    //        }
    //        set
    //        {
    //            a = value;
    //        }
    //    }

    //    public override void CD()
    //    {
    //        Console.WriteLine("sub class cd method");
    //    }
    //    public void d()
    //    {

    //    }
    //}
    class PG
    {
        static void Main(string[] args)
        {
            //int sum=0;
            //for (int i = 1; i < 1000; i++)
            //{
            //    if (i % 3 == 0 || i % 5 == 0)
            //    {
            //        Console.WriteLine(i);
            //        sum = sum + i;
            //    }
            //}
            //Console.WriteLine("Sum"+sum);
            //Console.ReadKey();
            //for (int i = 0; i <= 5; i++)
            //{
            //    Console.WriteLine();
            //    for (int  j = 0; j <= 5; j++)
            //    {
            //        if (i == j||i+j==5)
            //        {
            //            Console.Write("*");
            //        }
            //        else
            //        {
            //            Console.Write(" ");
            //        }
            //    }

            //}

            int n = 10;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < n; j++)
                {
                    if (i == 0 || j == 0 || i == n - 1 || j == n - 1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
