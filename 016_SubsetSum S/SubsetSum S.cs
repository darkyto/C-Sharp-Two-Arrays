using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * We are given an array of integers and a number S.
 * Write a program to find if there exists a subset of the elements of the array that has a sum S.
 * Example:

        input array	                S	    result
        2, 1, 2, 4, 3, 5, 2, 6	    14	    yes
 */

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 2, 1, 2, 4, 3, 5, 2, 6 };

        Console.WriteLine("We are given an array of numbers :"); // print and presentation of the numbers array
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write("{0,2}", numbers[i]);
        }
        Console.WriteLine();

        int totalPossibleSums = (int)Math.Pow(2, numbers.Length); // pre-decalring this neat math trick is to go through all possible sums
        
        bool possibleSum = false; // this will be the indicator which will be set to true once a possible sum is foudn

        Console.WriteLine("Enter S for subset sum to serach :");
        int sum = int.Parse(Console.ReadLine());
        int newSum = 0; // pre-declare variable for the new value of accumulated subset sums
        Console.WriteLine("Find if there exists a subset of the elements of the array that has a sum {0}", sum);
        Console.WriteLine();
    
        for (int totalVariations = 1; totalVariations < totalPossibleSums ; totalVariations++) // first loop up to Math.Pow.... to go thorugh ALL possible sums
        {
            newSum = 0; // for each new combinations of sums we are stsrting the calculation from the beggining
            string tempNumbers = Convert.ToString(totalVariations, 2).PadLeft(numbers.Length, '0'); // this is the KEY - using convertion to binary num in string

            for (int currentNum = 0; currentNum < tempNumbers.Length; currentNum++) // second inner loop to go through the binary number bit by bit
            {
                if (tempNumbers[currentNum].ToString() == "1") // if the current symbol is 1 in the binary temmpNumber
                {
                    newSum += numbers[currentNum]; // our new sum is summed with the value of the current number                   
                }
            }
            if (newSum == sum) // if both sums are equal set the boolen variable to TRUE and the task is ready
            {
                possibleSum = true;
                break; // to prevent further looping after we already have the final confirmation
            }          // however if we want to count ALL possible subset sums that are equal to the searched sum we can add a counter insted of break!
        }
        if (possibleSum) // results
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Yes the sum {0} is possible subset sum!", sum);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine();
            Console.ReadLine();
        }
        else
        {
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("The sum {0} is NOT possible subset sum!", sum);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}

