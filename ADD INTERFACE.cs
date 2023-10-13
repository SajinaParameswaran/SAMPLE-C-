using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction_Day_1_20_09_2023
{
    internal class ADD_INTERFACE: Interface1
    {
        int input1, input2, input3, input4;
       public static void Main(string[] args)

        {

            Console.WriteLine("Please enter the input ");
            ADD_INTERFACE obj1 = new ADD_INTERFACE();
            int add1 = obj1.add();
            Console.WriteLine(add1);
            int sub1 = obj1.subtract();
            Console.WriteLine(sub1);

        }

        ADD_INTERFACE()
        {
            input1 = Convert.ToInt32(Console.ReadLine());
            input2 = Convert.ToInt32(Console.ReadLine());
            input3 = Convert.ToInt32(Console.ReadLine());
            input4 = Convert.ToInt32(Console.ReadLine());
        }


        public int add( )

        {
           
            //input1 = Convert.ToInt32(Console.ReadLine());
            //input2 = Convert.ToInt32(Console.ReadLine());
            
            int addoutput = input1 + input2;
            int suboutput = input1 - input2;
            return(addoutput);

        }

        public int subtract()

        {
            
            //input3 = Convert.ToInt32(Console.ReadLine());
            //input4 = Convert.ToInt32(Console.ReadLine());
            
            int suboutput = input3 - input4;
            return (suboutput);



        }




    }
}
