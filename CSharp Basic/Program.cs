/*
 Compute the sum of two given integers,
 if two values are equal then return the
 triple of their sum
*/

using System;

namespace CSharp_Basic
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(SumTriple(2, 2));
            Console.WriteLine(SumTriple(12, 10));
            Console.WriteLine(SumTriple(-5, 2));
            Console.ReadKey();
        }

        public static int SumTriple(int a, int b)
        {
            return a == b ? (a + b) * 3 : a + b;
        }
    }
}