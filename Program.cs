using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageCompte1958Batch
{
    public class Program
    {
        static void Main(string[] args)
        {
            // UC - 8 Compute Employe Wage For Multiple Companies
            CaluculatingEmployeeWages("Google",20,30,120);
            CaluculatingEmployeeWages("Microsoft", 20, 30,150 );
            CaluculatingEmployeeWages("Infosys", 20, 30, 120);
            Console.ReadLine();
        }
        public static void CaluculatingEmployeeWages(string COMPANY, int EMP_RATE_PER_HR, int MAX_OF_WORKING_DAYS,int MAX_WORKING_HRS)
        {
            
            const int FULL_TIME = 1;
            const int PART_TIME = 2;
            //const int EMP_RATE_PER_HR = 20;  
            //const int MAX_OF_WORKING_DAYS = 30;
            //const int MAX_WORKING_HRS = 100;

            //Variables
            int empHrs = 0,empWage = 0,totalEmpWage = 0,day = 1,totalHrs = 0;
            Random random = new Random();

            while (day <= MAX_OF_WORKING_DAYS && totalHrs <= MAX_WORKING_HRS)
            {
                var empcheck = random.Next(0, 3);
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
