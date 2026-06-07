using System;
namespace perfectno
{
    class Program
    {
        static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i < n; i++)
            {
                if (n % i == 0)
                {
                    sum = sum + i;
                }
            }
            if (sum == n)
            {
                Console.WriteLine("the number is perfect");
            }
            else
            {
                Console.WriteLine("the number is not perfect");
            }
        }

    }
}