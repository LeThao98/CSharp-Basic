/*
 Check two given integers and return true if one is negative
 and one is positive
*/

using System;

namespace CSharp_Basic
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Enter the first integers: ");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter the second integers: ");
            int secondnumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Check if one is negative and one is positive:");
            Console.WriteLine(firstNumber * secondnumber < 0);
            Console.ReadKey();
        }
    }
}