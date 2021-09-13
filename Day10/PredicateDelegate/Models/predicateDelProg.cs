namespace PredicateDelegate.Models
{
    public class predicateDelProg
    {
        public static bool CheckLength(string str)
        {
            if(str.Length>8)
                return true;
            return false;
        }
    }
}