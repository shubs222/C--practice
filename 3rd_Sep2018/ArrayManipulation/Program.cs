using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayManipulation
{
    class Program
    {
        int[] intarr = new int[5];
        //public  void GetData()
        //{
        //    Console.WriteLine("Enter size of integer array");
        //    n = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("integer array contains " + n + "number of elements");
        //}
       
        public void SetDataa()
        {
            Console.WriteLine("Enter " + 5 + " number of elements in integer array");
            for (int i = 0; i<=4; i++)
            {
                intarr[i] = Convert.ToInt32((Console.ReadLine()));
            }
            Console.WriteLine("Array Data Is :");
            for (int i = 0; i <= 4; i++)
            {
                Console.WriteLine("a ["+i+"] is " +intarr[i]);
            }
        }
       
           
      
        static void Main(string[] args)
        {
            Program pg = new Program();
            //pg.GetData();
            pg.SetDataa();
            Console.ReadKey();
            
        }
    }
}
