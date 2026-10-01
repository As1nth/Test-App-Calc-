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

        Console.WriteLine("\nDemo finished successfully.");
    }
}
