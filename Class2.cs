using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction_Day_1_20_09_2023
{
    class Class2
    {
        public static void Main(string[] args)
        {

            /*         
                     //+ Operator
                     int int1 = 4, int2 = 5;
                     String Firstname="Sajina", Lastname = ".T";
                     Console.WriteLine(int1 + int2);
                     Console.WriteLine(Firstname + Lastname);

                     //Data types
                     int intdt = 5; //4 bytes 10 digits
                     Console.WriteLine("My integer is " + intdt);

                     long longdt = 1234567891234567891;//8bytes 19 digits
                     Console.WriteLine("My long integer value is " + longdt);

                     float floatdt = 12.1234567f;//4bytes 6 to 7 decimal digits
                     Console.WriteLine("My float integer value is " + floatdt);

                     double doubledt = 12.1234567812345678d;
                     Console.WriteLine("My double value is " + doubledt);

                     decimal decimaldt = 1.23m;
                     Console.WriteLine("My decimal value is " + decimaldt);

                     int bool1 = 8, bool2 = 9;
                     Console.WriteLine(bool1 == bool2);

                     //Implicit Casting
                                 long b = a;
                     Console.WriteLine(b);

                     //Explicit Casting - Have to do manually
                     int c = 1;
                     Console.WriteLine(c);
                     long d = 344444445678;
                     c = (int)d;
                     Console.WriteLine(c);

                     long z = 1234567891011;
                     int x = (int)z;
                     Console.WriteLine(x);
         

            //Operators - Arithmetic (+,-,*,%,++,--)
            //+,-,*,%
            int arith1 = 8, arith2 = 4;
            Console.WriteLine("Addition"+ arith1+arith2);
            Console.WriteLine(arith1 - arith2); //TBC
            Console.WriteLine("Multiplication" + arith2 * arith1);
            Console.WriteLine("Modulo to get reminder" + arith1 % arith2);
            // ++
            int a = 2, aa = 4;
            int op, op1;
            op =++a;
            Console.WriteLine(op);
            Console.WriteLine(a);

            op1=aa++;
            Console.WriteLine(op1);
            Console.WriteLine(aa);

            int a1 = 2, aa1 = 4;
            int lop, lop1;
            lop = --a1;
            Console.WriteLine(lop);
            Console.WriteLine(a1);

            lop1 = aa1--;
            Console.WriteLine(lop1);
            Console.WriteLine(aa1);
*/
            //Operators - Logical operatores - can be only used with boolean value && || !



            //Operators - Comparison (== != < ><= >=)



            //Operators - Assignment


            //Stirng functions
            String str1,str2;
            Console.WriteLine("Please enter the string : ");
            str1 = Console.ReadLine();
            Console.WriteLine("Please enter the string : ");
            str2 = Console.ReadLine();

            Console.WriteLine("The length of string is" + str1.Length);
            //Console.WriteLine(str1.ToUpper); //TBC




        }

    }
}
