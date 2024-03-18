using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Practice.Siemens
{
/*Take a number list and calculate how much effort it takes to reach the top stair.
 For example [1, 2, 4, 7] the first step counts as 1 effort, the fourth counts as 8.
You are able to take one or two steps. This example should equal 10.
 */
    internal class ClimbingStairs
    {
        public int solution (List<int> input)
        {
            int aLength = input.Count-1;
            int result = input[aLength] + input[0];
            for (int i = 0; i < aLength - 1; i++)
            {
                if (i != 0 && i != aLength)
                {
                    if (input[i] < input[i + 1])
                    {
                        result = result + input[i];
                    }
                    else result += input[i + 1];
                }
            }
            return result;
        }
    }
}
