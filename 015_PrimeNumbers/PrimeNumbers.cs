using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Write a program that finds all prime numbers in the range [1...10 000 000]. Use the Sieve of Eratosthenes algorithm. 
 */


class PrimeNumbers
{
    static void Main(string[] args)
    {
        bool[] primeCandidates = new bool[10000000];

        for (int i = 0; i < primeCandidates.Length; i++)
        {
            primeCandidates[i] = true; // set all initial candidates to true
        }
        for (int i = 2; i < Math.Sqrt(primeCandidates.Length); i++)
        {
            if (primeCandidates[i])
            {
                for (int y = i + i; y < primeCandidates.Length; y = y + i)
                {
                    primeCandidates[y] = false;
                }
            }
        }

        int start = 0; // min value (default)
        int end = primeCandidates.Length; // max value (default)

        Console.WriteLine("I am a program tht knows ALL the primes from 0 to 10 000 000! Try me!");
        Console.WriteLine("Give me the START of the range (min 0 - max 10 000 000 - lower than END) :");
        start = int.Parse(Console.ReadLine());
        Console.WriteLine("Now gimme the END of the range (min 0 - max 10 000 000 - bigger than START) :");
        end = int.Parse(Console.ReadLine());     
 
        for (int i = start; i < end; i++)
        {
            if (primeCandidates[i])
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.Write("{0}", i);
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write(" ");
            }
        }
        Console.WriteLine();
        Console.ReadLine();

    }
}

