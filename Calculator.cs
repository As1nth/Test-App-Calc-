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
}
