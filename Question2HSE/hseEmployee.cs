using System;

namespace Question2HSE
{
    public class HseEmployee
    {
        public double EmpSalary;
        public int EmpYrsService;
        public string EmpName { get; set; }
        public int EmpNumber { get; set; }
        public string EmpType { get; set; }

        public HseEmployee(String name, int number, string type, int service, double salary)
        {
            EmpName = name;
            EmpNumber = number;
            EmpType = type;
            EmpYrsService = service;
            EmpSalary = salary;
        }

        public override string ToString()
        {
            return "Name: " + EmpName + "   Number: " + EmpNumber + "Type: " + EmpType + "years of service: " +
                   EmpYrsService + "salary: " + EmpSalary;
        }
    }

    public class Doctor : HseEmployee
    {
        public double DocSalary;
        public int DocYrsService;

        public string DocName { get; set; }
        
        public int DocNumber { get; set; }

        public string DocType { get; set; }

        public Doctor(String name, int number, string type, int service, double salary)
        {
            DocName = name;
            DocNumber = number;
            DocType = type;
            DocYrsService = service;
            DocSalary = salary;
        }


    }

    public struct RandomEmployees
    {
        public string EmpName; 
        public int Empno;
        public String Emptype;
        public int EmpYrsService;
        public double EmpSalary;

        public RandomEmployees(string name, int number, string type, int service, double salary)
        {
            EmpName = name;
            Empno = number;
            Emptype = type;
            EmpYrsService = service;
            EmpSalary = salary;
        }

    }
}

