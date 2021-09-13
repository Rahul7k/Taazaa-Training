using System;
using InterfaceMultiple.Rules;
using InterfaceMultiple.Employee;


namespace InterfaceMultiple
{
    class Program
    {
        static void Main(string[] args)
        {
            var obj = new Employees();
            string agree = obj.agreement();
            int lev = obj.leaves();
            int wrk = obj.work();
            int sal = obj.salary();
            Console.WriteLine(agree + "\nNo of leaves: " + lev +"\nWorking Hours: "+ wrk+ "\nYour Salary: " + sal);
        }
    }
}
