using System;
namespace strongno
{
    class Program
    {
        static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int temp = n;
            while (temp > 0)
            {
                int digit = temp % 10;
                int fact = 1;
                for (int i = 1; i <= digit; i++)
                {
                    fact = fact * i;
                }
                sum = sum + fact;
                temp = temp / 10;
            }
            if (sum == n)
            {
                Console.WriteLine("the number is strong");
            }
            else
            {
                Console.WriteLine("the number is not strong");
            }
        }

    }
}
