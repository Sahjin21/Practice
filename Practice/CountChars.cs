using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Practice
{
    internal class CountChars
    {
        public static Dictionary<char, int> Count(string str)
        {
            Dictionary<char, int> solution = new Dictionary<char, int>();
            foreach (char c in str)
            { 
                if (solution.ContainsKey(c))
                {
                    solution[c]++;
                }
                else
                {
                    solution.Add(c, 1);
                }
                    }
            return solution;
        }
    }
}
