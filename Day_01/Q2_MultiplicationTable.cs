using System;
namespace NoOfDigits

{
class Program

{
    static void Main()
    {
        int a = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <=10; i++)
        {
            Console.WriteLine(a + " x " + i + " = " + a * i);
        }
        
      
    }
}
}