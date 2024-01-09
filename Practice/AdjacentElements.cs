using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Practice
{

    /*Given an array of integers, find the pair of adjacent elements that has the largest product and return that product.*/
    internal class AdjacentElements
    {
        public int solution(int[] inputArray)
        {
            int maxProduct = inputArray[0] * inputArray[1];
            for (int i = 1; i < inputArray.Length - 1; i++)
            {
                int currentProduct = inputArray[i] * inputArray[i + 1];
                Console.WriteLine(inputArray[i] + " * " + inputArray[i + 1] + " = " + currentProduct);
                maxProduct = Math.Max(maxProduct, currentProduct);
            }

            return maxProduct;
        }
    }
}
