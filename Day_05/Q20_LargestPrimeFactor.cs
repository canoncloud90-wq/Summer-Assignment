using System;
namespace largestprimrefactor
{
    class Program
    {
        static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int maxPrime = -1;
            for (int i = 2; i <= n; i++)
            {
                while (n % i == 0)
                {
                    maxPrime = i;
                    n = n / i;
                }
            }
            Console.WriteLine("the largest prime factor is " + maxPrime);
        }

    }
}
