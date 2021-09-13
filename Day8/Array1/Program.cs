using System;

namespace Array1
{
    class Program
    {
        static void Main()
        {
            int[] arr = new int[10];    //creating an array of size 10
            Console.WriteLine("Enter a Number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for(int i=1; i<=n; i++){
                Console.WriteLine(i);
            }
        }
    }
}
