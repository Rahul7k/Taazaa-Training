using System;
using Interface1.Shift;
using Interface1.Employee;
namespace Interface1
{
    class Program
    {
        static void Main(string[] args)
        {
            var obj = new Employees();
            int temp = obj.work();
            Console.WriteLine(temp);
        }
    }
}
