/*  Using loops write a program that converts an integer number to its hexadecimal representation.
    The input is entered as long.
    The output should be a variable of type string.
    Do not use the built-in .NET functionality
*/

using System;

class DecimalToHexadecimal
{
    static void Main()
    {
        Console.Write("Enter integer value:  ");
        long value = long.Parse(Console.ReadLine());
        string hexa = string.Empty;

        while (value > 0)
        {
            int residue = (int)(value % 16);
            value /= 16;
            hexa = GetCharValue(residue) + hexa;
        }
        Console.WriteLine("{0,-20}  {1}", "Hexadecimal result:", hexa);
    }

    static string GetCharValue(int ch)
    {
        string value = string.Empty;
        switch (ch)
        {
            case 0: value = "0"; break;
            case 1: value = "1"; break;
            case 2: value = "2"; break;
            case 3: value = "3"; break;
            case 4: value = "4"; break;
            case 5: value = "5"; break;
            case 6: value = "6"; break;
            case 7: value = "7"; break;
            case 8: value = "8"; break;
            case 9: value = "9"; break;
            case 10: value = "A"; break;
            case 11: value = "B"; break;
            case 12: value = "C"; break;
            case 13: value = "D"; break;
            case 14: value = "E"; break;
            case 15: value = "F"; break;
        }
        return value;
    }
}
