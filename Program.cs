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
            //UC-3 Part time Employee & Wage
            int IS_PART_TIME = 1;
            int IS_FULL_TIME = 2;
            int EMP_RATE_PER_HOUR = 40;
            int empHrs = 0; int empWage = 0;
            Random random = new Random();
            //Generate random number within range either 0 or 1
            int empcheck = random.Next(0, 3);
            Console.WriteLine("Random value:" + empcheck);

            if (IS_FULL_TIME == empcheck)
            {
                empHrs = 10;
                Console.WriteLine("Full Time Employee is Present");
            }

            else if (IS_PART_TIME == empcheck)
            {
                empHrs = 4;
                Console.WriteLine("Part Time Employee is Present");
            }
            else
            {
                empHrs = 0;
                Console.WriteLine("Employe is Absent");
            }
            empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Employee Wage is:"+empWage);
            Console.ReadLine();
        }
    }
}
