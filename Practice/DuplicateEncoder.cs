using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Practice
{
    /*The goal of this exercise is to convert a string to a new string where each 
    character in the new string is "(" if that character appears only once in the 
    original string, or ")" if that character appears more than once in the original string. 
    Ignore capitalization when determining if a character is a duplicate.*/
    internal class DuplicateEncoder
    {
        public string DuplicateEncode(string word)
        {
            Dictionary<char, int> charCounts = new Dictionary<char, int>();
            StringBuilder result = new StringBuilder();
            
            foreach ( char c in word)
            {
                char lowerC = Char.ToLower(c);
                if (!charCounts.ContainsKey(lowerC))
                {
                    charCounts[lowerC] = 1;
                }
                else
                {
                    charCounts[lowerC]++;
                }
            }

            foreach ( char c in word)
            {
                char lowerC = Char.ToLower(c);
                if ( charCounts[lowerC] >1 )
                {
                    result.Append(')');
                }
                else
                {
                    result.Append('(');
                }
            }
            return result.ToString();
        }
    }
}
