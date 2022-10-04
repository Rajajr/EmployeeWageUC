using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageCompte1958Batch
{
    public class CompanyEmpWage
    {
        public string COMPANY;
        public int EMP_RATE_PER_HR, MAX_WORKING_DAYS, MAX_WORKING_HRS,TOTAL_EMP_WAGE;

        public CompanyEmpWage(string COMPANY, int EMP_RATE_PER_HR, int MAX_WORKING_DAYS, int MAX_WORKING_HRS)
        {
           this.COMPANY = COMPANY;
           this.EMP_RATE_PER_HR = EMP_RATE_PER_HR;
           this.MAX_WORKING_DAYS = MAX_WORKING_DAYS;
           this.MAX_WORKING_DAYS = MAX_WORKING_DAYS;


        }
        public void setTotalEmpWage(int TOTAL_EMP_WAGE)
        {
            this.TOTAL_EMP_WAGE = TOTAL_EMP_WAGE;
        }
        public string toString()
        {
            return "Total Employe Wage for the Company is : " + this.COMPANY + "  : " + this.TOTAL_EMP_WAGE;
        }
    }
}
