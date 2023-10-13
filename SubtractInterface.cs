using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction_Day_1_20_09_2023
{
    internal class SubtractInterface:Interface1

     {
        int input11, input22, input33;

        public static void Main(String[] args)
        {
            Console.WriteLine("Please enter 3 numbers to Add and Subtract");

            SubtractInterface obj2=new SubtractInterface();
            Console.WriteLine("The number added is" + obj2.add());
            Console.WriteLine("the number subtracted is " + obj2.subtract());
         }

        SubtractInterface()
        {
            input11 = Convert.ToInt32(Console.ReadLine());
            input22 = Convert.ToInt32(Console.ReadLine());
            input33 = Convert.ToInt32(Console.ReadLine());
        }



        public int add()
        { 
            int addedinput=input11+input22+input33;
             return (addedinput);         
        }

        public int subtract()
        {
            int subtractinput = input11 - input22 - input33;
            return (subtractinput);
            
        }

    }
}
