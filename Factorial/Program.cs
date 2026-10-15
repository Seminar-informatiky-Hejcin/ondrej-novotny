namespace Factorial;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a non-negative integer to calculate its factorial:");
        int n = Convert.ToInt32(Console.ReadLine());

        var f= new FactorialWithRecursion();
        var f2 = new FactorialIterative();


        Console.WriteLine($"Factorial of {n} = {f.Calculate(n)} = {f2.Calculate(n)}");
    }

    static int MathCalculations(int i, int a, int b, IFactorial factorial)
    {
        
    }

    static int Factorial(int n)
    {
        if (n < 0)
        {
            throw new Exception("Factorial of negative integer is not defined!");
        }

        if (n == 0)
        {
            return 1;
        }

        return n * Factorial(n - 1);
    }

    static int FactorialIterative(int n)
    {
        if (n < 0)
        {
            throw new Exception("Factorial of negative integer is not defined!");
        }

        int result = 1;
        for (int i = 1; i <= n; i++)
        {
            result *= i;
        }
        return result;
    }
}

public interface IFactorial
{
    int calculate(int n);
}

public class FactorialWithRecursion : IFactorial
{
    public int Calculate(int n)
    {
        if (n < 0)
        {
            throw new Exception("Factorial of negative integer is not defined!");
        }

        if (n == 0)
        {
            return 1;
        }

        return n * Factorial(n - 1);
    }
}

public class FactorialIterative : IFactorial
{
    public int Calculate(int n)
    {
        if (n < 0)
        {
            throw new Exception("Factorial of negative integer is not defined!");
        }

        int N = 1;
        for (int i = 1; i <= n; i++)
        {
            n *= i;
        }
        return n;
    }
}
