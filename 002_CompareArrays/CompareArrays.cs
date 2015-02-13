using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Write a program that reads two integer arrays 
 * from the console and compares them element by element.
 */

class CompareArrays
 {
     static void Main()
     {
         Console.WriteLine("Enter number of elements for Array ONE and Array TWO:");
         int lenght = int.Parse(Console.ReadLine());
         int[] arrayOne = new int[lenght];

         for (int i = 0; i < arrayOne.Length; i++)
         {
             Console.WriteLine("Array One - Enter element [{0}] :", i);
             arrayOne[i] = int.Parse(Console.ReadLine());
         }

         int[] arrayTwo = new int[lenght];
         for (int i = 0; i < arrayTwo.Length; i++)
         {
             Console.WriteLine("Array TWo - Enter element [{0}] :", i);
             arrayTwo[i] = int.Parse(Console.ReadLine());
         }
         Console.WriteLine();


         for (int i = 0; i < arrayOne.Length; i++)
         {
             if (arrayOne[i] == arrayTwo[i])
             {
                 Console.BackgroundColor = ConsoleColor.DarkGreen;
                 Console.WriteLine("ArrayONE - Elementt[{0}]  is equal to ArrayTWO - Element [{1}] ");
                 Console.BackgroundColor = ConsoleColor.Black;
             }
             else
             {
                 Console.BackgroundColor = ConsoleColor.DarkRed;
                 Console.WriteLine("ArrayONE - Elementt[{0}]  is NOT equal to ArrayTWO - Element [{1}] ");
                 Console.BackgroundColor = ConsoleColor.Black;
             }
         }

         //another solution 
         //if (arrayOne.Length == arrayTwo.Length)
         //{
         //    for (int i = 0; i < arrayOne.Length; i++)
         //    {
         //        if (arrayOne[i] == arrayTwo[i])
         //        {
         //            Console.WriteLine("Element[{0}] from Array One has value {1}\n"+
         //                               "and IS EQUAL to Element[{0}] with value {2} from Array Two",i , arrayOne[i] , arrayTwo[i]);
         //            Console.WriteLine();
         //        }
         //        else if (arrayOne[i] != arrayTwo[i])
         //        {
         //            Console.WriteLine("Element [{0}] from Array One has value {1}\n"+
         //                              " and is NOT equal to Element[{0}] with value {2} from Array Two", i, arrayOne[i], arrayTwo[i]);
         //            Console.WriteLine();
         //        }
         //    }
         //}

         Console.WriteLine();
         // alternative method with function .SequenceEqual
         Console.WriteLine("Is the sequence in arrayOne identical to the sequence in arrayTwo: {0}", arrayOne.SequenceEqual(arrayTwo));


         // Console.WriteLine(arrayOne.Equals(arrayTwo)); // this will return false for arrays
     }
 }

