using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Practice
{
    internal class NameInitials
    {
        public string solution(string name)
        {
            string result = "";
            string[] parts = name.Split(' ');

            foreach (string part in parts) 
            {

                result += char.ToUpper(part[0]).ToString();

                if (part.Length > 0)
                {
                    result += ".";
                }
                
            }
            return  result.TrimEnd('.');
        }
    }
}
