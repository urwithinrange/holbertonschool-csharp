using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace Text
{
    /// <summary>Str class</summary>
    public class Str
    {
        /// <summary>Method that determines if string is palindrome</summary>
        public static bool IsPalindrome(string s)
        {
            var letters = new StringBuilder();
            foreach (char element in s)
            {
                if (element >= 'A' && element <= 'Z' || element >= 'a' &&  element <= 'z')
                {
                    letters.Append(element);
                }
            }
            int j = letters.Length - 1;
            // s is not palindrome
            for (int i = 0; i <= j; i++, j--)
            {
                if (letters[i] != letters[j])
                    return false;
            }
            // s is palindrome
            return true;
        }
    }
}
