using System;

namespace CodePilot.TestApp;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== CodePilot Calculator Demo ===");

        var calculator = new Calculator();

        int a = 10;
        int b = 2;

        Console.WriteLine($"Add: {a} + {b} = {calculator.Add(a, b)}");
        Console.WriteLine($"Subtract: {a} - {b} = {calculator.Subtract(a, b)}");
        Console.WriteLine($"Divide: {a} / {b} = {calculator.Divide(a, b)}");
        Console.WriteLine($"Multiply: {a} * {b} = {calculator.Multiply(a, b)}");
        Console.WriteLine($"Power: {a} ^ {b} = {calculator.Power(a, b)}");
        Console.WriteLine($"SquareRoot(16): {calculator.SquareRoot(16)}");
        Console.WriteLine($"SquareRoot(0): {calculator.SquareRoot(0)}");

        try
        {
            calculator.SquareRoot(-4);
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine($"SquareRoot(-4): Correctly threw {ex.GetType().Name}");
        }

        Console.WriteLine($"Factorial(0): {calculator.Factorial(0)}");
        Console.WriteLine($"Factorial(5): {calculator.Factorial(5)}");

        try
        {
            calculator.Factorial(-1);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Factorial(-1): Correctly threw {ex.GetType().Name}");
        }

        Console.WriteLine("\nDemo finished successfully.");
    }
}
