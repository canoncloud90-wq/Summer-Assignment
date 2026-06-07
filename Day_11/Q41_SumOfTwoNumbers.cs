using System;

class Program
{
    static int Sum(int a, int b)
    {
        return a + b;
    }

    static void Main()
    {
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Sum = " + Sum(a, b));
    }
}