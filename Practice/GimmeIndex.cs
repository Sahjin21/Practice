using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Practice
{
    internal class GimmeIndex
    {
        public int solution(int[] inputArray)
        {
            int[] sortedArray = inputArray;
            Array.Sort(sortedArray);
            int place = sortedArray.Length / 2;
            int middleNum = sortedArray[place];
            int middleNumOriginalPlace=0;
            foreach (int i in inputArray) {
                if (i == middleNum)
                    {
                    middleNumOriginalPlace = i;
                    }
            }

            return middleNumOriginalPlace;
        }
    }
}
