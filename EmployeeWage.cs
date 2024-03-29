﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageCompNonStaticProblem
{
    public class EmployeeWage
    {
        public const int IS_FULL_TIME = 1;
        public const int EMP_RATE_PER_HOUR = 20;
        public const int IS_PART_TIME = 2;
        public const int NUM_OF_WORKING_DAYS = 20;
        public const int MAX_HRS_IN_MONTHS = 100;


        public void CalEmployeeWage()
        {
            int empHrs = 0;
            int empWage = 0;
            int totalEmpHrs = 0;
            int totalWorkingdays = 0;

            while (totalEmpHrs < MAX_HRS_IN_MONTHS && totalWorkingdays < NUM_OF_WORKING_DAYS)
            {
                totalWorkingdays++;



                Random random = new Random();
                int empCheck = random.Next(3);

                switch (empCheck)
                {
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    default:
                        empHrs = 0;
                        break;



                }


                empWage = empHrs * EMP_RATE_PER_HOUR;

                totalEmpHrs += empHrs;
                Console.WriteLine("Day # : " + totalWorkingdays + "Emp Hrs " + empHrs); ;
            }
            int totalEmpWage = totalEmpHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Total Emp Wage : " + totalEmpWage);


        }
    }
}
