using System;
using System.Linq;

namespace PalindromeExercise
{
    class Program
    {
        static void Main()
        {
            Console.ReadLine();
        }
    }
    public class WordSmith
    {
        public bool IsAPalindrome(string str1)
        {
            char[] input = str1.ToCharArray();
            string str2 = "";
            for (int i = input.Length -1; i > -1; i--)
            {
                str2 += input[i];
            }
            
            return (str1 == str2);
        }
    }
}
