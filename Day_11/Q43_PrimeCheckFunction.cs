using System;

class Program
{
    static bool IsPrime(int n)
    {
        if(n < 2)
            return false;

        for(int i = 2; i <= n / 2; i++)
        {
            if(n % i == 0)
                return false;
        }

        return true;
    }

    static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());

        if(IsPrime(n))
            Console.WriteLine("Prime Number");
        else
            Console.WriteLine("Not Prime Number");
    }
}