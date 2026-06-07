using System;
namespace hie
{
    class Program
    {
        static void Main()
        { 
            int n = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            while (n > 0)
            {
                n = n / 10;
                count++;
            }
            Console.WriteLine("the number of digits is " + count);
        }
    }
}