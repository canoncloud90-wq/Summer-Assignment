using System;

class Program
{
    static void Main()
    {
        int n = 5;

        for(int i = 1; i <= n; i++)
        {
            for(int j = 0; j < i; j++)
            {
                Console.Write((char)('A' + j));
            }
            Console.WriteLine();
        }
    }
}