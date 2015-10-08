/*  In combinatorics, the Catalan numbers are calculated by the following formula:
    C(n) = (2*n)!/(n+1)!*n!
    Write a program to calculate the nth Catalan number by given n (1 < n < 100).   */

using System;
using System.Numerics;

class CatalanNumbers
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
        Console.WriteLine("Enter value for N - (1 < N < 100)");
        Console.Write("N = ");
        BigInteger n = BigInteger.Parse(Console.ReadLine());

        if (n > 1 && n < 100)
        {
            BigInteger divisible = Factorial(2 * n);
            BigInteger divisor = Factorial(n + 1);
            BigInteger factorial = Factorial(n);
            BigInteger catalan = divisible / (divisor * factorial);
            Console.WriteLine("Catalan number = {0}", catalan);
        }
        else if (n <= 1)
        {
            Console.WriteLine("Catalan number = {0}", Factorial(n));
        }
        else
        {
            Console.WriteLine("Invalid value!");
        }
    }
}
