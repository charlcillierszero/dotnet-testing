namespace Manual_Testing;

using Calculators;
using Calculators.Implementations.Bad;
using Calculators.Implementations.Good;

internal class Program
{
    private static void Main(string[] args)
    {
        Calculator goodCalculator = new(new GoodAdd(), new GoodSubtract(), new GoodMultiply(), new GoodDivide());
        Calculator badCalculator = new(new BadAdd(), new BadSubtract(), new BadMultiply(), new BadDivide());
        Console.WriteLine("Welcome to the best calculator in the world! *(v0.0.1-alpha)");

        while (true)
        {
            Console.WriteLine("Please enter an input in the following structure: [{Calculator} {x} {action} {y}] (or 'q' to quit):");
            string input = Console.ReadLine();

            if (input == "q")
            {
                break;
            }

            string[] values = input.Split(' ');

            if (values.Length != 4)
            {
                Console.WriteLine("Invalid input. Please enter exactly four values separated by spaces.");
                continue;
            }

            string calculatorType = values[0];
            long x = long.Parse(values[1]);
            string actionType = values[2];
            long y = long.Parse(values[3]);

            Calculator calculator;
            switch (calculatorType)
            {
                case "good":
                    calculator = goodCalculator;
                    break;
                case "bad":
                    calculator = badCalculator;
                    break;
                default:
                    Console.WriteLine("Unknown calculator choice. Try again!");
                    continue;
            }

            Func<long, long, long> action;
            switch (actionType)
            {
                case "add":
                    action = calculator.Add;
                    break;
                case "sub":
                    action = calculator.Subtract;
                    break;
                case "mul":
                    action = calculator.Multiply;
                    break;
                case "div":
                    action = calculator.Divide;
                    break;
                default:
                    Console.WriteLine("Unknown action. Try again!");
                    continue;
            }

            try
            {
                Console.WriteLine($"Result: {action(x, y)}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        Console.WriteLine("Goodbye!");
    }
}