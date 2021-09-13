//difference between finalize and dispose
using System;
using GarbageCollection;

namespace GarbageCollection
{
    class Program
    {
        static void Main()
        {   //we are defining the scope of an object using block, achieves explicit garbage collection
            using(IT itObj = new IT())
            {
                itObj.DatabaseCollect(); //now the function is called, got the value still resources are running so why not cleanup the resource just after consuming
                                        //this is where garbage collection comes into picture
            } //at this point dispose function will be called explicitely
            
            Console.WriteLine("End of the Program");
        }
    }
}
