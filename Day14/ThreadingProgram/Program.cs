using System;
using System.Threading;
namespace ThreadingProgram
{
    class MyWork
    {
        public void Work1()
        {
            Thread.Sleep(7000); //this function will take 7 seconds to perform the task
            Console.WriteLine("I'm doing for work 1");
        }
        public void Work2()
        {
            Console.WriteLine("I'm doing for work 2");
        }
        public static void Main()       //main is a thread. thread means it provides the execution to the program. or we can say thread is a execution model of the program
        {
            MyWork myWork = new MyWork();   //at this point we are invoking the first function is called work1
            myWork.Work1();
            myWork.Work2();                 //at this point we are invoking the second function is called work1

        }
    }
}
