using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Practice
{
    internal class Palindrome2
    {
        public bool solution(string input)
        {
            int left = 0;
            int right = input.Length-1;
            bool result = true;

            while (left < right)
            {
                if (input[left] != input[right])
                {
                    result = false;
                    
                }
                left++;
                right--;
            }
            return result;
        }
    }
}
