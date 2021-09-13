using System;
namespace GarbageCollection
{
    public class IT : IDisposable
    {
        public void DatabaseCollect()   //to connect to database we need so many resources
        {
            Console.WriteLine("let me write a code to connect to database");
        }

        public void Dispose()
        {
            Console.WriteLine("Destructor is Working");
        }

        /* ~ IT()  // finalize() act as a destructor
        {
            Console.WriteLine("Destructor is Working");
        } */
    }
}