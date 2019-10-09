/*
 C# Sharp Exercises: Create a new string from a given string
 with the first character added at the front and back
*/

using System;

namespace CSharp_Basic
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Enter a string: ");
            string input = Console.ReadLine();
            if (input.Length == 1)
            {
                input = input + input + input;
            }
            else
            {
                string firstCharacter = input.Substring(0, 1);
                input = firstCharacter + input + firstCharacter;
            }
            Console.WriteLine("Output: " + input);
            Console.ReadKey();
        }
    }
}