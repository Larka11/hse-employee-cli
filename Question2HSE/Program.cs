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
            hseProgram.PrintRandomDetails();
            hseProgram.PrintDocDetails();
        }

        private void PrintDetails()
        {
            HseEmployee employee1 = new HseEmployee("",100, "", 0, 00.00);
            HseEmployee employee2 = new HseEmployee(name: "Tony McCarron", 200,"Porter", 4,34576.25);

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
 

            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("Enter employee name : " + employee2.EmpName);
            Console.WriteLine("Enter employee Number : " + employee2.EmpNumber);
            Console.WriteLine("Enter employee type : " + employee2.EmpType);
            Console.WriteLine("Enter employee years of service :  " + employee2.EmpYrsService);
            Console.WriteLine("Enter employee salary :   €" + employee2.EmpSalary);


        }

        private void PrintDocDetails()
        {
            HseEmployee doctor1 = new Doctor(name: "", number: 000, type: "", service: 0, 0.0);

            string Prescribe = "Doctor";
            if (doctor1.EmpType == Prescribe)
            {
                string hiDoc = "I can PRESCRIBE for patients!!! ";

            }
            else { string hiDoc = "I cannot PRESCRIBE for patients!!!"; }
            return hiDoc;

            Console.WriteLine(doctor1.ToString());
            Console.WriteLine(hiDoc);

            Console.ReadLine();
        }
        private void PrintRandomDetails()
        {
            RandomEmployees randomEmployees1 = new RandomEmployees("Betty", 100, "Doctor", 3, 155_000.00);
            RandomEmployees randomEmployees2 = new RandomEmployees("Bob", 200, "Doctor", 12, 86_000.00);
            RandomEmployees randomEmployees3 = new RandomEmployees("Louis", 300, "Standard", 1, 30_000.00);
            RandomEmployees randomEmployees4 = new RandomEmployees("Zoe", 400, "Doctor", 8, 262_000.00);
            RandomEmployees randomEmployees5 = new RandomEmployees("Joe", 500, "Doctor", 2, 70000.00);
            RandomEmployees randomEmployees6 = new RandomEmployees("Abby", 600, "Porter", 7, 152_000.00);
            RandomEmployees randomEmployees7 = new RandomEmployees("Cara", 700, "Standard", 4, 25_000.00);
            RandomEmployees randomEmployees8 = new RandomEmployees("Ellis", 800, "Porter", 9, 29_000.00);
            RandomEmployees randomEmployees9 = new RandomEmployees("Rob", 900, "Doctor", 11, 205_000.00);
            RandomEmployees randomEmployees10 = new RandomEmployees("Bea", 1000, "Standard", 5, 40_000.00);
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("Employee name: " + randomEmployees1.EmpName + " Employee number: " + randomEmployees1.Empno + " Employee type: " + randomEmployees1.Emptype + " Years in Service: " + randomEmployees1.EmpYrsService + " Salary: €" + randomEmployees1.EmpSalary);
            Console.WriteLine("Employee name: " + randomEmployees2.EmpName + " Employee number: " + randomEmployees2.Empno + " Employee type: " + randomEmployees2.Emptype + " Years in Service: " + randomEmployees2.EmpYrsService + " Salary: €" + randomEmployees2.EmpSalary);
            Console.WriteLine("Employee name: " + randomEmployees3.EmpName + " Employee number: " + randomEmployees3.Empno + " Employee type: " + randomEmployees3.Emptype + " Years in Service: " + randomEmployees3.EmpYrsService + " Salary: €" + randomEmployees3.EmpSalary);
            Console.WriteLine("Employee name: " + randomEmployees4.EmpName + " Employee number: " + randomEmployees4.Empno + " Employee type: " + randomEmployees4.Emptype + " Years in Service: " + randomEmployees4.EmpYrsService + " Salary: €" + randomEmployees4.EmpSalary);
            Console.WriteLine("Employee name: " + randomEmployees5.EmpName + " Employee number: " + randomEmployees5.Empno + " Employee type: " + randomEmployees5.Emptype + " Years in Service: " + randomEmployees5.EmpYrsService + " Salary: €" + randomEmployees5.EmpSalary);
            Console.WriteLine("Employee name: " + randomEmployees6.EmpName + " Employee number: " + randomEmployees6.Empno + " Employee type: " + randomEmployees6.Emptype + " Years in Service: " + randomEmployees6.EmpYrsService + " Salary: €" + randomEmployees6.EmpSalary);
            Console.WriteLine("Employee name: " + randomEmployees7.EmpName + " Employee number: " + randomEmployees7.Empno + " Employee type: " + randomEmployees7.Emptype + " Years in Service: " + randomEmployees7.EmpYrsService + " Salary: €" + randomEmployees7.EmpSalary);
            Console.WriteLine("Employee name: " + randomEmployees8.EmpName + " Employee number: " + randomEmployees8.Empno + " Employee type: " + randomEmployees8.Emptype + " Years in Service: " + randomEmployees8.EmpYrsService + " Salary: €" + randomEmployees8.EmpSalary);
            Console.WriteLine("Employee name: " + randomEmployees9.EmpName + " Employee number: " + randomEmployees9.Empno + " Employee type: " + randomEmployees9.Emptype + " Years in Service: " + randomEmployees9.EmpYrsService + " Salary: €" + randomEmployees9.EmpSalary);
            Console.WriteLine("Employee name: " + randomEmployees10.EmpName + " Employee number: " + randomEmployees10.Empno + " Employee type: " + randomEmployees10.Emptype + " Years in Service: " + randomEmployees10.EmpYrsService + " Salary: €" + randomEmployees10.EmpSalary);

            Console.WriteLine("Thank you for choosing the HSE. Press enter to close...");
            Console.ReadLine();

        }

    }
}
