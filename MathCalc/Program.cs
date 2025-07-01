using MathCalc.Math;

namespace MathCalc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculations calculations = new Calculations();
            
            Console.WriteLine("Welcome to the Math Calculator!");
            Console.WriteLine("Enter (Exit) to close the calculator at any time.");
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Please enter two numbers:");
                Console.Write("First number: ");
                int firstNumber = Convert.ToInt32(Console.ReadLine());
                Console.Write("Second number: ");
                int secondNumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Choose an operation: +, -, *, /");
                string operation = Console.ReadLine();
                Console.Clear();
                if (operation == "+")
                {
                    calculations.Plus(firstNumber, secondNumber);
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                }
                else if (operation == "-")
                {
                    calculations.Minus(firstNumber, secondNumber);
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                }
                else if (operation == "*")
                {
                    calculations.Multiply(firstNumber, secondNumber);
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                }
                else if (operation == "/")
                {
                    calculations.Divide(firstNumber, secondNumber);
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                }
                else if (operation.ToLower() == "exit")
                {
                    Console.WriteLine("Exiting the calculator. Goodbye!");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid operation. Please try again.");
                    return;
                }
            }
        }
    }
}