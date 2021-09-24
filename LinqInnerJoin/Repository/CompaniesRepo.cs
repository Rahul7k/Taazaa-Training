using System.Collections.Generic;
using LinqInnerJoin.Models;
namespace LinqInnerJoin.Repository
{
    public class CompaniesRepo
    {
        public List<Companies> compList;
        public CompaniesRepo()
        {
            compList = new List<Companies>();
        }

        public List<Companies> CompDetails()
        {
            compList.Add(new Companies{
                CompId = 1001,
                CompName = "Amazon",
                CompAddress = "Pune"
            });

            compList.Add(new Companies{
                CompId = 1002,
                CompName = "Taazaa",
                CompAddress = "Noida"
            });

            compList.Add(new Companies{
                CompId = 1003,
                CompName = "Google",
                CompAddress = "Bangalore"
            });

            compList.Add(new Companies{
                CompId = 1004,
                CompName = "Samsung SDE",
                CompAddress = "Gurgaon"
            });

            compList.Add(new Companies{
                CompId = 1005,
                CompName = "Capgemini",
                CompAddress = "Mumbai"
            });

            return compList;
        }
    }
}