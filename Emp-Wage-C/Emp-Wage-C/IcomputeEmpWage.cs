using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageComputation
{
    //Creating Interface
    public interface IcomputeEmpWage
    {
        //Calling CompanyEmpWage
        void AddCompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth);
        //Calling ComputeEmpWage
        void computeEmpWage();
        //Initialized getTotalWage
        int getTotalWage(string company);
    }
}
