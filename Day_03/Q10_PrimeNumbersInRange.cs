using System;
namespace primeinarange
{
    class Program
    {
        static void Main()
        {
            int n1 = Convert.ToInt32(Console.ReadLine());
            int n2 = Convert.ToInt32(Console.ReadLine());
            for (int i = n1; i <= n2; i++)
            {
                int count = 0;
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        count++;
                    }
                }
                if (count == 2)
                {
                    Console.WriteLine(i);
                }
            }
        }

    }
}           