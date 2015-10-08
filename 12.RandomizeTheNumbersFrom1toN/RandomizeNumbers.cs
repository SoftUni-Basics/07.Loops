/*  Write a program that enters in integer n and prints the numbers 1, 2, …, n in random order.
*/

using System;
using System.Collections.Generic;

class RandomizeNumbers
{
    static void Main()
    {
        int counter = int.Parse(Console.ReadLine());
        HashSet<int> numbers = new HashSet<int>();
        Random rnd = new Random();

        while (numbers.Count < counter)
        {
            numbers.Add(rnd.Next(1, counter + 1));
        }

        foreach (var nmbr in numbers)
        {
            Console.WriteLine(nmbr);
        }
    }
}
