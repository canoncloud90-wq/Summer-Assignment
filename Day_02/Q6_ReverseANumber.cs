using System;
namespace SumOfDigits
{
    class Program
    {
        static void Main()
        {   int num=0;
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            while (n > 0)
            {
                num = n % 10;
                sum = sum * 10 + num;
                n = n / 10;
            }
            Console.WriteLine("the reversed number is " + sum);
        }

    }
}   