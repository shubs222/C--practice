using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringManipulation
{
    class Program
    {
        string str1, str2;
        void GetData()
        {
            Console.WriteLine("Enter 1st string ");
            str1 = Console.ReadLine();
            Console.WriteLine("Enter 2nd string");
            str2 = Console.ReadLine();
        }
        void DisplayData()
        {
            Console.WriteLine("1st string :"+str1+" and 2nd string :"+str2);
        }
        void StringOpertions()
        {
            //length
            Console.WriteLine("\n\n\tString Operations \nLenght 1st string is: " + str1.Length + "\t Lenght of 2nd string is: " + str2.Length);

            //compare
            Console.WriteLine("\nComparing two string: " + string.Compare(str1, str2));

            //upper and lower case
            Console.WriteLine("\nConverting string 1 to upper case: " + str1.ToUpper() + "\tConverting String 2 into lower case: " + str2.ToLower());

            //Equals
            Console.WriteLine("\nChecking Equality of two string : "+string.Equals(str1,str2));

            //Compare Ordinals
            Console.WriteLine("\nCompare Ordinal: " + string.CompareOrdinal(str1, str2));

            //Format
            Console.WriteLine("\nFormat string : " + string.Format(str1, "12sh"));

            //white space check
            Console.WriteLine("\nCheck for white spaces : " + string.IsNullOrWhiteSpace(str1));

            //join
            Console.WriteLine("\nJoining two string " + string.Join("**", str1,str2));

            //Replace 
            Console.WriteLine("\nReplace charactetrs in string: " + str1.Replace("--", "std"));


            Console.WriteLine("\nSplit string");
            String[] arr = str1.Split(' ');
            for (int i = 0; i < arr.Length; i++)
                {
                Console.WriteLine(arr[i]);
                //Console.WriteLine(arr[i].Reverse());
                }
            /*Console.WriteLine("Reverse string 1st: ");
            char[] arr = str1.ToCharArray();
            Array.Reverse(arr);*/

            //index of
            Console.WriteLine("\n Index of :  " + str1.IndexOf('h'));
            //last index ,indexany

            //trim
            Console.WriteLine("\n Trim function: "+str1.TrimStart());
            Console.WriteLine("\n lenght of string after using trim function is: "+str1.Length);

            //hashcode

            Console.WriteLine("\n hashcode : " + str1.GetHashCode());

            //substring
            Console.WriteLine("\n substring of sring 1 : " + str1.Substring(3, 5));


        }
        static void Main(string[] args)
        {
            Program pg = new Program();
            //int opt=0;
            //Console.WriteLine("1.Dislay Two Strings\t2.Find out the lenght of two string\n3.Copy one String to another string" +
            //"\t4.Compare two strings\n5.Exit\n");
            //opt = Convert.ToInt32(Console.ReadLine());
            pg.GetData();
            pg.DisplayData();
            pg.StringOpertions();
            Console.ReadKey();
            
        }
    }
}
