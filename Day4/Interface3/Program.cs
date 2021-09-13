using System;

namespace Interface3
{
    //interface declaration
    interface Broker
    {
        int Rent();
        string Buy();
        string Sell();
    }
    class Buyer : Broker
    {
        public string Buy()
        {
            return "40 Lakhs";
        }

        public int Rent()
        {
            return 8500;
        }

        public string Sell()
        {
            return null;
        }
    }
    class Seller : Broker
    {
        public string Buy()
        {
            return null;
        }

        public int Rent()
        {
            return 7500;
        }

        public string Sell()
        {
            return "25 Lakhs";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var obj1 = new Buyer();
            string b1 = obj1.Buy();
            int r1 = obj1.Rent();
            Console.WriteLine("Buyer:\n"+"Can buy at: "+ b1 + "\nCan Rent at: "+ r1);
            var obj2 = new Seller();
            string s2 = obj2.Sell();
            int r2 = obj2.Rent();
            Console.WriteLine("Seller:\n"+"Can sell at: "+ s2 + "\nCan Rent at: "+ r2);
        }
    }
}
