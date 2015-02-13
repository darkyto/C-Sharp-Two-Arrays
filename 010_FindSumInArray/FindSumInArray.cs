using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Write a program that finds in given array of integers a sequence of given sum S (if present).
 *  Example:
    
    array	                S	    result
    4, 3, 1, 4, 2, 5, 8 	11	    4, 2, 5
 * 
 *  
 * 
 */

class FindSumInArray
  {
      static void Main()
      {
          int[] numbersArray = {  7 , 4, 3, 1, 4, 2, 5, 8 , 7 , 3 , 1 }; 
          Console.WriteLine("Numbers in array");
          Console.BackgroundColor = ConsoleColor.DarkGreen;
          foreach (var item in numbersArray)
          {
              Console.Write(" {0} ", item);
          }
          Console.BackgroundColor = ConsoleColor.Black;
          Console.WriteLine();

          int sum = 11;
          int foundSum = 0;
          int count = 0;

          Console.WriteLine();
          for (int i = 0; i < numbersArray.Length; i++)     // ok start with the Outside loopto go number by number
          {
              for (int y = i; y < numbersArray.Length; y++) // now take the fist number 
              {
                  foundSum += numbersArray[y];              // ADD its value to foundSum
                  if (foundSum == sum)                      ///check if foundSUm is already equal to wanted sum (S)
                  {
                      Console.WriteLine(" Sub-sequence in the array with SUM = {0}", sum);
                      Console.BackgroundColor = ConsoleColor.DarkMagenta;
                      for (count = i; count <= y; count++)  // if YES then use this loop to print the members of the sequence right away
                      {
                          Console.Write(" {0} ", numbersArray[count]);
                      }
                      Console.BackgroundColor = ConsoleColor.Black;
                      Console.WriteLine();
                  }
                  else // if not go out of the loop to prevent some pointless looping
                  {
                      continue;
                  }
              }

              foundSum = 0; // IMPORTANT - after the Y loop is done I will makee foundSum = 0 and start again calculating for the number at the next position.. 4..then for 3 to the end...
          }                 // this should be in the first loop so we can start with clean variable each time a number is taken
      }
  }

