using System;

namespace ConstructorChaining
{
    public class ConstructMe
    {
        public string name;
        public int id;
        public ConstructMe(string Name, int id)
        {
            this.name = Name;
            this.id = id;
        }

    }
    class program
    {
        static void Main(string[] args)
        {
            ConstructMe a = new ConstructMe("Rahul", 200);
            Console.WriteLine("Name: "+ a.name+"\n"+"ID: "+a.id);
        }
    }
}