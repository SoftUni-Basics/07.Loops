/*  In combinatorics, the number of ways to choose k different members out of a group of n different elements (also known as the number of combinations) is calculated by the following formula:    N! / (K! * (N-K)!)
*/

using System;
using System.Numerics;

class NKCombinations
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
            BigInteger diff = Factorial(n - k);
            n = Factorial(n);
            k = Factorial(k);
            BigInteger result = n / (k * diff);
            Console.WriteLine("Result: {0}", result);
        }
        else
        {
            Console.WriteLine("Invalid values.");
        }
    }
}
