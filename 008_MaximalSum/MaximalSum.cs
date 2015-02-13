using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Write a program that finds the sequence of maximal sum in given array.
 *                      Example:

    input	                            result
    2, 3, -6, -1, 2, -1, 6, 4, -8, 8	2, -1, 6, 4
 */

class MaximalSum
{
    static void Main()
    {
        int[] numbers = { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 }; // pre-difined values - tested and works with user interface as well

        Console.WriteLine(new string('-', 10));
        Console.WriteLine("Our array");
        Console.WriteLine(new string('-', 10));
        foreach (var item in numbers) // start print input
        {
            Console.Write(" {0} ", item);
        }
        Console.WriteLine(); // end printing input
        Console.WriteLine();

        //logic code start
        int currentSum = 0;  // temp variable for current sum
        int largestSum = 0;  // the biggest sum in the sequence


        int startMaxSequence = 0; //where is the first member in the largestSUm sequence
        int endSequence = 1;      // how many members are making the sequence - and then use this to know when to stop in the final loop
            

        for (int i = 0; i < numbers.Length; i++)
        {
            currentSum += numbers[i]; // making the calculation for the temp sum of numbers

            if (largestSum > largestSum + numbers[i]) // check if the largest sum until now is bigger then its value + current i (will return false if number is negative)
            {
                startMaxSequence++; // if yes - add count to start sequence 
                if ( i < numbers.Length - 1 && numbers[i+1] >=0) // now check if i is wthin array - 1 (because you are checking pair of numbs)
                {                                                // and also check if the next number is bigger then 0 (meaning it will contunie the sequence)
                    endSequence++; // add a count to know how many members the sequence of largest sum do have...
                }
            }

            if (currentSum > largestSum) // if....
            {
                largestSum = currentSum; // asign the larger value to the largestSum variavble
            }
            else if (currentSum < 0) // if current is lower then 0
            {
                currentSum = 0; // assing 0 value to the current
            }

        }
        Console.WriteLine(new string('-', 56));
        Console.WriteLine("The elements values with largest sum in the sequence :");
        Console.WriteLine(new string('-', 56));
        for (int i = startMaxSequence; i < startMaxSequence + endSequence; i++)  // strats... ends after start+ num of members
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write(" {0} ", numbers[i]);
            Console.BackgroundColor = ConsoleColor.Black;
        }


        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine(new string ('-', 25) );
        Console.WriteLine("Total sum of elements :");
        Console.WriteLine(new string('-', 25));
        Console.WriteLine(largestSum);
        Console.WriteLine();
    }
}

