using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Write a program that sorts an array of strings using the Quick sort algorithm.
 */

namespace Quicksort
{
    class Program
    {
        static void Main(string[] args)
        {
            // unsorted array of integeres
            int[] unsorted = { 5 , 4 ,12 ,17 ,0 , 125 ,137 ,52 ,69 };

            // test print the unsorted array
            Console.WriteLine("Unsorted array below:");
            for (int i = 0; i < unsorted.Length; i++)
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.Write(unsorted[i] + " ");
                Console.BackgroundColor = ConsoleColor.Black;
            }

            Console.WriteLine();
            Console.WriteLine();

            // Sort the array - here we call our Quicksort method
            Quicksort(unsorted, 0, unsorted.Length - 1);  // array , start (0) , end (array.Lenght - 1)

            // Print the sorted array
            Console.WriteLine("Quick sort algo below :");
            for (int i = 0; i < unsorted.Length; i++)
            {
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.Write(unsorted[i] + " ");
                Console.BackgroundColor = ConsoleColor.Black;
            }

            Console.WriteLine();
            Console.WriteLine();
        }

        public static void Quicksort(int[] elements, int left, int right)  // this is the Quicksort method
        {
            int i = left, j = right;  // declaring short variables for both parts which will be used in the algorhithm
            int pivot = elements[(left + right) / 2];  // declaring the pivot

            while (i <= j)  // while left <= right
            {
                while (elements[i].CompareTo(pivot) < 0)  // compare is LEFT to PIVIT < 0
                {
                    i++; // increasing LEFT
                }

                while (elements[j].CompareTo(pivot) > 0) // the same opreation for the RIGHT part
                {
                    j--;
                }

                if (i <= j) // IF left <= right
                {
                    // Swap
                    int tmp = elements[i];
                    elements[i] = elements[j];
                    elements[j] = tmp;

                    i++; // increase LEFt
                    j--; //decrease RIGHT
                }
            }

            // Recursive calls until the final result is achived
            if (left < j)
            {
                Quicksort(elements, left, j);
            }

            if (i < right)
            {
                Quicksort(elements, i, right);
            }
        }

    }
}

