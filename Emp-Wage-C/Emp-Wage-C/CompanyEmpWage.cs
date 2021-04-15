using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emp_Wage_C
{
    class CompanyEmpWage
    {
        /// <summary>
        /// Creating Comapny Wage
        /// </summary>
        public string company;
		public int empRatePerHour;
		public int numOfWorkingDays;
		public int maxHoursPerMonth;
		public int totalEmpWage;

		public CompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
		{
			this.company = company;
			this.empRatePerHour = empRatePerHour;
			this.numOfWorkingDays = numOfWorkingDays;
			this.maxHoursPerMonth = maxHoursPerMonth;
		}

		public void setTotalEmpWage(int totalEmpWage)
		{
			this.totalEmpWage = totalEmpWage;
		}

		public string toString()
		{
			return "total EmpWage for company :" + this.company + " is :" + this.totalEmpWage;
		}
	}
}
    

