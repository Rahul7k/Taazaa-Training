using System;
using DelegateAssignment.Models;
delegate void CalcDelegate(int n1);

namespace DelegateAssignment
{
    class Program
    {
        static void Main()
        {
            // Delegate method
            CalcDelegate mySq = new CalcDelegate(Calculations.Square);
            mySq.Invoke(6);

            // Anonymous Function
            CalcDelegate myCube = delegate(int c1){
                Console.WriteLine(c1*c1*c1);
            };

            // Lamda Function
            CalcDelegate mySqrt = (int s1) =>
            {
                Console.WriteLine(Math.Sqrt(s1));
            };

            myCube(7);
            mySqrt(16);
        }
    }
}
