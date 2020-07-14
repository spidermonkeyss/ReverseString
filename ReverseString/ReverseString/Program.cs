//Reverse a String – Enter a string and the program will reverse it and print it out.
using System;
using Utlity;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = UserInput.GetUserStringInput();
            char[] reverseString = new char[input.Length];
            int endi = input.Length - 1;
            foreach (char c in input)
            {
                reverseString[endi] = c;
                endi--;
            }

            //Turn char array into string
            string rs = "";
            foreach (char c in reverseString)
            {
                rs += c;
            }
            Console.WriteLine("         Input:" + input + ".");
            Console.WriteLine("Reverse String:" + rs + ".");
        }
    }
}
