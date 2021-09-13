using System;
using System.Collections.Generic;
using ListProg.Models;
using ListProg.Contents;

namespace ListProg
{
    class Program
    {
        static void Main()
        {
            empLists employees = new empLists();
            List<employee> employees1 = employees.AddEmp();
            int len = employees1.Count;
            for(int i=0; i<len; i++)
            {
                Console.WriteLine(employees1[i].EId+"\n"+employees1[i].EName);
            }
            
        }
    }
}
