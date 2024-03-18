using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Practice
{
    internal class StringReverse
    {
        public string solution(string input)
        {
            string result = "";
            for(int i = input.Length-1; i >= 0; i--)
            {
                result += input[i];
            }
            return result;
        }
    }
}
