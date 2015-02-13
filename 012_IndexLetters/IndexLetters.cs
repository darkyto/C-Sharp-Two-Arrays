using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Write a program that creates an array containing all letters from the alphabet (A-Z).
 * Read a word from the console and print the index of each of its letters in the array.
 */

class IndexLetters
{
    static void Main(string[] args)
    {
        char[] alphabet = new char[26];  // creating an array for the upper case Alphabet

        int start = 65;  // this number refers to the ASCII table position (see google ' ASCII table ')

        for (int i = start; i < start + alphabet.Length; i++) // inserting the UPPER case ALPHABET (A-Z) in the array
        {
            alphabet[i - 65] = (char)i;
        }

        foreach (var letter in alphabet) // printing the alphabet just for test
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write(" {0} ", letter);
            Console.BackgroundColor = ConsoleColor.Black;
        }
        Console.WriteLine();


        Console.WriteLine("ENter an word to find each index of each letter in the A-Z alphabet");
        string userWord = Console.ReadLine().ToUpper(); // USER WORD to proceed with

        foreach (char letter in userWord) // for test remove later
        {
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.Write("The index of letter {0} is [{1}]\n", letter , (int)letter - (int)'A');
            Console.BackgroundColor = ConsoleColor.Black;
        }


        userWord = userWord.ToLower(); // to lower casing - afded code for test
        Console.WriteLine("However if we use lower casing I will have to trick the array..");

        for (int i = 0; i < userWord.Length; i++)
        {
            for (int y = 0; y < alphabet.Length; y++)
            {
                if ((int)alphabet[y] == userWord[i] -32 )
                {
                    Console.Write("The index of letter {0} is [{1}]\n", userWord[i], (int)alphabet[y] - 65);
                }
            }
        }


    }
}

