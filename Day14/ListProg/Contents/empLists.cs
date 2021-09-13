using System.Collections.Generic;
using ListProg.Models;
namespace ListProg.Contents
{
    public class empLists
    {
        public List<employee> EmpLists;
        public empLists()
        {
            EmpLists = new List<employee>();
        }
        public List<employee> AddEmp()
        {
            EmpLists.Add(new employee
            {
                EId = 101,
                EName = "Rahul"
            });
            EmpLists.Add(new employee
            {
                EId = 102,
                EName = "Maniram"
            });
            return EmpLists;
        }
        public List<employee> SearchEmp()
        {
            EmpLists.Contains(new employee
            {
                EId = 102
            });
            return EmpLists;
        }
    }
}