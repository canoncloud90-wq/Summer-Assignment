using System;

class Program
{
    static void Main()
    {
        int n = 5;

        for(int i = n; i >= 1; i--)
        {
            for(int j = 1; j <= n - i; j++)
                Console.Write(" ");

            for(int j = 1; j <= 2 * i - 1; j++)
                Console.Write("*");

            Console.WriteLine();
        }
    }
}