using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Write a program that finds the most frequent number in an array.
 *  
 *   Example:
 * 
 *   input	                                    result
 *   4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3	    4 (5 times)
 */

class FrequentNumber
  {
      static void Main()
      {
          int[] numbers = { 7, 4, 7, 2, 4, 3, 7, 4, 7, 2, 7, 9, 3 ,4 ,2 ,2 ,2 };

          Console.WriteLine("Array before sort");
          foreach (var item in numbers)
          {
              Console.Write(" {0} ", item);
          }

          int count = 1;
          int maxCount = 1;
                                                                                //int maxValue = 0; // variable for the other test (commented below)
          int winnerNumber = 0;

          Console.WriteLine();
          Console.WriteLine("Array after sort");
          Array.Sort(numbers);                                                  // ok in this way i am sorting the array in increasing order
          foreach (var item in numbers)
          {
              Console.Write(" {0} ", item);
          }

          //counteg the most frequence member in a  sorted array
          for (int i = 0; i < numbers.Length; i++)                              // one loop to go through all the numbers one by one
          {
              if (i < numbers.Length -1 && numbers[i] == numbers[i+1])          // if we are within arrray AND current number is equal to next element
              {
                  count++;                                                      // counter ++
                  if (count > maxCount)                         
                  {
                      maxCount = count;                                         // the counter check and take the highest count 
                      winnerNumber = numbers[i];                                //when we see the highest count also take the winner number
                  }
              }
              else
              {                                                                 // else counter back to 1 (this is in the "outside" if ! )
                  count = 1;                                                    // I want this to change to 1 ony WHEN numbers[i] != numbers[i+1]
              }
          }
          Console.WriteLine();
          Console.Write("The number {0}", winnerNumber);
          Console.WriteLine(" has been seen {0} times int this sequence", maxCount);


          //for (int i = 0; i < numbers.Length; i++)
          //{
          //    maxValue = numbers[i];
          //    for (int j = 0; j < numbers.Length; j++)
          //    {
          //        if (maxValue == numbers[j] && j != i)
          //        {
          //            count++;

          //            if (count > maxCount)
          //            {
          //                maxCount = count;
          //                winnerNumber = numbers[i];
          //            }
          //        }
          //        else
          //        {
          //            count = 1;
          //        }
          //    }
          //}
          //Console.WriteLine(winnerNumber);
          //Console.WriteLine(maxCount);
      }
  }

