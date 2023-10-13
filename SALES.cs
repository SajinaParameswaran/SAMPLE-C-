using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction_Day_1_20_09_2023
{
    internal class SALES : Class_HEVELS
    {
        
        public static void customerdetails()
        {
            string Customername;

            //Customer name
            Console.WriteLine("Please enter the customer name");
            Customername = Console.ReadLine();
            Console.WriteLine("CustomerName " +Customername);

         }

        public override void salesdetails(string loc) 

         { 
           switch (loc)

                {
                 case "trivandrum": 
                 int Price = 1000000000;
                 Console.WriteLine("Price is" + Price);
                  break;

                 case "Palakkad":
                 Price = 50000000;
                 Console.WriteLine("Price is" + Price);
                 break;

                 default:
                 Console.WriteLine("Apologies, We dont have sales here");
                 break;
        }

        
        
        
        
        
        
        
          }



    }
}
