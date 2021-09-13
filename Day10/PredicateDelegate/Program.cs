using System;
using PredicateDelegate.Models;

namespace PredicateDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Predicate<string> preObj = predicateDelProg.CheckLength;
            bool resLen = preObj.Invoke("Hello There");
            Console.WriteLine(resLen);
        }
    }
}
