using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Practice
{
    internal class AlmostIncreasingSequence
    {
        public bool solution(int[] sequence)
        {
            if (sequence == null || sequence.Length <= 2)
            {
                return true; // A sequence with 0 or 1 element is strictly increasing
            }

            int count = 0;

            for (int i = 1; i < sequence.Length; i++)
            {
                if (sequence[i] <= sequence[i - 1])
                {
                    count++;

                    if (count > 1 || (i < sequence.Length - 1 && sequence[i + 1] <= sequence[i - 1] && i > 1 && sequence[i] <= sequence[i - 2]))
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
