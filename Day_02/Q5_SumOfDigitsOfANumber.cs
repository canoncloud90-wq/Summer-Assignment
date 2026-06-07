using System;
namespace SumOfDigits
{
    class Program
    {
        static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            while (n > 0)
            {
                sum = sum + n % 10;
                n = n / 10;
            }
            Console.WriteLine("the sum of digits is " + sum);
        }

    }
}   
