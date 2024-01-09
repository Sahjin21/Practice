using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Practice
{
    internal class FindUnique
    {
        
        HashSet<int> uniques = new HashSet<int>();
        int unique = 0;
        public int GetUnique(IEnumerable<int> numbers)
        {
            foreach (int number in numbers)
            {
                if (uniques.Contains(number))
                {
                    uniques.Remove(number);
                }
                else
                {
                    uniques.Add(number);
                }
            }
            unique = uniques.FirstOrDefault();
            return unique;
        }
    }
}
