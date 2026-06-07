using System;

class Program
{
    static void Main()
    {
        string binary = Console.ReadLine();

        int decimalNumber = 0;
        int power = 0;

        for(int i = binary.Length - 1; i >= 0; i--)
        {
            if(binary[i] == '1')
                decimalNumber += (int)Math.Pow(2, power);

            power++;
        }

        Console.WriteLine("Decimal = " + decimalNumber);
    }
}