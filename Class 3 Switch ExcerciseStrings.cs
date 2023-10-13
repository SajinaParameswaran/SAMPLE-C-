using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction_Day_1_20_09_2023
{
    internal class Class_3_Switch_Excercise
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter a character");
            string mystring = Console.ReadLine();
            Char Vowels = Convert.ToChar(mystring);
            Console.WriteLine("The charecter is:"+Vowels);

            switch(Vowels) 
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                Console.WriteLine("it is a vowel");
                break;
                default : Console.WriteLine("It is not a vowel");
                break;
            
             }

        }
    }
}
