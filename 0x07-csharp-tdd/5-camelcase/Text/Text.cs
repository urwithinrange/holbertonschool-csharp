using System;

namespace Text
{
    ///<summary>Class Str</summary>
    public class Str
    {
        ///<summary>Counts the number of words in a string</summary>
        public static int CamelCase(string s)
        {
            int i = 0;
            if (s.Length == 0)
            {
                return i;
            }
            i++;
            foreach (char c in s)
            {
                if (Char.IsUpper(c) == true)
                    i++;
            }
            return i;
        }
    }
}
