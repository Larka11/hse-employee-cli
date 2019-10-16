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

        public string DocName { get; set; }
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

}

