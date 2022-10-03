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
            //UC-9 Ability to Save Wage for each Company

            EmployeWage Dmart=new EmployeWage ("Dmart",20,30,120);
            Dmart.CalculateEmpWage();
            EmployeWage reliance = new EmployeWage("relaince",30,40,150);
            reliance.CalculateEmpWage();

            Console.ReadLine();
        }
       
            
         
        

    }
    
}
