using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction_Day_1_20_09_2023
{
    internal class ClassFlat:SALES
    {
        public string location;

            ClassFlat()

        {
            //Location

            location = "Palakkad";

        }
          public static void Main()
        {
            ClassFlat cust = new ClassFlat();

            SALES.customerdetails();

            Console.WriteLine("Please enter the location");
            cust.location = Console.ReadLine();
            cust.salesdetails(cust.location);
            
            

        }

       

        
    }
}
