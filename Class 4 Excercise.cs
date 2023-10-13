using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction_Day_1_20_09_2023
{
    internal class Class_4_Excercise
    {
        public static void Main(string[] args)
        {
            Console.Write("Please enter a string ");
            string Mystring= Console.ReadLine();
            Console.WriteLine("The string entered is " + Mystring);
            int len = Mystring.Length;
            Console.WriteLine("The string length is " + len);

            Console.WriteLine("Made change");

            for (int i=0; i<len;i++)

           {
              Console.WriteLine(Mystring[i]);
           }
        
       }
    }
}
