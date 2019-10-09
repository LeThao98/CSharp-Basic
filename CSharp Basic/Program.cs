/*
  Write a C# program to check the sum of the two given
  integers and return true if one of the integer is 20
  or if their sum is 20.
*/

using System;

namespace CSharp_Basic
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("\nInput an integer:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input another integer:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(a == 20 || a + b == 20);
            Console.ReadKey();
        }
    }
}