using System;
using System.Collections.Generic;
using AddUpdateAssignment.Contents;
using AddUpdateAssignment.Models;

namespace AddUpdateAssignment
{
    class Program
    {
        static void Main()
        {
            EmployeeInfo Obj1 = new EmployeeInfo();
            List<Variables> EmpData1 = Obj1.AddingEDetails();
            int len1 = EmpData1.Count;
            for(int i=0; i<len1; i++){
                Console.WriteLine(EmpData1[i].EId+"\n"+EmpData1[i].EName+"\n"+EmpData1[i].EDesignation+"\n"+EmpData1[i].ESalary+"\n");
            }

            List<Variables> EmpData2 = Obj1.DeletingEDetails();
            int len2 = EmpData2.Count;
            for(int i=0; i<len2; i++){
                Console.WriteLine(EmpData2[i].EId+"\n"+EmpData2[i].EName+"\n"+EmpData2[i].EDesignation+"\n"+EmpData2[i].ESalary+"\n");
            }

            List<Variables> EmpData3 = Obj1.InsertingEDetails();
            int len3 = EmpData3.Count;
            for(int i=0; i<len3; i++){
                Console.WriteLine(EmpData3[i].EId+"\n"+EmpData3[i].EName+"\n"+EmpData3[i].EDesignation+"\n"+EmpData3[i].ESalary+"\n");
            }
            
        }
    }
}
