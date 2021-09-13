using System;
 
namespace Program
{
    class SwitchCase
    {
        public static void Main()
        {
            char num;
            Console.WriteLine("Enter a number between 1 to 9");
            num = Convert.ToChar(Console.ReadLine());
 
            switch(Char.ToLower(num))
            {
                case '1':
                    Console.WriteLine("Bangalore");
                    break;
                case '2':
                    Console.WriteLine("Pune");
                    break;
                case '3':
                    Console.WriteLine("Gurgaon");
                    break;
                case '4':
                    Console.WriteLine("Mumbai");
                    break;
                case '5':
                    Console.WriteLine("Delhi");
                    break;
                case '6':
                    Console.WriteLine("Chennai");
                    break;
                case '7':
                    Console.WriteLine("Ahmedabad");
                    break;
                case '8':
                    Console.WriteLine("Kolkata");
                    break;
                case '9':
                    Console.WriteLine("Bhubneshwar");
                    break;
                default:
                    Console.WriteLine("Out of Scope");
                    break;
            }
        }
    }
}
