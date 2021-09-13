//Indexer

using System;

namespace MajorLogic
{
    public class Employee
    {
        private object [] Data = new object[2]; //variable name is data and done indexing with 2 subscript. E.g. Data[0]=empCode, Data[1]=empName
        
        public object this[int i]   //this referred to employee object
        {
            get
            {
                return Data[i];
            }
            set
            {
                Data[i] =value;
            }
        }           //line 11-21 is encapsulation
    }
    class Program
    {
        static void Main()
        {
            Employee employee = new Employee();
            employee[0] = 110;      //set //Data[0]=employee[0], Data[1]=employee[1];
            employee[1] = "Rahul";  //set
            Console.WriteLine(employee[0] + "\n" + employee[1]);
        }
    }
}
