using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Practice
{
    internal class CenturyFromYear
    {
        public int centuryFromYear(int year)
        {
            int century = (year + 1) / 100 + 1;
            return century;
        }
    }
}
