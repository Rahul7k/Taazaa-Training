using System;
namespace Delagate.Models
{
    public class DelegateAssign
    {
        public static double AddNum(int x, int y, int z)
        {
            return x+y+z;
        }

        public static void SubNum(int a, int b)
        {
            Console.WriteLine(a-b);
        }

        public static bool CheckLength(string str)
        {
            if(str.Length>5)
                return true;
            return false;
        }

    }
}