using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome_Checker
{
    internal class Program
    {
        static bool IsPalindrome(string input)
        {
            int length = input.Length;
            for (int i = 0; i < length / 2; i++)
            {
                if (input[i] != input[length - i - 1])
                {
                    return false;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter a string to check if it is a palindrome: ");
            string userInput = Console.ReadLine();

            bool result = IsPalindrome(userInput);
            if (result)
            {
                Console.WriteLine($"\"{userInput}\" is a palindrome.");
            }
            else
            {
                Console.WriteLine($"\"{userInput}\" is not a palindrome.");
            }
        }
    }
}
