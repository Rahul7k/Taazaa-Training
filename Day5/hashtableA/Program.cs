using System;
using System.Collections;
namespace hashtableA
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable hashT = new Hashtable();

            hashT.Add(1,"Rahul");
            hashT.Add(2,"Prashant");
            hashT.Add(3,"Gopal");
            hashT.Add(4,"Saurabh");
            hashT.Add(5, 2021);

            Console.WriteLine("Old value of 3: " +hashT[3]);
            hashT[3]="Vaibhav";
            Console.WriteLine("New value of 3: " +hashT[3]);

            int del = hashT.Count;
            Console.WriteLine("Old values: "+ del);
            hashT.Remove(5);
            del = hashT.Count;
            Console.WriteLine("New values: "+ del);

            if(hashT.ContainsValue("Rahul"))
            {
                Console.WriteLine("Contains Rahul");
            }
        }
    }
}
