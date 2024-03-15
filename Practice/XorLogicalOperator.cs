using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Practice
{
    /*In some scripting languages like PHP, there exists a logical operator (e.g. &&, ||, and, or, etc.)     
    called the "Exclusive Or" (hence the name of this Kata). The exclusive or evaluates two booleans. 
    It then returns true if exactly one of the two expressions are true, false otherwise. For example:
    Since we cannot define keywords in Javascript (well, at least I don't know how to do it), 
    your task is to define a function xor(a, b) where a and b are the two expressions to be evaluated. 
    Your xor function should have the behaviour described above, returning true if exactly one of 
    the two expressions evaluate to true, false otherwise.*/
    internal class XorLogicalOperator
    {
        public bool solution(bool a, bool b) 
        {
            if (a && !b || !a && b)
            {
                return true;

            }
            else return false;
        }
    }
}
