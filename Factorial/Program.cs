namespace Factorial;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a non-negative integer to calculate its factorial:");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Factorial of {n} = {Factorial(n)} = {FactorialIterative(n)}");
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
