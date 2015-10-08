/*  Write a program that calculates n! / k! for given n and k (1 < k < n < 100). 
    Use only one loop.
*/

using System;
using System.Numerics;

class CalculateNK
{
    static BigInteger Factorial(BigInteger value)
    {
        if (value <= 1)
        {
            return 1;
        }
        return (value * Factorial(value - 1));
    }

    static void Main()
    {
        Console.WriteLine("Enter values for N! and K! - (1 < k < n < 100)");
        Console.Write("N = ");
        BigInteger n = BigInteger.Parse(Console.ReadLine());
        Console.Write("K = ");
        BigInteger k = BigInteger.Parse(Console.ReadLine());
        if (1 < k && k < n && n < 100)
        {
            n = Factorial(n);
            k = Factorial(k);
            BigInteger result = n / k;
            Console.WriteLine("Result: {0}", result);
        }
        else
        {
            Console.WriteLine("Invalid values.");
        }
    }
}
