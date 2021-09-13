using System;
using Delagate.Models;

public delegate double DelegateAdd(int x, int y, int z);
public delegate void DelagateSub(int x, int y);
public delegate bool DelegateCheckLen(string st);

namespace Delagate
{
    class Program
    {
        static void Main(string[] args)
        {
            DelegateAdd addObj = new DelegateAdd(DelegateAssign.AddNum);
            double resAdd = addObj.Invoke(5, 34, 55);
            Console.WriteLine(resAdd);

            DelagateSub subObj = new DelagateSub(DelegateAssign.SubNum);
            subObj.Invoke(98, 56);

            DelegateCheckLen checkLen = new DelegateCheckLen(DelegateAssign.CheckLength);
            bool resLen = checkLen.Invoke("Hello There");
            Console.WriteLine(resLen);
        }
    }
}
