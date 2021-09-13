using System;

public delegate string WelcomeDelegate(string name);

namespace AnonymousMethod
{
    class Program
    {
        static void Main()
        {
            WelcomeDelegate welcomeObj = delegate(string name)
            {
                return "Hello " + name + "! Welcome to the team.";
            };

            string res = welcomeObj.Invoke("Rahul");
            Console.WriteLine(res);
        }
    }
}
