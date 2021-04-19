using System;

namespace EmpWageComputation
{
    class Program
    {
		/// <summary>
		/// Creating Main method 
		/// </summary>
		/// <param name="args"></param>
		static void Main(string[] args)
		{
			//Write
			Console.WriteLine("welcome to employee Program");
			//creating object of EmpWageBuilderArray class
			EmpWageBuilderArray empWageBuilder = new EmpWageBuilderArray();
			//calling AddCompany method
			empWageBuilder.AddCompanyEmpWage("DMart", 20, 2, 10); 
			empWageBuilder.AddCompanyEmpWage("Reliance", 10, 4, 20);
			//Calling EmpWageBuilderMethod
			empWageBuilder.computeEmpWage();
			//.get Returns the value of variable name
			Console.WriteLine("Total Wage for DMart Comapny " + empWageBuilder.getTotalWage("DMart"));
			Console.Read();
		}
	}
}
