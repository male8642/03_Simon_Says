using System;

namespace _03_Simon_Says
{
    internal class Simon
    {
        internal string Echo(string v)
        {
            v = v.ToLower();
            return v;
        }

        internal string Shout(string v)
        {
            v = v.ToUpper();
                return v;
        }

        internal string Repeat(string v)
        {
           return v + " " + v;
        }
        string result;
        internal string Repeat(string v1, int v2)
        {
            for (int i = 0; i < v2; i++)
            {
                result += v1 + " "; 
            }
            return result.Trim();
        }
        
        internal string StartOfWord(string v1, int v2)
        {
            return v1 = v1.Substring(0, 1);
        }

        internal string FirstWord(string v)
        {
            return v = v.Substring(0, 5);
        }

        //internal string Titleize(string v)
        //{

        //    return v;
        //}
    }
}