using System;

namespace Text
{
    ///<summary>Class Str</summary>
    public class Str
    {
        ///<summary>Counts the number of words in a string</summary>
        public static int CamelCase(string s)
        {
            int i;
            if (s.Length == 0)
            {
                return 0;
            }
            if (Char.IsUpper(s[0]))
            {    
                return 1;
            }
            i = 1;
            foreach (char c in s)
            {
                if (Char.IsUpper(c) == true)
                    i++;
            }
            return i;
        }
    }
}
