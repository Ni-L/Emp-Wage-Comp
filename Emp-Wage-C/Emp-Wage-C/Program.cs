using System;

namespace Emp_Wage_C
{
	class Program
	{
        /// <summary>
        /// Main File
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
			{
				Console.WriteLine("welcome to employee Program");
				EmpWageBuilderArray empWageBuilder = new EmpWageBuilderArray();
				empWageBuilder.addCompanyEmpWage("DMart", 20, 2, 10);
				empWageBuilder.addCompanyEmpWage("Reliance", 10, 4, 20);
				CompanyEmpWage dmart = new CompanyEmpWage("DMart", 20, 2, 10);
				CompanyEmpWage reliance = new CompanyEmpWage("Reliance", 10, 4, 20);
				double dmartPrice = empWageBuilder.computeEmpWage(dmart);
				double reliancePrice = empWageBuilder.computeEmpWage(reliance);
				Console.Read();
			}


		}
	}
