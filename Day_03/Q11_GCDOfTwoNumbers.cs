using System;
namespace gcd
{
    class Program
    {
        static void Main()
        {
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            while (num1 != num2)
            {
                if (num1 > num2)
                    num1 = num1 - num2;
                else
                    num2 = num2 - num1;
            }
            Console.WriteLine("the gcd of the two numbers is " + num1);
        }

    }
}