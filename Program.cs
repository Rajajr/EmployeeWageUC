using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageCompte1958Batch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //UC-2 Find Daily Wage Of Employee
            int empPresent = 1;
            int EMP_RATE_PER_HOUR = 40;

            //variables
            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();
            //Generate random number within range either 0 or 1
            int empcheck = random.Next(0, 2);
            Console.WriteLine("Random value:" + empcheck);

            if (empcheck==empPresent)
            {
                empHrs = 10;
            }
               
            else
            {
                empHrs = 0;
            }
            empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Employee Wage is:"+empWage);
            Console.ReadLine();
        }
    }
}
