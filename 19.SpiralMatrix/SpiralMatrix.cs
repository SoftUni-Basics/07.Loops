/*  Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20)
    and prints a matrix holding the numbers from 1 to n*n in the form of square spiral.
*/

using System;

class SpiralMatrix
{
    static bool CheckField(int size, int[,] matrix, int row, int col)
    {
        bool field = (0 <= col && col < size) && (0 <= row && row < size) && matrix[row, col] == 0;
        return field;
    }

    static void Main()
    {
        int size;
        while (true)
        {
            Console.Clear();
            Console.Write("Enter value (1 <= n <= 20): ");
            string input = Console.ReadLine();
            bool checkInput = int.TryParse(input, out size) && (1 <= size && size <= 20);
            if (checkInput)
            {
                break;
            }
        }

        int[,] matrix = new int[size, size];
        int counter = 1;
        int row = 0, col = 0;
        
        while (counter <= (size*size))
        {
            while (CheckField(size, matrix, row, col))
            {
                matrix[row, col] = counter;
                counter++;
                col++;
            }
            col--;
            row++;
            while (CheckField(size, matrix, row, col))
            {
                matrix[row, col] = counter;
                counter++;
                row++;
            }
            row--;
            col--;
            while (CheckField(size, matrix, row, col))
            {
                matrix[row, col] = counter;
                counter++;
                col--;
            }
            col++;
            row--;
            while (CheckField(size, matrix, row, col))
            {
                matrix[row, col] = counter;
                counter++;
                row--;
            }
            row++;
            col++;
        }

        int lng = (size * size).ToString().Length + 1;
        for (int r = 0; r < matrix.GetLength(0); r++)
        {
            for (int c = 0; c < matrix.GetLength(1); c++)
            {
                Console.Write("{0}", matrix[r, c].ToString().PadLeft(lng, ' '));
            }
            Console.WriteLine();
        }
    }
}
