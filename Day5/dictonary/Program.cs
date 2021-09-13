using System;
using System.Collections.Generic;

namespace dictonary
{
    class Program
    {
        static void Main(string[] args)
        {
            //declararation of Dictonary
            var dict = new Dictionary<string, object>();

            //Insert
            dict.Add("BillNo", 1);
            dict.Add("CName", "Rahul");
            dict.Add("CPhone", 458565);
            dict.Add("Amount",2800);

            //Update
            Console.WriteLine("Previous Amount: "+ dict["Amount"]);
            dict["Amount"] = 4200;
            Console.WriteLine("Updated Amount"+ dict["Amount"]);

            //Delete
            int cnt = dict.Count;
            Console.WriteLine("Old values: "+ cnt);
            dict.Remove("CPhone");
            cnt = dict.Count;
            Console.WriteLine("New Values: "+ cnt);

            //Search
            var ser = "Rahul";
            if(dict.ContainsValue(ser))
            {
                Console.WriteLine("Searched for value: "+ser);
            }
        }
    }
}
