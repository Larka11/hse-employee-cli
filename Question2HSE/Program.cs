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

            Console.OutputEncoding = Encoding.GetEncoding(1252);

            Console.WriteLine("employee name: " + employee1.empName);
            Console.WriteLine("employee Number: " + employee1.empNumber);
            Console.WriteLine("employee Type: " + employee1.empType);
            Console.WriteLine("employee Yrs Service: " + employee1.empYrsService);
            Console.WriteLine("employee Salary:" + "€" + employee1.empSalary);

        }
    }
}
