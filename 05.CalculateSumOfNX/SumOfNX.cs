/*  Write a program that, for a given two integer numbers n and x, calculates the sum 
        S = 1 + 1!/x + 2!/x2 + … + n!/xn. 
    Use only one loop. 
    Print the result with 5 digits after the decimal point.     */

using System;

class SumOfNX
{
    static void Main()
    {
        Console.Write("N = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("X = ");        
        int x = int.Parse(Console.ReadLine());

        decimal  sum = 1;
        decimal factorial = 1;
        
        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
            decimal divisor = (decimal)Math.Pow(x, i);
            sum += factorial / divisor;
        }
        Console.WriteLine("Sum = {0:F5}", sum);
    }
}
