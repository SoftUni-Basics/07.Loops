/*  You are given n integers (given in a single line, separated by a space). 
    Write a program that checks whether the product of the odd elements is equal to the product of the even elements. 
    Elements are counted from 1 to n, so the first element is odd, the second is even, etc.
*/

using System;
using System.Linq;

class OddAndEvenProduct
{
    static void Main()
    {
        Console.WriteLine("Enter integers separated by a space:");
        int[] values = Console.ReadLine().Split().Select(int.Parse).ToArray();

        int odd = 1;
        int even = 1;
        for (int i = 0; i < values.Length; i++)
        {
            if (i % 2 == 0)
            {
                odd *= values[i];
            }
            else
            {
                even *= values[i];
            }
        }
        if (odd == even)
        {
            Console.WriteLine("yes");
            Console.WriteLine("product = {0}", odd);    
        }
        else
        {
            Console.WriteLine("no");
            Console.WriteLine(" odd_product = {0}", odd);
            Console.WriteLine("even_product = {0}", even);
        }
    }
}
