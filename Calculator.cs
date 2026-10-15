namespace CodePilot.TestApp;

public class Calculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public int Subtract(int a, int b)
    {
        return a - b;
    }

    public int Divide(int a, int b)
    {
        if (b == 0)
        {
            throw new DivideByZeroException("Cannot divide by zero.");
        }

        return a / b;
    }

    public int Multiply(int a, int b)
    {
        return a * b;
    }

    public double Average(int a, int b)
    {
        return (a + (double)b) / 2;
    }

    public int Power(int baseNumber, int exponent)
    {
        return (int)Math.Pow(baseNumber, exponent);
    }

    public double SquareRoot(double number)
    {
        if (number < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(number), "Cannot calculate square root of a negative number.");
        }

        return Math.Sqrt(number);
    }

    public long Factorial(int n)
    {
        if (n < 0)
        {
            throw new ArgumentException("Cannot calculate factorial of a negative number.", nameof(n));
        }

        if (n > 20)
        {
            throw new OverflowException("Factorial for values greater than 20 causes 64-bit integer overflow.");
        }

        long result = 1;
        for (int i = 2; i <= n; i++)
        {
            result *= i;
        }

        return result;
    }
}
