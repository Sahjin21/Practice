using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*In this kata you are required to, given a string, replace every letter with its position in the alphabet.
If anything in the text isn't a letter, ignore it and don't return it.*/

namespace Practice.Practice
{
    internal class AlphabetPosition
    {
        public string GetAlphabetPosition(string text)
        {
            StringBuilder result = new StringBuilder();
            foreach(char c in text)
            {
                if (char.IsLetter(c))
                {
                    int position = char.ToUpper(c) - 'A' + 1;
                    result.Append(position.ToString() + " ");
                }
            }
            return result.ToString().TrimEnd();
        }
    }
}
