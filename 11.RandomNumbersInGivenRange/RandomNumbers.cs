/*  Write a program that enters 3 integers n, min and max (min ≤ max) and prints n random numbers in the range [min...max].
*/

using System;

class RandomNumbers
{
    static void Main()
    {
        Console.Write("Count of numbers: ");
        int counter = int.Parse(Console.ReadLine());
        Console.Write("Minimal integer:  ");        
        int min = int.Parse(Console.ReadLine());
        Console.Write("Maximum integer:  ");        
        int max = int.Parse(Console.ReadLine());

        if (counter > 0 && min < max)
        {
            Random rnd = new Random();
            for (int i = 0; i < counter; i++)
            {
                Console.Write(" {0}", rnd.Next(min, max + 1));
            }
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Invalid values!");
        }
    }
}
