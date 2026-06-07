using System;
namespace lcm
{
    class Program
    {
        static void Main()
        {
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int lcm = (num1 > num2) ? num1 : num2;
            while (true)
            {
                if (lcm % num1 == 0 && lcm % num2 == 0)
                {
                    Console.WriteLine("the lcm of the two numbers is " + lcm);
                    break;
                }
                lcm++;
            }
        }

    }
}