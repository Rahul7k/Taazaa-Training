using System;

namespace AbstractCl2
{
    abstract class AbClass      //abstract class
    {
        //Non Abstract Method in abstrct class
        public int AddNumbers(int num1, int num2)
        {
            return num1+num2;
        }
        //Abstract Method in abstract class
        public abstract int SubNumbers(int num1, int num2);
    }

    //child class of abstract class
    class Derived : AbClass
    {
        // implementing the abstract method
        public override int SubNumbers(int num1, int num2)
        {
            return num1-num2;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var obj = new Derived();
            Console.WriteLine("Addition: "+ obj.AddNumbers(8, 5)+"\nSubstraction: "+ obj.SubNumbers(12, 8));
        }
    }
}
