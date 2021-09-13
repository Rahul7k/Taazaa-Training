using System;
using FuncDelegate.Models;
namespace FuncDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, float, double, double> funcD = FuncDeProg.AddNum;
            double resSum = funcD(34, 45.8f, 34343.336);
            Console.WriteLine(resSum);
        }
    }
}
