using System;
using System.Threading;
using System.Threading.Tasks;

namespace TplProgram
{
    class myApp
    {
        // while multi-threading gives feel of asynchronous but actually context switching takeing place.
        public static void LongTask()
        {
            Thread.Sleep(10000);
            Console.WriteLine("Waiting");
        }
        public static async void MyTask()
        {
            // Task task = new Task(new Action(LongTask));
            await Task.Run(new Action(LongTask)); //new thread generated
            Console.WriteLine("New Thread");
        }
        public static void Main()
        {
            MyTask();
            Console.WriteLine("Running in main");
            Console.ReadLine();
        }
    }
}
