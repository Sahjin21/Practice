using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Practice
{
    internal class MovingZerosToTheEnd
    {
        int[] solution = new int[0];
        int zeros = 0;

        public int[] MoveZeroes(int[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0)
                {
                    zeros++;
                }
                else if (arr[i] != 0)
                {
                    Array.Resize(ref solution, solution.Length +1);
                    solution[solution.Length -1 ]=arr[i];
                }
            }
            Array.Resize(ref solution, solution.Length+zeros);
            return solution;
        }
    }
}
