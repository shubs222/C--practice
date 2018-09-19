using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int opt1, opt2;
            Console.WriteLine("\tOperators in C#");
            Console.WriteLine("\n1.Assignment operator(=)\n2.Arithmetic operators\n3.Relational Operators\n4.Logical operators\n5.Unary Operators" +
                "\n6.Ternary Operators\n7.Bitwise and Bit Shift Operators\n8.Compound Operators\n9.Exit\n Enter Your Choice");
            opt1=Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            switch (opt1)
                {
                    case 1:
                            Console.WriteLine("Assignment Operatior (=) is used to assign values eg. int x=10; value 10 is assigned to variable x");
                            break;
                    case 2:
                            Console.WriteLine("\n1.Addition (+)\n2.subtraction (-)\n3.multiplication (*)\n4.Division (/)\n5.Modulo (%)\n6.Exit\n Enter your choice");
                            opt2 = Convert.ToInt32(Console.ReadLine());
                             int d = 10, e = 20, f;
                             switch (opt2)
                             {
                                case 1:
                                        int a = 10,b=20,c;
                                        c = a + b;
                                        Console.WriteLine("Addition Operator is (+) eg c=a+b \n a=" + a + "\tb=" + "after using addtion oprator c=" + c);
                                        break;
                                case 2:
                                        f= d - e;
                                        Console.WriteLine("Addition Operator is (-) eg f=d-e \n a=" + d + "\te=" + "after using Subtraction oprator f=" + f);
                                        break;
                                case 3:
                                        f= d * e;
                                        Console.WriteLine("Multiplication Operator is (*) eg f=d*e \n a=" + d + "\te=" + "after using multiplication oprator f=" + f);
                                        break;
                                case 4:
                                        f = d - e;
                                        Console.WriteLine("Addition Operator is (-) eg f=d-e \n a=" + d + "\te=" + "after using Subtraction oprator f=" + f);
                                         break;
                                 case 5:
                                        f = d % e;
                                        Console.WriteLine("Modulo Operator is (%) it calculates remainder eg f=d%e \n a=" + d + "\te=" + "after using Modulo oprator f=" + f);
                                        break;
                            }
                            break;
                    case 3:
                            Console.WriteLine("\n1.Eqaulas to (+)\n2.Greater than (-)\n3.less than (<)\n4.Greater than eqauls to (>=)\n5.less than eqauls to (<=)\n6.Not equals\n7.exit\n Enter your choice");
                            opt2 = Convert.ToInt32(Console.ReadLine());
                           
                            switch (opt2)
                             {
                              case 1:
                                    bool result;
                                    int firstNumber = 10, secondNumber = 20;

                                    result = (firstNumber == secondNumber);
                                    Console.WriteLine("{0} == {1} returns {2}", firstNumber, secondNumber, result);

                                    result = (firstNumber > secondNumber);
                                    Console.WriteLine("{0} > {1} returns {2}", firstNumber, secondNumber, result);

                                    result = (firstNumber < secondNumber);
                                    Console.WriteLine("{0} < {1} returns {2}", firstNumber, secondNumber, result);

                                    result = (firstNumber >= secondNumber);
                                    Console.WriteLine("{0} >= {1} returns {2}", firstNumber, secondNumber, result);

                                    result = (firstNumber <= secondNumber);
                                    Console.WriteLine("{0} <= {1} returns {2}", firstNumber, secondNumber, result);

                                    result = (firstNumber != secondNumber);
                                    Console.WriteLine("{0} != {1} returns {2}", firstNumber, secondNumber, result);
                            break;
                            }
                             break;   
                    case 4:
                            bool result;
                             int firstNumber = 10, secondNumber = 20;

                            // OR operator
                            result = (firstNumber == secondNumber) || (firstNumber > 5);
                        Console.WriteLine(result);

                        // AND operator
                        result = (firstNumber == secondNumber) && (firstNumber > 5);
                        Console.WriteLine(result);

                        break;
                case 5:
                    int number = 10, result1;
                    bool flag = true;

                    result1 + = number;
                    Console.WriteLine("+number = " + result);

                    result = -number1;
                    Console.WriteLine("-number = " + result);

                    result = ++number1;
                    Console.WriteLine("++number = " + result);

                    result = --number1;
                    Console.WriteLine("--number = " + result);

                    Console.WriteLine("!flag = " + (!flag));
                    break;
                case 6:
            }


        }
    }
}
