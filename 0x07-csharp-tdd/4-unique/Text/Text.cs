using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace Text
{
    /// <summary>Class Str</summary>
    public class Str
    {
        /// <summary>Returns index of first non-repeating char or -1 for no non-repeating char</summary>
        public static int UniqueChar(string s)
        {
            int x = 0;
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = 0; j < s.Length; j++)
                {
                    if (s[i] == s[j])
                        x++;
                    if (x > 1)
                    {
                        x = 0;
                        break;
                    }
                    else if (j + 1 == s.Length)
                        return i;
                }                    
            }
            return -1;
        }
    }
}
