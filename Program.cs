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
            //UC-10 Ability to manage Employee Wage of Multiple Companies

            EmployeWage empWage = new EmployeWage();
            empWage.addEmployeWage("dmart",20,30,120);
            empWage.addEmployeWage("reliance",50,80,100);
            empWage.addEmployeWage("Deloitte",65,84,67);


            empWage.CalculateEmpWage();

            Console.ReadLine();
           
        }
       
            
         
        

    }
    
}
