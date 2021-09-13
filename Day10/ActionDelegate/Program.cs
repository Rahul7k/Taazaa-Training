using System;
using ActionDelegate.Models;

namespace ActionDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<int, double> actObj = ActionDelProg.SubNum;
            actObj.Invoke(132, 54.342);
        }
    }
}
