using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Practice
{
    internal class _2dArrayMax
    {
        public static int hourglassSum(List<List<int>> arr)
        {
            int highest = 0;
            for (int i = 0; i < 4; i++)
            {
                
                for (int h = 0; h < 4; h++)
                {
                    int sum = 0;
                    sum += arr[i][h];
                    sum += arr[i][h+1];
                    sum += arr[i ][h+2];
                    sum += arr[i + 1][h + 1];
                    sum += arr[i+2][h];
                    sum += arr[i + 2][h + 1];
                    sum += arr[i + 2][h + 2];
                    Console.WriteLine(sum);
                    if (sum > highest)
                    {
                        highest = sum;
                    }
                }
                
            }
            return highest;
        }
    }
}
