using System;

namespace AbstractCl1
{
    abstract class PerimeterClass
    {
        public abstract int Perimeter(); //declare abstract method
    }

    class Rectangle : PerimeterClass    //class PerimeterClass inherit in child class Rectangle
    {
        int len = 0;
        int br = 0;
        public Rectangle(int l, int b)  //Constructor
        {
            len = l;
            br = b;
        }

        public override int Perimeter()     //abstract method
        {
            int sum = len+br;
            return 2*sum;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var obj = new Rectangle(5, 2);
            Console.WriteLine("Perimeter: "+ obj.Perimeter());
        }
    }
}
