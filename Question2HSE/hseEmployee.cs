using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question2HSE
{
    class hseEmployee
    {
        public String empName { get; set; }
        public int empNumber {get; set;}
        public string empType { get; set; }
        public int empYrsService;
        public double empSalary;

        public hseEmployee( )
        {
            empName = "Becca";
            empNumber = 100;
            empType = "Doctor";
            empYrsService = 20009328;
            empSalary = 20000;
        }

    }
}
