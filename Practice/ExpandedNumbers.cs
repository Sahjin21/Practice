using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Practice
{
/*You will be given a number and you will need to return it as a string in Expanded Form.For example:
Kata.ExpandedForm(12); # Should return "10 + 2"
Kata.ExpandedForm(42); # Should return "40 + 2"
Kata.ExpandedForm(70304); # Should return "70000 + 300 + 4"*/

    internal class ExpandedNumbers
    {
        public string solution(int number)
        {
            string result = "";
            string numberString = number.ToString();

            for (int i = 0; i < numberString.Length; i++)
            {
                if (numberString[i] != '0')
                {
                    result += numberString[i];
                    for (int j = i + 1; j < numberString.Length; j++)
                    {
                        result += '0';
                    }
                    result += " + ";
                }
            }

            result = result.TrimEnd(' ', '+');

            return result;
        }
    }
}
