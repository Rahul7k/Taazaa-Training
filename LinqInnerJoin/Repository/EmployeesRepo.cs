using System.Collections.Generic;
using LinqInnerJoin.Models;
namespace LinqInnerJoin.Repository
{
    public class EmployeesRepo
    {
        public List<Employees> empList;
        public EmployeesRepo()
        {
            empList = new List<Employees>();
        }

        public List<Employees> EmpDetails()
        {
            empList.Add(new Employees{
                EmpId = 101,
                EmpName = "Rahul",
                EmpCompany = "Taazaa",
                EmpAddress = "Noida"
            });

            empList.Add(new Employees{
                EmpId = 102,
                EmpName = "Prashant",
                EmpCompany = "Amazon",
                EmpAddress = "Pune"
            });

            empList.Add(new Employees{
                EmpId = 103,
                EmpName = "Saurabh",
                EmpCompany = "IBM",
                EmpAddress = "Bangalore"
            });

            empList.Add(new Employees{
                EmpId = 104,
                EmpName = "Gopal",
                EmpCompany = "Crio",
                EmpAddress = "Bangalore"
            });

            empList.Add(new Employees{
                EmpId = 105,
                EmpName = "Karan",
                EmpCompany = "Taazaa",
                EmpAddress = "Delhi"
            });

            return empList;
        }
    }
}