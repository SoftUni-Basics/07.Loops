/*  Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) and prints a matrix like in the examples below. 
    Use two nested loops.
*/

using System;

class MatrixOfNumbers
{
    static void Main()
    {
        Console.Write("Enter matrix size (1 <= n <= 20):  ");
        int size = int.Parse(Console.ReadLine());

        if (1 <= size && size <= 20)
        {
            for (int row = 0; row < size; row++)
            {
                for (int col = row + 1; col <= (row + size); col++)
                {
                    Console.Write("{0,2}", col);
                }
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("Invalid value!");
        }
    }
}
