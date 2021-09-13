using System;

namespace Polymorphism
{
    class Person
    {
        // example of method overloading
        public int Walk(int a)
        {
            return a;
        }
        public string Walk(string a)
        {
            return a;
        }
    }
    class Program
    {
        static void Main()
        {
             Person person = new Person();
             int n = person.Walk(10);
             //association of an object with overloaded method is called static polymorphism
             string s = person.Walk("Walk along");
             Console.WriteLine(n + "\n" + s);
        }
    }
}
