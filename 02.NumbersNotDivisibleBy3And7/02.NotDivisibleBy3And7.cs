/*  Write a program that enters from the console a positive integer n and prints all the numbers from 1 to n not divisible by 3 and 7, on a single line, separated by a space
*/

using System;

class NotDivisibleBy3And7
{
    static void Main()
    {
        uint number;
        string input = string.Empty;
        do
        {
            Console.Clear();
            Console.Write("Enter positive integer:  ");
            input = Console.ReadLine();
        } while (!uint.TryParse(input, out number));

        for (uint i = 1; i <= number; i++)
        {
            if ((i % 3 != 0) && (i % 7 != 0))
            {
                Console.Write("{0} ", i);
            }
        }
        Console.WriteLine();
    }
}
