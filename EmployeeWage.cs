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

        public int numofCompany = 0;
        private CompanyEmpWage[] companyWagesArray;
          public EmployeWage()
            {

                this.companyWagesArray = new CompanyEmpWage[5];

            }

             public void addEmployeWage(string COMPANY, int EMP_RATE_PER_HR, int MAX_OF_WORKING_DAYS, int MAX_WORKING_HRS)
            {
              companyWagesArray[this.numofCompany] = new CompanyEmpWage(COMPANY,EMP_RATE_PER_HR,MAX_WORKING_HRS,MAX_OF_WORKING_DAYS);
              numofCompany++;
            }
        public void CalculateEmpWage()
        {
            for (int i=0; i < numofCompany; i++)
            {
                companyWagesArray[i].setTotalEmpWage(this.calculateEmpWage(this.companyWagesArray[i]));
                Console.WriteLine(this.companyWagesArray[i].toString());
            }
        }
            private int calculateEmpWage(CompanyEmpWage companyEmpWage)
            {
                const int Full_TIME = 1;
                const int PART_TIME = 2;
                int empHrs = 0, empWage = 0, totalEmpWage = 0, day = 1, totalHrs = 0;
                Random random= new Random();

                while (day<=companyEmpWage.MAX_WORKING_DAYS && totalHrs<=companyEmpWage.EMP_RATE_PER_HR)
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

                    empWage = empHrs * companyEmpWage.EMP_RATE_PER_HR;
                    totalEmpWage += empWage;
                    day++;
                    totalHrs += empHrs;
                }
                return totalEmpWage;
                
            }
            

        }
    
}