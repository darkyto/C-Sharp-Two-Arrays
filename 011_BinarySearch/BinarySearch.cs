using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Write a program that finds the index of given element in 
 * a sorted array of integers by using the Binary search algorithm.
 */

class BinarySearch
{
    static void Main()
    {
        Console.WriteLine("Enter the lenght of the array :");
        int sizeArray = int.Parse(Console.ReadLine());
        int[] listNUms = new int[sizeArray];

        Console.WriteLine("Enter {0} numbers for the members of the array", sizeArray);
        for (int i = 0; i < listNUms.Length; i++)
        {
            listNUms[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("This is our unsorted list");
        foreach (int digit in listNUms)
        {
            Console.Write(" {0} ", digit);
        }
        Console.WriteLine();

        Array.Sort(listNUms);
        Console.WriteLine("This is our Sorted list");
        foreach (int digit in listNUms)
        {
            Console.Write(" {0} ", digit);
        }
        Console.WriteLine();

        Console.WriteLine("Enter a value from the list to get its index");
        int n = int.Parse(Console.ReadLine());

        int min = 0;
        int max = listNUms.Length;
        int index = BinarySearchIterative(listNUms, n, min, max);  // full description of this extraxted method you will find below
        if (index > -1) // final check 
        {
            Console.WriteLine("Value {0} is last seen at position/Index [{1}]", n , index-1);
        }
        else  // if n is not in the array then this
        {
            Console.WriteLine("Value not found int the array or wrong data input!");
        }


    }

    public static int BinarySearchIterative(int[] inputArray, int n, int min, int max)
    {
        while (min <= max)    // start the loop and check if min is lower or equal to max
        {
            int mid = (min + max) / 2;  // declare middle - the center
            if (n == inputArray[mid])  // if wanted number is == the middle position in the wanted array
            {
                return ++mid;           // return + incerase middle with one 
            }
            else if (n < inputArray[mid]) // if number is lower then the middle value
            {
                max = mid - 1;          // max is going down to middle-1 and the loops goes on
            }
            else if (n > inputArray[mid] )
            {
                min = mid + 1;          // the same as above but in the opposite direction
            }
        }
        return -1; // offset result
    }
}

//int index = Array.BinarySearch(listNUms, n);

//if (index > -1 )
//{
//    Console.WriteLine("Number is {0} and its index is [{1}]", n, index);
//}
//else
//{
//    Console.WriteLine("No such value found in the array!");
//}
