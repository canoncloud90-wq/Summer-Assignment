using System;

class Program
{
    static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());

        int count = 0;

        while(n > 0)
        {
            if(n % 2 == 1)
                count++;

            n /= 2;
        }

        Console.WriteLine("Set Bits = " + count);
    }
}