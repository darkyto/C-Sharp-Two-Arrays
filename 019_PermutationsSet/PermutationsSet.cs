using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Write a program that reads a number N and generates and prints all the permutations of the numbers [1 … N].
                Example:

                N	result
                3	{1, 2, 3} 
                    {1, 3, 2} 
                    {2, 1, 3} 
                    {2, 3, 1} 
                    {3, 1, 2} 
                    {3, 2, 1}    
 */

class PermutationsSet
{
    static int count; // ok so that might be a bit of a cheating but still... a global counter for the total sum of permutation pre-declared

    static void Main(string[] args) // WORKING PERMUTATIONS for both numbers and other symbols 
    {
        Console.WriteLine("Enter a sequence of numbers (example : 1234 or abcDEF) to permutate :");
        string userChoice = Console.ReadLine();
        Console.WriteLine();
        char[] numsToChar = new char[userChoice.Length];//new char[] { '1', '2', '3' };

        for (int i = 0; i < numsToChar.Length; i++) // filling the char array with pur user difined elements 
        {                                           // this method will accept every symbol not only numbers
            numsToChar[i] = userChoice[i];
        }

        Console.BackgroundColor = ConsoleColor.DarkRed;
        AllPermutations(String.Empty, numsToChar); // final result - using string.Emptu because this argument is no longer needed
        Console.BackgroundColor = ConsoleColor.Black;
        Console.WriteLine();
        Console.BackgroundColor = ConsoleColor.Red;
        Console.WriteLine("We have found {0} permutations!", count); // using the counter to present the number of total permutations
        Console.BackgroundColor = ConsoleColor.Black;
        Console.WriteLine();
    }
    static void AllPermutations(string permutation, char[] arrayPermut)  // method with pre-decalered empty string and char array as arguments
    {
        if (arrayPermut.Length == 1)
        {
            Console.Write("{0,10}", permutation + arrayPermut[0]); // when the swap array is == 1 then print the permutaion and start again
            count++; // counter for bonus interactivity added

            if (permutation.Length > 2 && count % 5 == 0) // just for formating the output - not important for the logic
            {
                Console.Write("\n");
            }
            return;
        }
        for (int i = 0; i < arrayPermut.Length; i++)
        {
            char originalCharElement = arrayPermut[i]; // assigning the curret value of sthe char-array element to n

            string newPermutation = permutation + originalCharElement; // this will asssing the current char ot its eqivalient string lvalue without the not needed char value

            char[] subset = new char[arrayPermut.Length - 1]; // declaring the subset array with the two values which we will swap later

            int j = 0; // counter for the subset array

            for (int k = 0; k < arrayPermut.Length; k++)
            {
                if (arrayPermut[k] != originalCharElement) // if the element arrayPermut[k] from the original set is not equal to arrayPermut[i].. (which means we will swap only different values)
                {
                    subset[j++] = arrayPermut[k]; // then make the swap
                }
            }
            AllPermutations(newPermutation, subset); // the final creatinon of each permutation!
        }                                            // for example if we have input = 123 (and first base permutation)  after condition first if=true
    }                                                // we will have the    newPermuation = 1 and subset[] = {3 , 2}
}                                                    // which will gave a permuattion 1 , 3 , 2 ;
                                                     // after that using recursive technique - we are feeding the same method with the
                                                     // new values of newPermutation (int the case above = 1) and with the new array {3,2};
                                                     // at LAST when the recursive array is == 1 we will go to the return code above (line 37)