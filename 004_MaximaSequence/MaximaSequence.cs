using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Write a program that finds the maximal sequence of equal elements in an array.
 * Example:

    input	                                result
    2, 1, 1, 2, 3, 3, 2, 2, 2, 1            2, 2, 2
 * 
 * 
 */

class MaximaSequence
{
    static void Main()
    {
        int[] sequence = { 2, 1, 1, 2, 3, 3, 2, 2, 2, 1, 4, 5, 1, 8, 8, 8, 8, 0, 4, -4, -4, -2 };

        Console.WriteLine("Our example integer array");
        foreach (int num in sequence)
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("{0,3}", num);
            Console.ResetColor();
        }
        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("This is the best sub-sequence of equal elements");
        Console.BackgroundColor = ConsoleColor.DarkRed;
        EqualElementsSequence(sequence); // extracted method with thorough explanation below and some bonus part 
        Console.ResetColor();

        //// this is a bonus code
        //Console.WriteLine();
        //int[] userArrayTest = new int[5];
        //Console.WriteLine("Enter FIVE elements in new array to test equal elements method :");
        //for (int i = 0; i < 5; i++)
        //{
        //    userArrayTest[i] = int.Parse(Console.ReadLine());
        //}
        //EqualElementsSequence(userArrayTest);
    }

    private static void EqualElementsSequence(int[] sequence)
    {

        int subSequenceStart = 0;
        int bestCount = 1;
        int countMax = 1;

        for (int i = 1; i < sequence.Length; i++)
        {
            if (sequence[i-1] == sequence[i])
            {
                bestCount++;
            }
            else
            {
                bestCount = 1;
            }
            if (bestCount > countMax)
            {
                countMax = bestCount;
                subSequenceStart = i - 1;
            }
        }

        for (int i = subSequenceStart; i < subSequenceStart + countMax; i++)
        {
            Console.Write("{0,2}",sequence[subSequenceStart]);
        }
        Console.WriteLine();



        //TEST CODE FOR CASE WHEN TWO EVEN Sub-SEQUENCES are Present!

        //// OK so i made my own method which will not only 
        //// count the most large sequence of equal valued elements
        //// but also will print two sequence if there are more then one 
        //// sequence with large amaount fo elements (for exmaple 11,11,22,22,79 will retunr 11,11 and 22,22)

        //int count = 0;     // the basic counter to count equal members
        //int countMax = 0; // will use this to compate counters]
        //int countMax2 = 0;

        //int sequenceEqualsEnd = 0;
        //int sequenceEqualsEndTwo = 0;

        //for (int i = sequence.Length - 1; i >= 1; i--) // loop up to greater/equal to ONE(1) because i am comparing elements in revers order
        //{                                              // and the last comaprision will be sequence[1] == sequence[0] 
        //    if (sequence[i] == sequence[i - 1])
        //    {
        //        count++; // increasse the count if the neighbour elements do have equal values
        //    }
        //    else
        //    {
        //        count = 1; // if two neighbour elements are not with equal values makae count 1 and start counting again
        //    }

        //    if (count > countMax)  // ok this will store the temp COUNT to the countMax variable 
        //    {                      // and once countMax is greater then count it wont change so it will store the biggest possible sequence of equal elements
        //        countMax = count;  // after that I am using this countMax to know when to stop the for loop of printing (look below)
        //        sequenceEqualsEnd = i - 1;
        //    }
        //    else if (count == countMax && count > 1)
        //    {
        //        countMax2 = count;
        //        sequenceEqualsEndTwo = i - 1;
        //    }
        //}
        //Console.WriteLine();
        //if (countMax2 < 1)
        //{
        //    for (int i = sequenceEqualsEnd; i < sequenceEqualsEnd + countMax; i++)  // printing the sequence of equal members
        //    {
        //        Console.Write(sequence[sequenceEqualsEnd] + ", ");
        //    }
        //}
        //else if (countMax2 >= 1)
        //{
        //    for (int i = sequenceEqualsEnd; i < sequenceEqualsEnd + countMax; i++)  // printing the sequence of equal members
        //    {
        //        Console.Write(sequence[sequenceEqualsEnd] + ", ");
        //    }
        //    Console.WriteLine();
        //    for (int i = sequenceEqualsEndTwo; i < sequenceEqualsEndTwo + countMax; i++)  // printing the sequence of equal members
        //    {
        //        Console.Write(sequence[sequenceEqualsEndTwo] + ", ");
        //    }
        //}

    }
}

