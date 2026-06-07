using System;

class Program
{
    static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());

        if(n == 0)
        {
            Console.WriteLine("Binary = 0");
            return;
        }

        string binary = "";

        while(n > 0)
        {
            binary = (n % 2) + binary;
            n /= 2;
        }

        Console.WriteLine("Binary = " + binary);
    }
}