using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction_Day_1_20_09_2023
{
    class Myclass1
    {
        public static void fun()
        {
            Console.WriteLine("this is my first static method");
        }
        public static void add()
        {
            Console.WriteLine(4 + 5);
        }
        public static int sub()
        {
            return (8 - 4);
        }
        public static int mul() 
        {
            return (2 * 2);
        }
        public static string addition(int x1, int y1,string s1) 
        {
            Console.WriteLine(x1 + y1);
            return (s1);
        }

        public static void Main(String[] args)
        {
            int x = 10, y = 10;
            string s = "hello";
            fun();
            add();
            int subtractedvalue= sub();
            Console.WriteLine(subtractedvalue);
            Console.WriteLine(mul());
            Console.WriteLine(addition(x,y,s));      




        }

    }
}
