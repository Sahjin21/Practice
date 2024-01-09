using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Practice
{
    internal class MatricElementsSum
    {
        public int solution(int[][] matrix)
        {
            int sum = 0;

            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    if (matrix[i][j] >= 0)
                    {
                        sum += matrix[i][j];
                    }
                }
            }
            return sum;
        }
    }
}
