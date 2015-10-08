/*  Write a program that calculates with how many zeroes the factorial of a given number n has at its end. 
    Your program should work well for very big numbers, e.g. n=100000.
*/

using System;
using System.Numerics;

class FactorialZeroes
{
    static void Main()
    {
        Console.Write("Enter F!: ");
        int number = int.Parse(Console.ReadLine());
        int count = 0;
        int fact;
        for (int i = 5; i <= number; i += 5)
        {
            fact = i;
            while (fact % 5 == 0)
            {
                fact /= 5;
                count++;
            }
        }
        Console.WriteLine("Zeroes {0}\r\n", count);

        //Factorial(number);        //// uncomment for Factorials numbers
    }

    static void Factorial(int input)
    {
        Console.WriteLine("Enter F!: {0}", input);
        //int inNumb = int.Parse(Console.ReadLine());
        int inNumb = input;
        BigInteger factorial = inNumb;
        int count = 0;

        while (inNumb > 1)
        {
            factorial *= --inNumb;
        }

        while (factorial % 10 == 0)
        {
            factorial /= 10;
            count++;
        }
        Console.WriteLine("Zeroes {0}\r\n", count);
    }
}
