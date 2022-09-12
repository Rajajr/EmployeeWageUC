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
            //UC-5 Calculating Wages for a Month assuming 20 Working Days in a month
            const int FULL_TIME = 1;
            const int PART_TIME = 2;
            const int EMP_RATE_PER_HR = 20;
            const int MAX_OF_WORKING_DAYS = 2;
            //Variables
            int empHrs = 0; 
            int empWage = 0;
            int totalEmpWage = 0;
            Random random = new Random();
            //Generate random number within range either 0 or 1
            for (int day = 1; day <= MAX_OF_WORKING_DAYS; day++)
            {

                int empcheck = random.Next(0, 3);
                Console.WriteLine("Random value:" + empcheck);

                switch (empcheck)
                {
                    case FULL_TIME:
                        empHrs = 8;
                        Console.WriteLine("FullTime Employee is Present");
                        break;

                    case PART_TIME:
                        empHrs = 4;
                        Console.WriteLine("PartTime Employee is Present");
                        break;

                    default:
                        Console.WriteLine("Employee is Absent");
                        break;
                }
            }
            empWage = empHrs * EMP_RATE_PER_HR;
            totalEmpWage += empWage;
            Console.WriteLine("Employee Wage Per Day:" + empWage);
            Console.WriteLine("\nTotal Empolyee Wage is : "+ totalEmpWage);

            Console.ReadLine();
        }
    }
}
