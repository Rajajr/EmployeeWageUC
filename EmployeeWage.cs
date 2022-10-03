using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageCompte1958Batch
{
      public class EmployeWage
        {
            /// <summary>
            /// Define Entry Point Of Application
            /// </summary>
            /// <param name="args"></param>

            public string COMPANY;
            public int EMP_RATE_PER_HR, MAX_OF_WORKING_DAYS, MAX_WORKING_HRS;

            public EmployeWage()
            {

            }

             public EmployeWage(string COMPANY, int EMP_RATE_PER_HR, int MAX_OF_WORKING_DAYS, int MAX_WORKING_HRS)
            {
                this.COMPANY = COMPANY;
                this.MAX_OF_WORKING_DAYS = MAX_OF_WORKING_DAYS;
                this.MAX_WORKING_HRS = MAX_WORKING_HRS;
                this.EMP_RATE_PER_HR= EMP_RATE_PER_HR;
            }
            public void CalculateEmpWage()
            {
                const int Full_TIME = 1;
                const int PART_TIME = 2;
                int empHrs = 0, empWage = 0, totalEmpWage = 0, day = 1, totalHrs = 0;
                Random random= new Random();

                while (day<= MAX_OF_WORKING_DAYS && totalHrs<=MAX_WORKING_HRS)
                {
                    int empCheck = random.Next(0, 3);

                    switch (empCheck)
                    {
                        case Full_TIME:
                            empHrs = 8;
                            //Console.WriteLine("FullTime Employee is Present");
                            break;

                        case PART_TIME:
                            empHrs = 4;
                            //Console.WriteLine("PartTime Employee is Present");
                            break;

                        default:
                            empHrs = 0;
                            //Console.WriteLine("Employee is Absent");
                            break;
                    }

                    empWage = empHrs * EMP_RATE_PER_HR;
                    //Console.WriteLine("Company Name: {0}",COMPANY);
                    //Console.WriteLine("Employee Wage Per Day is {0} and Hrs: {0} is: {2}", day, totalHrs, empWage);
                    totalEmpWage += empWage;
                    day++;
                    totalHrs += empHrs;
                }

                Console.WriteLine("\nCompany Name: {0}", COMPANY);
                Console.WriteLine("\nTotal Employee Wage of the month is: " + totalEmpWage);
            }
            

        }
    
}