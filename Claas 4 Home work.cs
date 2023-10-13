using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction_Day_1_20_09_2023
{
    internal class Claas_4_Home_work
    {
        public static void Main(string[] args)
        {
            Console.Write("Please enter a string");
            String Mystring = Console.ReadLine();
            Console.WriteLine("The string entered is " + Mystring);
            int stringlength = Mystring.Length;
            Console.WriteLine("The length of my string is " + stringlength);

            for (int i = stringlength-1; i >= 0; i--)
            {
                Console.WriteLine(Mystring[i]);

                    }




        }



    }
}

