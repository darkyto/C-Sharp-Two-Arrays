using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Write a program that allocates array of 20 integers and initializes each element by its index multiplied by 5.
 * Print the obtained array on the console.
 * 
 */

class AllocateArray
 {
     static void Main()
     {
         int[] myNewArray = new int[20];


         for (int i = 0; i < myNewArray.Length; i++)
         {
             myNewArray[i] = i * 5;
             if (i*5 < 10)
             {
                 Console.Write("{0,2}", myNewArray[i]);
             }
             else
             {
                 Console.Write("{0,3}", myNewArray[i]);
             }
         }
         Console.WriteLine();
     }
 }

