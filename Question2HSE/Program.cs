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
            HseEmployee employee1 = new HseEmployee();
            HseEmployee employee2 = new HseEmployee();
            HseEmployee doctor1 = new Doctor();

            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("Enter employee name : ");
            employee1.EmpName = Console.ReadLine();
            Console.WriteLine("Enter employee type : ");
            employee1.EmpType = Console.ReadLine();
            Console.WriteLine("Enter employee years of service :  ");
            employee1.EmpYrsService = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter employee salary :   ");
            employee1.EmpSalary = Double.Parse(Console.ReadLine());

            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("Enter employee name : " + employee1.EmpName);
            Console.WriteLine("Enter employee Number : " + employee1.EmpNumber);
            Console.WriteLine("Enter employee type : " + employee1.EmpType);
            Console.WriteLine("Enter employee years of service :  " + employee1.EmpYrsService);
            Console.WriteLine("Enter employee salary :   €" + employee1.EmpSalary);
            Console.WriteLine("Thank you for choosing the HSE. Press enter to close...");
            Console.ReadLine();

            Console.ReadLine();
        }


    }
}
