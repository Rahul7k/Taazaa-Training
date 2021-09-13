using System;
using InductionP.Employee;

namespace InductionP
{
    class Program
    {
        static void Main()
        {
            Employees employees1 = new Employees();
            employees1.empId=101; //at this point set will be called
            Console.WriteLine(employees1.EmpID); //at this point git will be called
        }
    }
}
