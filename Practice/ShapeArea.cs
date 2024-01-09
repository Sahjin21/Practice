using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Practice
{
    internal class shapeArea
    {
        public int solution(int n)
        {
            int i = n * n + (n - 1) * (n - 1);
            return i;
        }
    }
}
