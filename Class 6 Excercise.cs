using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction_Day_1_20_09_2023
{
    internal class Myexcercise
    {
        public static void add()
        {
            //addition without return type
            int a = 1, b = 2;
            Console.WriteLine(a + b);
        }

        //string add(string str11="hello",string str22 = "world")
        string add(string str11,string str22 )
        {
            return (str11 + str22);
        }
        public static int sub()
        {
            // substraction with return type
            int sub1 = 10, sub2 = 8;
            int subtract1 = sub1 - sub2;
            return (subtract1);
        }
        static int mul(int par11, int par22)
        {
            return (par11 * par22);

        }
        static string div(int par5, int par6, string str1 = "Hello")
        {
            int div = par5 / par6;
            Console.WriteLine(div);
            return (str1);
        }

        int modulo(int m11, int m22)
        {
            return (m11 % m22);
        }
        
        //int par1 , par2 ;
        //int par3,  par4;

        int m1 , m2;
        string str1, str2;

        Myexcercise()
            
        {
            //par1 = 6;
            // par2 = 8;
            //par3 = 8;
            //par4 = 2;

            m1 = 18;
            m2 = 6;
            str1 = "sajina";
            str2 = "T";
          }



        public static void Main(String[] args)
        {
            int par1 = 6, par2 = 8;
            int par3 = 8, par4 = 2;

           
           /* string str;
            int m1 = 18, m2 = 6;*/


            //creating an object for a nostatic class
            Myexcercise mod = new Myexcercise();

            //calling the method add without return type
            add();

            //calling the method sub with return type
            Console.WriteLine(sub());

            //calling the method multiply with parameters
            Console.WriteLine(mul(mod.par1, mod.par2));

            //calling the method division with value initialisation in parameter

            Console.WriteLine("division"+ div(mod.par3,mod.par4));
            
            Console.WriteLine(mod.modulo(mod.m1, mod.m2));

            //overloading
            Console.WriteLine(mod.add(mod.str1,mod.str2));
            
        }


    }
}
