using System;
namespace prime
{
    class Program
    {
        static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    count++;
                }
            }
            if (count == 2)
            {
                Console.WriteLine("the number is prime");
            }
            else
            {
                Console.WriteLine("the number is not prime");
            }                                                                                           
        }       
    }       
}   