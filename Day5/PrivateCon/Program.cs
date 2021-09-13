using System;

namespace PrivateCon
{
    class Employee
    {
        //private constructor
        private Employee()
        {
            Console.WriteLine("This is a Private Constructor");
        }
        public static int Eid;
        public static string Ename;

        //Default Constructor
        public Employee(int i, string s)
        {
            Eid = i;
            Ename = s;
        }
    }
    class Program
    {
        static void Main()
        {
            // Only Default constructor with parameters will invoke
            var emp = new Employee(5, "Prashant");
            Console.WriteLine(Employee.Eid +"\n"+ Employee.Ename);
        }
    }
}
