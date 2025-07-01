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

        public void Multiply(int a, int b)
        {
            Console.WriteLine($"The result of {a} * {b} is {a * b}");
        }

        public void Divide(int a, int b)
        {
            if (b == 0)
            {
                Console.WriteLine("Error: Division by zero is not allowed.");
            }
            else
            {
                Console.WriteLine($"The result of {a} / {b} is {a / b}");
            }
        }
    }
}
