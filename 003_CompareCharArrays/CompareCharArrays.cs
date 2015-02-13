using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Write a program that compares two char arrays lexicographically (letter by letter).
 */

class CompareCharArrays
{
    static void Main()
    {
        char[] charArrayOne = { 'a', 'b', 'c', '@', '6' };          // declaring char array ONE and printingh it
        Console.WriteLine("This is example char array ONE :");
        foreach (char leter in charArrayOne)
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("{0,2}", leter);
            Console.BackgroundColor = ConsoleColor.Black;
        }
        Console.WriteLine(); // end ned print

        char[] charArrayTwo = { 'd', 'B', 'c', '@', '\\', '7' };          // declaring char array TWO and printing it
        Console.WriteLine("This is example char array TWO :");
        foreach (char leter in charArrayTwo)
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("{0,2}", leter);
            Console.BackgroundColor = ConsoleColor.Black;
        }
        Console.WriteLine(); //end print
        Console.WriteLine();

        CompareCharElement(charArrayOne, charArrayTwo); // calling the extracted method and giving the final result element by element


        // this below is the code for user defined char arrays (works for all characters)
        Console.WriteLine();
        Console.WriteLine("Enter your own char arrays to compare element by element");

        string userTempOne = Console.ReadLine();
        char[] userArrayOne = userTempOne.ToCharArray();
        Console.WriteLine("This are the chars in your FIRST array");
        foreach (char letter in userArrayOne)
        {
            Console.Write("{0,2}", letter);
        }
        Console.WriteLine();

        string userTempTwo = Console.ReadLine();
        char[] userArrayTwo = userTempTwo.ToCharArray();
        Console.WriteLine("This are the chars in your SECOND array");
        foreach (char letter in userArrayTwo)
        {
            Console.Write("{0,2}", letter);
        }
        Console.WriteLine();

        CompareCharElement(userArrayOne, userArrayTwo);
    }

    private static void CompareCharElement(char[] charArrayOne, char[] charArrayTwo)
    {
        for (int i = 0; i < charArrayOne.Length; i++)
        {
            for (int y = 0; y < charArrayTwo.Length; y++)
            {
                if (charArrayOne[i] == charArrayTwo[y])
                {
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("charArrayOne -element[{0}] is equal to charArrayTwo -element[{1}]", i, y);
                    Console.BackgroundColor = ConsoleColor.Black;
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("charArrayOne -element[{0}] is NOT equal to charArrayTwo -element[{1}]", i, y);
                    Console.BackgroundColor = ConsoleColor.Black;
                }
            }
        }



        //// compare by sorting by alphabet - MORE STRIC CHECK ONLY FOR ALPHABET LETTERS
        //for (int i = 0; i < charArrayOne.Length; i++)
        //{
        //    Console.WriteLine("ArrayOne - Element [{0}] = {1}", i , charArrayOne[i]);
        //}
        //Console.WriteLine();
        //for (int i = 0; i < charArrayTwo.Length; i++)
        //{
        //    Console.WriteLine("ArrayTwo - Element [{0}] = {1}", i, charArrayTwo[i]);
        //}
        //Console.WriteLine();

        //for (int i = charArrayOne.Length - 1; i >= 0 ; i--)
        //{
        //    if (charArrayOne[i] == charArrayTwo[i])
        //    {
        //        Console.WriteLine("ArrayOne - 0Element[{0}] is equal to ArrayTwo -Element [{0}]", i);
        //        Console.WriteLine("ArrayOne - 0Element[{0}] : {1}", i , charArrayOne[i]);
        //        Console.WriteLine("ArrayTwo - 0Element[{0}] : {1}", i, charArrayTwo[i]);
        //        Console.WriteLine();
        //    }
        //    else
        //    {
        //        Console.WriteLine("ArrayOne - 0Element[{0}] is NOT equal to ArrayTwo -Element [{0}]", i);
        //        Console.WriteLine("ArrayOne - 0Element[{0}] : {1}", i, charArrayOne[i]);
        //        Console.WriteLine("ArrayTwo - 0Element[{0}] : {1}", i, charArrayTwo[i]);
        //        Console.WriteLine();
        //    }
        //}
    }
}



