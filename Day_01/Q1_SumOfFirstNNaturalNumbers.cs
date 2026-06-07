using System;
namespace SumOfN


{
class Program
{   static void Main()
{
    int n = Convert.ToInt32(Console.ReadLine());
    int sum = 0;
    for (int i = 1; i<=n ; i++)
    {
        sum = sum + i;
    }
    Console.WriteLine("the sum of first n naturl numbers is " + sum);
}
    
}
}