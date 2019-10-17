using System;

namespace Question2HSE
{
    public class HseEmployee
    {
        public double EmpSalary;
        public int EmpYrsService;

        public HseEmployee()
        {
            EmpName = "";
            EmpNumber = 100;
            EmpType = "";
            EmpYrsService = 2;
            EmpSalary = 20000.00;
        }

        public string EmpName { get; set; }
        public int EmpNumber { get; set; }
        public string EmpType { get; set; }
    }

    public class Doctor : HseEmployee
    {
        public double DocSalary;
        public int DocYrsService;
        private string _docName;

        public string DocName
        {
            get
            {
                String docName = _docName;
                return docName;
            }
            set => _docName = value ?? throw new ArgumentNullException(nameof(value));
        }

        public int DocNumber { get; set; }

        public string DocType { get; set; }

        public Doctor()
        {
            DocName = "";
            DocNumber = 100;
            DocType = "";
            DocYrsService = 2;
            DocSalary = 20000.00;
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

