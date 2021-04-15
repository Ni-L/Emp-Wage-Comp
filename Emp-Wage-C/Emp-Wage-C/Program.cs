using System;

namespace Emp_Wage_C
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WelCome To The Employee Wage");
            int Present = 1;
            Random random = new Random();
            int EmpCheck = random.Next(0, 2);
            Console.WriteLine("EmpCheck: " + EmpCheck);

            if (EmpCheck == Present)
            {
                Console.WriteLine("Employee PRESENT");
            }
            else
            {
                Console.WriteLine("Employee ABSENT");
            }
            Console.Read();
        }
    }
}
