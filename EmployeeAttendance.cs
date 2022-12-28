using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblem
{
    public class EmployeeAttendance
    {
        public static void CheckAttendance()
        {
           const int IS_FULL_TIME = 1;
            const int IS_PART_TIME = 2;


            int EMP_RATE_PER_HOUR = 20;

            int empHrs = 0;
            int empWage = 0;
            

            Random random = new Random();
            int empCheck = random.Next(3);
            
            switch (empCheck)
            {
                case IS_FULL_TIME:
                    Console.WriteLine("Employee is present Full Time");
                    empHrs = 8;
                    break;

                case IS_PART_TIME:
                    Console.WriteLine("Employee is present Part Time");
                    empHrs = 4;
                    break;

                
                    empHrs = 0;
                    Console.WriteLine("Employee is Absent");
            }

           
            empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Emp Wage: " + empWage);
        }
    }
}

