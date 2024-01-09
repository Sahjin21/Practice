using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Practice
{
    internal class DecendingOrder
    {
        public int DescendingOrder(int num)
        {
            string myNum = num.ToString();
            int[] numArray = new int[myNum.Length];
            for (int i = 0; i < myNum.Length; i++)
            {
                numArray[i] = int.Parse(myNum[i].ToString());
            }
            Array.Sort(numArray);
            Array.Reverse(numArray);
            num = Int32.Parse(string.Join("", numArray));
            return num;
        }
    }
}
