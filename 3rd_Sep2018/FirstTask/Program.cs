using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTask
{
    class Program
    {
        int x = 0;

        public void details()
        {
            string s = String.Empty;
            Console.WriteLine("Enetr the String ");
            string value = Console.ReadLine();
            Console.WriteLine("Hello World!! welcome to C#");
            Console.WriteLine(sizeof(int) + "value of x is" + x);
            Console.WriteLine("Size of string" +2*value.Length);
            Console.WriteLine("check 1 :"+ System.Text.ASCIIEncoding.Unicode.GetByteCount(s));
            Console.WriteLine("check 2 :" + System.Text.ASCIIEncoding.ASCII.GetByteCount(value));
        }
        public void DataTypeTable()
        {
            Console.WriteLine("\tBuilt in Datatype in C#");
            var c = 10;
            Console.WriteLine(System.Runtime.InteropServices.Marshal.SizeOf(c));
            Console.WriteLine(System.Runtime.InteropServices.Marshal.SizeOf(c));
            Console.WriteLine("\tData Type\tSize\tMin value\t\tMax value");
            Console.WriteLine("\tint\t\t" + sizeof(int) + "\t" + int.MinValue + "\t\t" + int.MaxValue);
            Console.WriteLine("\tUnsigned int\t" + sizeof(uint) + "\t" + uint.MinValue + "\t\t\t" + uint.MaxValue);
            Console.WriteLine("\tshort\t\t" + sizeof(short) + "\t" + short.MinValue + "\t\t\t" + short.MaxValue);
            Console.WriteLine("\tushort\t\t" + sizeof(ushort) + "\t" + ushort.MinValue + "\t\t\t" + ushort.MaxValue);
            Console.WriteLine("\tfloat\t\t" + sizeof(float) + "\t" + float.MinValue + "\t\t" + float.MaxValue);
            Console.WriteLine("\tdouble\t\t" + sizeof(double) + "\t" + double.MinValue + "\t" + double.MaxValue);
            Console.WriteLine("\tChar\t\t" + sizeof(char) + "\t" + char.MinValue + "\t\t\t" + char.MaxValue);
            Console.WriteLine("\tboolean\t\t" + sizeof(Boolean));// + "\t" + Boolean.MinValue + "\t\t\t" + Boolean.MaxValue);
            
        }


        static void Main(string[] args)
        {
            Program pg = new Program();
            //Console.WriteLine(sizeof());
            //pg.details();
            pg.DataTypeTable();
            Console.ReadKey();
        }
    }
}
