using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Practice
{
    internal class MakeArrayConsecutive
    {
        public int solution(int[] statues)
        {
            int min = statues.Min()-1;
            int sum = statues.Max() - statues.Count()-min;
            return sum;
        }

    }
}
