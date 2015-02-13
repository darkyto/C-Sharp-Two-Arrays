using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Write a program that reads two integer numbers N and K and an array of N elements from the console.
 * 
 * Find in the array those K elements that have maximal sum.
 */

class MaximalKsum
 {
     static void Main()
     {
         Console.WriteLine("Enter N for number of elelennt in array :");
         int n = int.Parse(Console.ReadLine());
         Console.WriteLine("Enter K for the largest sum of K-elements in this array :");
         int k = int.Parse(Console.ReadLine());

         int[] arrayN = new int[n]; // creating an array with n elements

         int largestSum = 0;  // pre-declaring a variable for the accumulated final sum

         Console.WriteLine("Enter integer number for each N-element on different line");
         for (int i = 0; i < n; i++) // reading the values of each N-element
         {
             arrayN[i] = int.Parse(Console.ReadLine());
         }
         Array.Sort(arrayN); // After getting the values of each element NOW i am sorting the array with SORT()
                             // this will retunr the numbers sorted by the smallest at [0] to the largest at the end of the array
         Console.WriteLine("THe K-Elements forming the largest sum");
         for (int i = n-k; i < n; i++) // now I am using K to know which last (biggest) elements to count
         {
             largestSum += arrayN[i]; // suming each fo the biggest K-elements
             Console.Write(" {0} ", arrayN[i]);
         }
         Console.WriteLine();
         Console.WriteLine("The largest sum of K-Elements : {0}", largestSum);
     }
 }

