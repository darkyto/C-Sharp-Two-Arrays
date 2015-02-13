using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Write a program that sorts an array of integers using the Merge sort algorithm.
 */

class MergeSort
{
    static List<int> MergeCustom(List<int> listOriginal)
    {

        if (listOriginal.Count <= 1)
        {
            return listOriginal;
        }
        List<int> left = new List<int>();
        List<int> right = new List<int>();

        int width = listOriginal.Count / 2;

        for (int i = 0; i < width; i++)
        {
            left.Add(listOriginal[i]);
        }
        for (int i = width; i < listOriginal.Count; i++)
        {
            right.Add(listOriginal[i]);
        }

        left = MergeCustom(left);
        right = MergeCustom(right);
        return Merge(left, right);
    }

    static List<int> Merge(List<int> left, List<int> right)
    {
        List<int> finalREsult = new List<int>();

        while (left.Count > 0 || right.Count > 0)
        {
            if (left.Count > 0 && right.Count > 0)
            {
                if (left[0] < right[0])
                {
                    AddAndRemove(left, finalREsult);
                }
                else
                {
                    AddAndRemove(right, finalREsult);
                }

            }
            else if (left.Count > 0)
            {
                AddAndRemove(left, finalREsult);
            }
            else
            {
                AddAndRemove(right, finalREsult);
            }
        }
        return finalREsult;
    }

    private static void AddAndRemove(List<int> removeFrom, List<int> addTo)
    {
        addTo.Add(removeFrom[0]);
        removeFrom.RemoveAt(0);
    }
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

        List<int> listOriginal = new List<int>(listNUms);
        foreach (int i in MergeCustom(listOriginal))
        {
            Console.Write(" {0} ",i);
        }
    }
}

