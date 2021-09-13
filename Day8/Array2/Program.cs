using System;

namespace Array2
{
    class Program
    {
        static void Main()
        {
            int[] arr = new int[50];

            Console.WriteLine("Enter a number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter another number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            for(int i=num1 ; i<= num2; i++)
            {
                int flag = 1;
                for(int j=2; j<i/2; j++)
                {
                    if(i%j == 0)
                    {
                        flag = 0;
                        break;
                    }
                }

                if(flag == 1){
                    Console.WriteLine(i);
                }
                
            }

        }
    }
}
