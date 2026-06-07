using System;

class Program
{
    static void Main()
    {
        int x = Convert.ToInt32(Console.ReadLine());
        int n = Convert.ToInt32(Console.ReadLine());

        long result = 1;

        for(int i = 1; i <= n; i++)
        {
            result *= x;
        }

        Console.WriteLine(result);
    }
}