using System;

namespace Emp_Wage_C
{
    class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee wage Calculation....");
            // Constant Variable
            int FullTime = 1;                                        //creating a local variable
            int PartTime = 2;
            int empRatePerHour = 20;

            //Local Variables
            int empHrs = 0;
            int empWage = 0;

            Random random = new Random();                           //Generating Random value
            int employeeCheck = random.Next(0, 3);                  // assigning Random value to the variable 
            Console.WriteLine("Random Value: " + employeeCheck);


            if (employeeCheck == FullTime)                          //Checking whether Employee is Present or Not
            {
                Console.WriteLine("Employee is PRESENT");
                empHrs = 8;
            }
            else if (employeeCheck == PartTime)
            {
                Console.WriteLine("Part Time Empoyee: ");
                empHrs = 4;
            }
            else
            {
                Console.WriteLine("Employess is ABSENT");
                empHrs = 0;
            }


            // computation
            empWage = empRatePerHour * empHrs;
            Console.WriteLine("Employee wage per day: " + empWage);
            Console.Read();
        }
    }
}