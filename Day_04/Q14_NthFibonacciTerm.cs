using System;
namespace nthfibonacci
{
    class Program
    {
        static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int a = 0, b = 1, c;
            if (n == 1)
            {
                Console.WriteLine(a);
            }
            else if (n == 2)
            {
                Console.WriteLine(b);
            }
            else
            {
                for (int i = 2; i < n; i++)
                {
                    c = a + b;
                    a = b;
                    b = c;
                }
                Console.WriteLine(b);
            }
        }

    }
}   