using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction_Day_1_20_09_2023
{
    internal class Class3_Excercise
    {

        public static void Main(String[] args)
        {
            Console.WriteLine("Plese enter the number");
            string value = Console.ReadLine();
            int evenorodd = Convert.ToInt32(value);

            if (evenorodd % 2 == 0)
            { 
                  Console.WriteLine(evenorodd + " is an even number");
                 }
                 
              else

                {                
                   Console.WriteLine(evenorodd + " is an odd number");
                 }


}

    }
}
