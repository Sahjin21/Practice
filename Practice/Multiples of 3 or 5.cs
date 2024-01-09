using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

/*If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. 
The sum of these multiples is 23. Finish the solution so that it returns the
sum of all the multiples of 3 or 5 below the number passed in. Additionally, 
if the number is negative, return 0 (for languages that do have them).

Note: If the number is a multiple of both 3 and 5, only count it once*/

namespace Practice.Practice
{
    internal class Multiples_of_3_or_5
    {
        int answer = 0;
        public int Solution(int value)
        {
            int x = 1;
            while (x < value)
                {
                if (x % 3  == 0 || x %  5 == 0 )
                    {
                    answer += x;
                    }
                x++;      
                }
           
            return answer;
        }
    }
}

