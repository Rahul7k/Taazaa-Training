using System;
using System.Collections.Generic;
using AddUpdateAssignment.Models;
namespace AddUpdateAssignment.Contents
{
    public class EmployeeInfo
    {
        public List<Variables> Edetails;    //first we have to define a list variable where we can put Employee details
        public EmployeeInfo()
        {
            Edetails = new List<Variables>();
        }

        //Add operation
        public List<Variables> AddingEDetails()
        {
            Edetails.Add(new Variables
            {
                EId = 21001,
                EName = "Rahul",
                EDesignation = "ASET",
                ESalary = 400000
            });
            Edetails.Add(new Variables
            {
                EId = 21002,
                EName = "Gurpreet",
                EDesignation = "ASET",
                ESalary = 400000
            });
            Edetails.Add(new Variables
            {
                EId = 21003,
                EName = "Nidhi",
                EDesignation = "AQAT",
                ESalary = 400000
            });
            Console.WriteLine("Add operation");
            return Edetails;
            
        }

        //Remove Operation (removing all elements of a particular position)
        public List<Variables> DeletingEDetails()
        {
            Edetails.RemoveAt(1);
            Console.WriteLine("Delete/Remove operation");
            return Edetails;
        }

        //Insert Operation
        public List<Variables> InsertingEDetails()
        {
            Edetails.Insert(1, new Variables
            {
                EId = 2122,
                EName = "Karan",
                EDesignation = "ASET",
                ESalary = 500000
            });
            Console.WriteLine("Insert operation");
            return Edetails;
        }

        // Read/Search Operation
        public List<Variables> SearchEDetails()
        {
            Edetails.Contains(new Variables
            {
                EName = "Rahul"
            });
            Console.WriteLine("Read/Search operation");
            return Edetails;
        }
        
    }
}