/*  Using loops write a program that converts an integer number to its binary representation. 
    The input is entered as long.
    The output should be a variable of type string.
    Do not use the built-in .NET functionality.
*/

using System;

class DecimalToBinary
{
    static void Main()
    {
        long number = long.Parse(Console.ReadLine());
        string binary = string.Empty;

        while (number > 0)
        {
            int residue = (int)(number % 2);
            number /= 2;
            binary = residue + binary;
        }
        Console.WriteLine(binary);
    }
}
