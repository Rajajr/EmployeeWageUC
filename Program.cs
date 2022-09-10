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
            //UC-1 Find Employee is Present or not
            int empPresent = 1;
            Random random = new Random();
            //Generate random number within range either 0 or 1
            int empcheck = random.Next(0, 2);
            Console.WriteLine("Random value:" + empcheck);

            if (empPresent == empcheck)
                Console.WriteLine("Employee is Present");
            else
                Console.WriteLine("Employee is Absent");
            Console.ReadLine();
        }
    }
}
