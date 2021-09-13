using System;
using System.Collections;

namespace CollectionP
{
    class Program
    {
        static void Main()
        {
            // Creating a Queue
            Queue objQ = new Queue();
    
            // Inserting the elements into the Queue
            objQ.Enqueue("Rahul");
            objQ.Enqueue("Prashant");
            objQ.Enqueue("Gopal");
            objQ.Enqueue("Saurabh");
            objQ.Enqueue("Vaibhav");
    
            // Displaying the count of elements contained in the Queue
            Console.Write("Number of elements in the Queue : " + objQ.Count +"\n");
    
            // Displaying the beginning element of Queue
            Console.WriteLine("Beginning Item is: " + objQ.Peek());
        }
    }
}
