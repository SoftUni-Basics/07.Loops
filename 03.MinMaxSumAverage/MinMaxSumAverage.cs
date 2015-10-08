/*  Write a program that reads from the console a sequence of n integer numbers 
 * and returns the minimal, the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point). 
 * The input starts by the number n (alone in a line) followed by n lines, each holding an integer number. 
 * The output is like in the examples below.
*/

using System;

class MinMaxSumAverage
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

        decimal min = 0, max = 0, sum = 0;

        for (int i = 1; i <= number; i++)
        {
            Console.Write("No {0}:  ", i);
            decimal temp = decimal.Parse(Console.ReadLine());
            if (i > 1)
            {
                if (min > temp)
                {
                    min = temp;
                }
                if (max < temp)
                {
                    max = temp;
                }
            }
            else
            {
                min = temp;
                max = temp;
            }
            sum += temp;
        }
        Console.WriteLine("Min = {0}", min);
        Console.WriteLine("Max = {0}", max);
        Console.WriteLine("Sum = {0}", sum);
        if (sum != 0)
        {
            Console.WriteLine("Average = {0:F}", (decimal)sum / number);
        }
        else
        {
            Console.WriteLine("Average = {0:F}", sum);
        }
    }
}
