using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Write a program that finds the maximal increasing sequence in an array.
 * Example:

        input	                    result
        3, 2, 3, 4, 2, 2, 4	        2, 3, 4
 */

class MaximalSequence
{
    static void Main(string[] args)
    {

        int[] sequenceNums = { 3, 2, 3, 4, 2, 2, 4 };

        int count = 0;

        Console.WriteLine("Sequence nums");
        foreach (var nums in sequenceNums)
        {
            Console.Write(" {0}", nums);
            count++;
            if (count != 7)
            {
                Console.Write(",");
            }
        }
        Console.WriteLine();
        // end of the input part

        // start of the logic part
        IncreasingSequence(sequenceNums); // detailed description of my method you can find below 
        // edn of Logic part (see the code of the method for more info)

         //some bonus code for user testing

        // this is a bonus code
        Console.WriteLine();
        int[] userArrayTest = new int[10];
        Console.WriteLine("Enter TEN elements in new array to test increasing elements method :");
        for (int i = 0; i < 10; i++)
        {
            userArrayTest[i] = int.Parse(Console.ReadLine());
        }
        IncreasingSequence(userArrayTest); // FIXED now it works with zeroes and for whole array sequences
    }

    private static void IncreasingSequence(int[] sequenceNums)
    {
        int sequenceCount = 1;  //declaring the temp counter
        int maxSequenceCount = 0; // declaring the storage for the maximum counter
        int startMaxSequence = 0; // declaring the variable for the start place of the sequence

        for (int i = 0; i < sequenceNums.Length - 1; i++)
        {
                if (sequenceNums[i] == sequenceNums[i + 1] - 1)
                {
                    sequenceCount++;
                }
                else
                {
                    sequenceCount = 1;
                }
                if (sequenceCount > maxSequenceCount)
                {
                    maxSequenceCount = sequenceCount;
                    startMaxSequence = i + 1 - maxSequenceCount;
                }
        }

        if (maxSequenceCount > 1)
        {
            Console.WriteLine("The largest increasing sequence is :");
            for (int i = startMaxSequence + 1; i < startMaxSequence + 1 + maxSequenceCount; i++) //start from the first ncreasing member.. goest to the last
            {
                Console.Write("{0}", sequenceNums[i]);
                if (i != startMaxSequence + maxSequenceCount ) // another way of removing the last ',' in the console string
                {
                    Console.Write(",");
                }
            }
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("No increasing values int this sequence!");
        }
    }
}

