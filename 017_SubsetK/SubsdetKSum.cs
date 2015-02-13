using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Write a program that reads three integer numbers N, K and S and an array of N elements from the console.
 * 
 * Find in the array a subset of K elements that have sum S or indicate about its absence.
 * 
 */

class Program
{
    static void Main(string[] args)  // FULL DESCRIPTION OF THIS TASK YOU CAN FIND IN 016_SubsetSumS (here i have only added a counter for K-elements)
    {
        Console.WriteLine("Enter N for size of the numbers array :");
        int size = int.Parse(Console.ReadLine()); //reading N
        int[] numbers = new int[size];
        for (int i = 0; i < size; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine()); //readin N-elements of array
        }

        Console.WriteLine("You have given this array of numbers :"); // print and presentation of the numbers array
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write("{0,2}", numbers[i]);
        }
        Console.WriteLine();

        int totalPossibleSums = (int)Math.Pow(2, numbers.Length); 

        bool possibleSum = false; 

        Console.WriteLine("Enter S for subset sum to serach :");
        int sum = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter K for subset range of elements :");
        int subsetK = int.Parse(Console.ReadLine());

        int newSum = 0;
        int subsetCount = 0; // this will count our K elements forming the wanted sum
        Console.WriteLine("Find if there exists a subset of the elements of the array that has a sum {0}", sum);
        Console.WriteLine();

        for (int totalVariations = 1; totalVariations < totalPossibleSums; totalVariations++) 
        {
            newSum = 0;
            subsetCount = 0;
            string tempNumbers = Convert.ToString(totalVariations, 2).PadLeft(numbers.Length, '0'); 

            for (int currentNum = 0; currentNum < tempNumbers.Length; currentNum++) 
            {
                if (tempNumbers[currentNum].ToString() == "1") 
                {
                    newSum += numbers[currentNum];
                    subsetCount++; // the counter to count subsetElements forming the sum
                }
            }
            if (newSum == sum && subsetCount == subsetK) // the only difference is the counter condition here
            {                                            // in other word the boolean will com true only when
                possibleSum = true;                      // both newSum == sum AND counter == subset K (given by user)
                break;
            }          
        }
        if (possibleSum)
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("YES! O Yeeeeaass WE DO Have {0} elements forming the sum {1}", subsetK, sum);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine();
            Console.ReadLine();
        }
        else
        {
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("NOPE! No K elements forming The sum {0} or sum is NOT possible subset sum!", sum);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
