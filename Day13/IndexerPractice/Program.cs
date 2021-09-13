using System;

namespace IndexerPractice
{
    public class Employee
    {
        private object [] EmpData = new object[3];

        public object this[int i]
        {
            get
            {
                return EmpData[i];
            }
            set
            {
                EmpData[i] = value;
            }
        }

    }
    class Program
    {
        static void Main()
        {
            Employee employee = new Employee();
            employee[0] = 101;
            employee[1] = "Rahul";
            employee[2] = "ASET";
            Console.WriteLine(employee[0]+"\n"+employee[1]+"\n"+employee[2]);
        }
    }
}
