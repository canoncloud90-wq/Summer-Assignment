using System;

class Program
{
    static long Factorial(int n)
    {
        long fact = 1;

        for(int i = 1; i <= n; i++)
        {
            fact *= i;
        }

        return fact;
    }

    static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Factorial = " + Factorial(n));
    }
}