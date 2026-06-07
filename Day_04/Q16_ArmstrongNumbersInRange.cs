using System;
namespace rangearmstrong
{
    class Program
    {
        static void Main()
        {
            int start = Convert.ToInt32(Console.ReadLine());
            int end = Convert.ToInt32(Console.ReadLine());
            for (int i = start; i <= end; i++)
            {
                int sum = 0;
                int temp = i;
                while (temp > 0)
                {
                    int digit = temp % 10;
                    sum += digit * digit * digit;
                    temp /= 10;
                }
                if (sum == i)
                {
                    Console.WriteLine(i + " is an Armstrong number.");
                }
            }
        }

    }
}