using System;
using System.Linq;
using System.Collections.Generic;
using LinqQueries.Models;

namespace LinqQueries
{
    class Program
    {
        static void Main()
        {
            // Student Collection
            IList<LinqQuerProg> linqQuers = new List<LinqQuerProg>()
            {
                new LinqQuerProg() {EmpId = 101, EmpName = "Rahul", EmpProfile="ASET"},
                new LinqQuerProg() {EmpId = 102, EmpName = "Gurpreet", EmpProfile="AQAT"},
                new LinqQuerProg() {EmpId = 103, EmpName = "Sukhdev", EmpProfile="HR"},
                new LinqQuerProg() {EmpId = 104, EmpName = "Karan", EmpProfile="ASET"},
                new LinqQuerProg() {EmpId = 101, EmpName = "Divya", EmpProfile="HR"}
            };
            var EmpGroupByProfile = from p in linqQuers group p by p.EmpProfile into empPr orderby empPr.Key select new {empPr.Key, empPr};

            foreach(var group in EmpGroupByProfile){
                Console.WriteLine("{0} Profile:", group.Key);

                group.empPr.ToList().ForEach(em => Console.WriteLine(em.EmpName));
            }
        }
    }
}
