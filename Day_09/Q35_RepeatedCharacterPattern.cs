using System;

class Program
{
    static void Main()
    {
        int n = 5;

        for(int i = 1; i <= n; i++)
        {
            for(int j = 1; j <= i; j++)
            {
                Console.Write((char)('A' + i - 1));
            }
            Console.WriteLine();
        }
    }
}