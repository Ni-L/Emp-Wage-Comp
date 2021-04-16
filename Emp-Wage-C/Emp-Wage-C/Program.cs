using System;

namespace EmpWageComputation
{
    class Program
    {
		static void Main(string[] args)
		{
			Console.WriteLine("welcome to employee Program");
			EmpWageBuilderArray empWageBuilder = new EmpWageBuilderArray();  //creat object of EmpWageBuilderArray class
			empWageBuilder.AddCompanyEmpWage("DMart", 20, 2, 10); //call AddCompany method
			empWageBuilder.AddCompanyEmpWage("Reliance", 10, 4, 20);
			empWageBuilder.computeEmpWage();
			Console.Read();
		}


	}
}
