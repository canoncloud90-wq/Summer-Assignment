using System;

class Program
{
    static int Maximum(int a, int b)
    {
        if(a > b)
            return a;
        else
            return b;
    }

    static void Main()
    {
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Maximum = " + Maximum(a, b));
    }
}