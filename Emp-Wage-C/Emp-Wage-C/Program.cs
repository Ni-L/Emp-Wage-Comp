﻿using System;

namespace Emp_Wage_C
{
    class Program
    {
        /// <summary>
        /// Creating Program for Employee Wage PartTime And FullTime Employee
        /// </summary>
        const int FullTime = 1;                                        //creating a local variable
        const int PartTime = 2;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee wage Calculation....");
            // Constant Variable

            int empRatePerHour = 20;

            //Local Variables
            int empHrs = 0;
            int empWage = 0;

            Random random = new Random();                           //Generating Random value
            int employeeCheck = random.Next(0, 3);                  // assigning Random value to the variable 
            Console.WriteLine("Random Value: " + employeeCheck);

            //using Case statement 
            switch (employeeCheck)
            {
                case FullTime:
                    empHrs = empHrs + 8;
                    break;

                case PartTime:
                    empHrs = empHrs + 4;
                    break;

                default:
                    empHrs = 0;
                    break;
            }


            // computation
            empWage = empRatePerHour * empHrs;
            Console.WriteLine("Employee wage per day: " + empWage);
            Console.Read();
        }
    }
}