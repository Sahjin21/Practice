using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Practice
{
/*An isogram is a word that has no repeating letters, consecutive or non-consecutive.
Implement a function that determines whether a string that contains only letters is an isogram.
Assume the empty string is an isogram. Ignore letter case.*/
    internal class Isograms
    {    
        private string str = "Dermatoglyphics";
        HashSet<char> strHash = new HashSet<char>();
        public bool IsIsogram(string str)
        {
            foreach (char c in str)
            {
                if (strHash.Contains(char.ToLower(c)))
                { return false; }
                strHash.Add(char.ToLower(c));
            }            
            return true;
        }
    }
}
