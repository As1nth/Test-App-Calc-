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

    public int Power(int baseNumber, int exponent)
    {
        return (int)Math.Pow(baseNumber, exponent);
    }
}
