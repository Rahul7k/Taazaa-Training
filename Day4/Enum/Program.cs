using System;

namespace Enum
{
    class Program
    {
        enum Months
        {
            Null,       // 0
            January,    // 1
            February,   // 2
            March,      // 3
            April,      // 4
            May,        // 5
        }
        static void Main(string[] args)
        {
            int obj1 = (int) Months.May;
            Console.WriteLine(obj1);
        }
    }
}
