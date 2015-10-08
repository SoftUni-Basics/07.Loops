/*  Write a program that calculates the greatest common divisor (GCD) of given two integers a and b.
    Use the Euclidean algorithm (find it in Internet).*/

using System;

class CalculateGCD
{
    static void Main()
    {
        Console.WriteLine("calculates the GCD of given two integers a and b");
        Console.Write("A: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("B: ");        
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine("GCD: {0}", GCD(a, b));
    }

    static int GCD(int a, int b)
    {
        while (a > 0 && b > 0)
        {
            if (a > b)
            {
                a %= b;
            }
            else
            {
                b %= a;
            }
        }

        if (a == 0)
        {
            return b;

        }
        else
        {
            return a;
        }
    }
}
