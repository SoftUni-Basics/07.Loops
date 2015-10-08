/*  Using loops write a program that converts a binary integer number to its decimal form. 
    The input is entered as string. 
    The output should be a variable of type long. 
    Do not use the built-in .NET functionality.
*/

using System;

class BinaryToDecimal
{
    static void Main()
    {
        string binString = Console.ReadLine();
        long decResult = 0;

        int index = 0;
        for (int i = binString.Length - 1; i >= 0; i--)
        {
            int bit = binString[i] % 2;
            if (bit == 1)
            {
                decResult += 1 << index;
            }
            index++;
        }
        Console.WriteLine(decResult);
    }
}
