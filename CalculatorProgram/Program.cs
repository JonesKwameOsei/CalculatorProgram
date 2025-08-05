using CalculatorLibrary;
using System.Text.RegularExpressions;
using Utilities;

namespace CalculatorProgram;
class Program
{
    static void Main(string[] args)
    {
        bool endApp = false;

        Calculator calculator = new Calculator();
        Utility utility = new Utility();
        utility.PrintHeader();

        while (!endApp)
        {
            double cleanNum1 = utility.GetNumberInput("first");
            double cleanNum2 = utility.GetNumberInput("second");
            double result = 0;

            // Ask the user to choose an operator.
            Console.WriteLine("Choose an operator from the following list:");
            Console.WriteLine("\ta - Add");
            Console.WriteLine("\ts - Subtract");
            Console.WriteLine("\tm - Multiply");
            Console.WriteLine("\td - Divide");
            Console.Write("Your option? ");

            string? op = Console.ReadLine();

            // Validate input is not null, and matches the pattern
            if (op == null || !Regex.IsMatch(op, "^[asmd]$"))
            {
                Console.WriteLine("Error: Unrecognized input.");
            }
            else
            {
                try
                {
                    result = calculator.DoOperation(cleanNum1, cleanNum2, op);
                    if (double.IsNaN(result))
                    {
                        Console.WriteLine("This operation will result in a mathematical error.\n");
                    }
                    else Console.WriteLine("Your result: {0:0.##}\n", result);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Oh no! An exception occurred trying to do the math.\n - Details: " + e.Message);
                }
            }
            Console.WriteLine(new string('-', 24));

            Console.Write("Press 'n' and Enter to close the app, or press any other key and Enter to continue: ");
            if (Console.ReadLine() == "n") endApp = true;

            Console.WriteLine("\n");
        }
        calculator.Close();
        return;
    }
}