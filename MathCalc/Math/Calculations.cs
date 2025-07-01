using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathCalc.Math
{
    internal class Calculations
    {
        public void Plus(int a, int b)
        {
            Console.WriteLine($"The result of {a} + {b} is {a + b}");
        }

        public void Minus(int a, int b)
        {
            Console.WriteLine($"The result of {a} - {b} is {a - b}");
        }
    }
}
