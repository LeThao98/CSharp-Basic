/*
 Get the absolute value of the difference
 between two given numbers. Return double
 the absolute value of the difference if
 the first number is greater than second number.
*/

using System;

namespace CSharp_Basic
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(Result(13, 40));
            Console.WriteLine(Result(50, 21));
            Console.WriteLine(Result(0, 23));
            Console.ReadKey();
        }

        public static int Result(int a, int b)
        {
            return a > b ? (a - b) * 2 : b - a;
        }
    }
}