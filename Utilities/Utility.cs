namespace Utilities
{
    public class Utility
    {
        public void PrintHeader()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("╔════════════════════════════════════════╗");
            Console.WriteLine("║          CALCULATOR APP v1.0          ║");
            Console.WriteLine("║         Professional Edition           ║");
            Console.WriteLine("╚════════════════════════════════════════╝");
            Console.WriteLine();
            Console.ResetColor();
        }

        public double GetNumberInput(string position) 
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write($">> Type a {position} number, and then press Enter: ");
            Console.ResetColor();

            string? input = Console.ReadLine();
            double cleanNumber;

            while (!double.TryParse(input, out cleanNumber))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"This is not valid input. Please enter a numeric value: ");
                Console.WriteLine();
                Console.ResetColor();
                input = Console.ReadLine();
            }

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine($"   [✓] You entered: {cleanNumber}");
            Console.WriteLine();
            Console.ResetColor();
            return cleanNumber; 
        }
    }
}
