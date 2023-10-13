using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction_Day_1_20_09_2023
{
    internal class FileHandling
    {
        public static void Main(String[] args)
        {
            string path= @"C:\Users\sthandam\OneDrive - RM PLC\Evolution\AUTOMATION C#Selenium\Introduction Day 1 20-09-2023\FILE PATH\";
            FileStream fs=File.Create(path);

            //FileStream fs = File.Create(@"C:\Users\sthandam\OneDrive - RM PLC\Evolution\AUTOMATION C#Selenium\Introduction Day 1 20-09-2023\FILE PATH\Myfile.txt");

            if (File.Exists(path))
            {
                Console.WriteLine("File Available");
                //fs=File.Open(path, FileMode.Open);
            }

            else
            {
                Console.WriteLine("File not available");
            }

            File.WriteAllText(path, "Welcome to my file");
            File.AppendAllText(path, "My appended txt");
            Console.WriteLine(File.ReadAllText(path));
        }

           
    }
}
