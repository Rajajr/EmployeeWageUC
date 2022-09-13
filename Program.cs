using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageCompte1958Batch
{
    public class Program
    {
        static void Main(string[] args)
        {
            //UC-6 Calculate Wages till a Condition of total working hours or max days os reached for a month
            const int FULL_TIME = 1;
            const int PART_TIME = 2;
            const int EMP_RATE_PER_HR = 20;
            const int MAX_OF_WORKING_DAYS = 20;
            const int MAX_WORKING_HRS = 100;
            //Variables
            int empHrs = 0,empWage = 0,totalEmpWage = 0,day = 1,totalHrs = 0;
            Random random = new Random();
            //Generate random number within range either 0 or 1
            while (day <= MAX_OF_WORKING_DAYS && totalHrs <= MAX_WORKING_HRS)
            {
                int empcheck = random.Next(0, 3);
                //Console.WriteLine("Random value:" + empcheck);

                switch (empcheck)
                {
                    case FULL_TIME:
                        empHrs = 8;
                        //Console.WriteLine("FullTime Employee is Present");
                        break;

                    case PART_TIME:
                        empHrs = 4;
                        //Console.WriteLine("PartTime Employee is Present");
                        break;

                    default:
                        //Console.WriteLine("Employee is Absent");
                        break;
                }

                empWage = empHrs * EMP_RATE_PER_HR;
                Console.WriteLine("Employee Wage Per Day{0} and Hrs: {0} is: {2}", day, totalHrs, empWage);
                totalEmpWage += empWage;
                day++;
                totalHrs += empHrs;
            }

          
          Console.WriteLine("Total Employe Wage is: " + totalEmpWage);
          Console.ReadLine();

           
        }

    }
    
}
