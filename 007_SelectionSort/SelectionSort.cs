using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
 * 
 * Use the Selection sort algorithm: Find the smallest element, move it at the first position, 
 * find the smallest from the rest, move it at the second position, etc.
 * 
 */
class SelectionSort
 {
     static void Main()
     {
         int[] arrayManualSort = { 99, 0 , 124, 37, -14 };
         Console.WriteLine("The array before manual sorting by elemtns :");
         for (int i = 0; i < arrayManualSort.Length; i++)
         {
             Console.Write(" {0} ", arrayManualSort[i]);
         }
         Console.WriteLine();

         int minimalValue; // this will be used to store the current numinal value
         int tempValue;    // this wil be my temp storage

         for (int i = 0; i < arrayManualSort.Length - 1; i++)  // starting the "outside" loop to read each number and store the value in minimal value
         {
             minimalValue = i;
             for (int j = i + 1; j < arrayManualSort.Length; j++)  // starting the "inside" loop from i+1 (comparing the previous number with the one from this loop)
             {
                 if (arrayManualSort[j] < arrayManualSort[minimalValue]) // ii the number from the inside loop is smaller then the outside loop number
                 {
                     minimalValue = j;                                  // then make minimal value = j (inside number value)
                 }
                 tempValue = arrayManualSort[i];                        // the three step classic swap - temp takes the value of the outside loop
                 arrayManualSort[i] = arrayManualSort[minimalValue];    // making the outside loop number takes the minimal value
                 arrayManualSort[minimalValue] = tempValue;             // now swaping the minimal value with ur temp storage variable
             }                                                          // CLASSIC SWAP TECHNIQUE of VARIBLE VALUES - USE USE USE
         }
         Console.WriteLine("AFTER manual sorting by elemtns :");
         for (int i = 0; i < arrayManualSort.Length; i++)
         {
             Console.Write(" {0} ", arrayManualSort[i]);  // result
         }
         Console.WriteLine();
     }
 }

