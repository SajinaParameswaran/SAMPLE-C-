using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction_Day_1_20_09_2023
{
    internal class Single_Array_Inputfrmuser
    {
        public static void Main()
        {
            int n;
            Console.WriteLine("Please enter the array length");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The array length is" + n);
            int[] input = new int[n];

            int[] marks = { 20, 10, 30, 40, 50 };
            string[] Names = { "Sajina T", "Meenu Sunil", "Meenu Jose", "Sreedevi R" };
            Array.Sort(Names);
            Array.Sort(marks);

            Console.WriteLine("Please enter the input");

            for (int i=0;i<input.Length;i++)
            {
                input[i]= Convert.ToInt32(Console.ReadLine());
                //Console.WriteLine(input[i]);
             }

            Array.Sort(input);

            for (int l = 0; l < input.Length; l++)
            {
                Console.WriteLine(input[l]);
            }


            for (int j=0;j<Names.Length;j++)
            {
                Console.WriteLine(Names[j]);
            }

            for (int k = 0; k < marks.Length; k++)
            {
                Console.WriteLine(marks[k]);
            }

            Array.Reverse(marks);
            for (int k = 0; k < marks.Length; k++)
            {
                Console.WriteLine(marks[k]);
            }

            int length = marks.Length;
            Console.WriteLine("The length of array is " +length);
            Console.WriteLine("The maximum marks is" + marks.Max());
            Console.WriteLine("The minimum marks is" + marks.Min());
            Console.WriteLine("The sum of marks is" + marks.Sum());
             
         }

    }
}
