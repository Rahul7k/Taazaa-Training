using System;
using System.Linq;
using System.Collections.Generic;
using LinqInnerJoin.Models;
using LinqInnerJoin.Repository;

namespace LinqInnerJoin
{
    class Program
    {
        static void Main(string[] args)
        {
            var empObj = new EmployeesRepo();
            List<Employees> employees = empObj.EmpDetails();
            var compObj = new CompaniesRepo();
            List<Companies> companies = compObj.CompDetails();
            

            var innerJoinObj =  (
                //Outer data source
                from emp in employees 
                //Inner data source
                join comp in companies
                //Fetching the data using on condition
                on emp.EmpAddress equals comp.CompAddress
                //Projecting the result set
                select new 
                {
                    EmployeeName = emp.EmpName,
                    Address = comp.CompAddress
                }).ToList();

            foreach(var temp in innerJoinObj)
            {
                Console.WriteLine("Employee Name: "+ temp.EmployeeName + "\n" + "Company Address: "+ temp.Address);
            }
        }
    }
}
