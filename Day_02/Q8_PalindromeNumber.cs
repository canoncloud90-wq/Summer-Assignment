using System;
namespace SumOfDigits
{
    class Program
    {
        static void Main()
        {
            int num = Convert.ToInt32(Console.ReadLine());
            int original = num;
            int sum = 0;
            while (num > 0)
            {                sum = sum * 10 + num % 10;
                num = num / 10;
            }
            if (original == sum)
            {                Console.WriteLine("the number is a pallindrome");
            }
            else
            {                Console.WriteLine("the number is not a pallindrome");
            }       
            
        }

    }
}