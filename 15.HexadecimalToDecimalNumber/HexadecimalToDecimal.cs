/*  Using loops write a program that converts a hexadecimal integer number to its decimal form.
    The input is entered as string.
    The output should be a variable of type long.
    Do not use the built-in .NET functionality.     */

using System;

class HexadecimalToDecimal
{
    static void Main()
    {
        Console.Write("Enter Hexadecimal value:  ");
        string input = Console.ReadLine();
        long decResult = 0;
        int degree = 0;

        for (int i = input.Length - 1; i >= 0; i--)
        {
            int curentNumber = GetCharValue(input[i].ToString().ToUpper());
            if (curentNumber != -1)
            {
                decResult += curentNumber * PowValue(degree);
            }
            else
            {
                Console.WriteLine("Incorect value -> {0}", input[i]);
                return;
            }
            degree++;
        }
        Console.WriteLine("{0,-24}  {1}\r\n", "Decimal result:", decResult);
    }

    static long PowValue(int degree)
    {
        long value = 1;
        if (degree > 0)
        {
            for (int i = 1; i <= degree; i++)
            {
                int pow = 16;
                value *= pow;
            }
        }
        else
        {
            return 1;
        }
        return value;
    }

    static int GetCharValue(string ch)
    {
        int value = -1;
        switch (ch)
        {
            case "0": value = 0; break;
            case "1": value = 1; break;
            case "2": value = 2; break;
            case "3": value = 3; break;
            case "4": value = 4; break;
            case "5": value = 5; break;
            case "6": value = 6; break;
            case "7": value = 7; break;
            case "8": value = 8; break;
            case "9": value = 9; break;
            case "A": value = 10; break;
            case "B": value = 11; break;
            case "C": value = 12; break;
            case "D": value = 13; break;
            case "E": value = 14; break;
            case "F": value = 15; break;

            default: value = -1; break;
        }
        return value;
    }
}
