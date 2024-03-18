using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Practice.Siemens
{
/*    Return an integer array.
The array should contain all the integers in the same order as they appear in the string*/
    internal class IntegersInStrings
    {
        private string input;
        public IntegersInStrings(string input) 
        {
            this.input = input;
        }
        public List<int> Integers()
        {
            List<int> result = new List<int>();
            
            foreach (var item in input.Split(','))
            {
                result.Add(Int32.Parse(item));
            }
            return result;
        }

    }
}
