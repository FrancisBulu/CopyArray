using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] ages = { 12, 5, 30, 40 };


            //int a = 10;
            //int b = a;
            //b++;

            //Console.WriteLine($"The value of a is {a} and the value of b is {b}"); // dit werkt voor de primitieve datatypes

            int[] ages = { 12, 5, 30, 40 };
            int[] copyages = new int[4];

            copyages = ages;
            ages[2] = 9999;
            Console.WriteLine("Array of ages");
            foreach (int age in ages)
            {
                Console.WriteLine(age);
            }
            Console.WriteLine("*********************************");
            Console.WriteLine("Array of copyages");

            foreach (int age in copyages)
            {
                Console.WriteLine(age);
            }
        }
    }
}
