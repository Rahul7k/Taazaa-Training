using System;

namespace Array3
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter size of array");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            for(int i=0; i<n; i++){
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i=0; i<n-1; i++){
                for(int j=i; j<n; j++){
                    if(arr[i] < arr[j]){
                        int temp = arr[j];
                        arr[j] = arr[i];
                        arr[i] = temp;
                    }
                }
            }
            for(int i=0; i<n; i++)
            {
                int x = arr[i];
                Console.WriteLine(x); 
            }
        }
    }
}
