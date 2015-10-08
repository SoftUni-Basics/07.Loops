/*  Write a program that enters from the console a positive integer n and prints all the numbers from 1 to n, on a single line, separated by a space.
*/

using System;

class NNumbers
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
            Console.Write("{0} ", i);
        }
        Console.WriteLine();
    }
}
