using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Question2HSE
{
    class Program
    {
        static void Main(string[] args)
        {
            Program hseProgram = new Program();

            hseProgram.PrintDetails();
        }

        private void PrintDetails()
        {
            hseEmployee employee1 = new hseEmployee();

            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("The heck is yo name?");
            string name = Console.ReadLine();
            Console.WriteLine("Well to heck wit chu, " + name);
            Console.WriteLine("Thank you for choosing the HSE. Press enter to close...");
            Console.ReadLine();
        }
    }
}
