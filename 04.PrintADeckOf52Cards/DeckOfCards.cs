/*  Write a program that generates and prints all possible cards from a standard deck of 52 cards (without the jokers). 
    The cards should be printed using the classical notation (like 5♠, A♥, 9♣ and K♦). 
    The card faces should start from 2 to A. 
    Print each card face in its four possible suits: clubs, diamonds, hearts and spades. 
    Use 2 nested for-loops and a switch-case statement. */

using System;

class DeckOfCards
{
    static string GetType(int value)
    {
        string card = string.Empty;
        switch (value)
        {
            case 11: card = "J"; break;
            case 12: card = "Q"; break;
            case 13: card = "K"; break;
            case 14: card = "A"; break;
        }
        return card;
    }

    static void Printing(string cards)
    {
        for (int j = 5; j >= 3; j--)
        {
            Console.Write("{0,3}{1} ", cards, (char)j);
            if (j == 3)
            {
                Console.WriteLine("{0,3}{1}", cards, (char)(j * 2));
            }
        }
    }

    static void Main()
    {
        string cards = string.Empty;

        for (int i = 2; i <= 14; i++)
        {
            if (i <= 10)
            {
                cards = i.ToString();
            }
            else
            {
                cards = GetType(i);
            }
            Printing(cards);
        }
    }
}
