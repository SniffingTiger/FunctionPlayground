using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

namespace TestConsoleAppExperiments
{
    public class Program
    {
        static void Main(string[] args)
        {

        }

        // Whiteboarding with Amanda recursion method
        public static int SomeFunction(int x)
        {
            if (x == 0)
                return 0;
            else
                return x + SomeFunction(x - 1);
        }

        // Multiplication method using only the add ( + ) operator
        static int Multiply(int x, int y)
        {
            int sum = 0;
            int temp = y;
            if (y < 0)
                temp = -y;
            for (int i = 0; i < temp; i++)
            {
                sum += x;
            }
            if (y < 0)
                sum = -sum;
            return sum;
        }

        // Division method using only the add ( + ) operator
        static int Divide(int x, int y)
        {
            int calc = 0;
            int quotient = 0;
            if (x < 0 && y > 0)
            {
                while (calc + -y >= x)
                {
                    calc += -y;
                    quotient += -1;
                }
            }
            else if (y < 0 && x > 0)
            {
                while (calc + -y <= x)
                {
                    calc += -y;
                    quotient += -1;
                }
            }
            else
            {
                if (y < 0)
                    y = -y;
                if (x < 0)
                    x = -x;
                while (calc + y <= x)
                {
                    calc += y;
                    quotient++;
                }
            }
            return quotient;
        }

        // TODO: Complete the following method
        // Subtraction method using only the add ( + ) operator
        //static int Subtract(int x, int y)
        //{
        //}

        // 1. Reads multiple integer inputs from user
        // 2. Outputs only the inputted numbers that are between 1 and 10

        static void WhiteboardMethod()
        {
            List<int> numbers = new List<int>();
            Console.WriteLine("Enter as many numbers as you would like. Enter nothing and simply press 'Enter' to finish entering numbers.");

            int input = 0;
            while (true)
            { 
                try
                {
                    input = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    break;
                }
                numbers.Add(input);
            }

            Console.WriteLine("Only the following numbers that you entered are between 1 and 10: ");
            foreach (var item in numbers)
            {
                if (item > 0 && item < 11)
                {
                    Console.WriteLine(item);
                }
            }
        }

        // Outputs a random name from an array of names
        static void RandomNames()
        {
            string[] names = new string[] { "John", "Jill", "Jack", "Jane" };
            Random rando = new Random();
            Console.WriteLine("This is a random name from the string array 'names': " + names[rando.Next(names.Length)]);
        }

        // Outputs a randomized version of an array of names without repeating the same name
        static void RandomizeNameArray()
        {
            string[] names = new string[] { "John", "Jill", "Jack", "Jane" };
            string[] randoNames = new string[names.Length];
            Random rando = new Random();

            randoNames[0] = names[rando.Next(names.Length)];

            string output = "";
            for (int i = 1; i < names.Length; i++)
            {
                bool isUnique = false;
                while (!isUnique)
                {
                    isUnique = true;
                    output = names[rando.Next(names.Length)];
                    for (int j = 0; j < names.Length; j++)
                    {
                        if (output == randoNames[j])
                            isUnique = false;
                    }
                }
                randoNames[i] = output;             
            }

            foreach (string item in randoNames)
            {
                Console.WriteLine(item);
            }
        }

        // Returns a boolean value that shows whether or not a word is a palindrome
        static bool IsPalindrome(string word)
        {
            char[] reverseword = new char[word.Length];
            reverseword = word.ToCharArray();
            Array.Reverse(reverseword);
            bool ispalindrome = false;

            for (int i = 0; i < word.Length; i++)
            {
                if (word.ToCharArray()[i] == reverseword[i])
                {
                    ispalindrome = true;
                }
                else
                {
                    ispalindrome = false;
                }
            }
            return ispalindrome;
        }

        // Exception-safe integer input method
        static int GetIntInput()
        {
            int intparseduserinput;
            decimal decimalparseduserinput;
            dynamic rawuserinput = Console.ReadLine();
            if (int.TryParse(rawuserinput, out intparseduserinput))
            {
                return intparseduserinput;
            }
            else if (decimal.TryParse(rawuserinput, out decimalparseduserinput))
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("You must enter a whole number with no decimals. Try again: ");
                Console.ResetColor();
                return GetIntInput();
            }
            else if (rawuserinput is string)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("A number has no letters or symbols. Enter a number: ");
                Console.ResetColor();
                return GetIntInput();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("An error has occured. Try to enter a number again: ");
                Console.ResetColor();
                return GetIntInput();
            }
        }

        //// Integer input method that uses exceptions
        //public static int GetIntInput()
        //{
        //    try
        //    {
        //        int intInput = Convert.ToInt32(Console.ReadLine());
        //        return intInput;
        //    }
        //    catch (FormatException)
        //    {
        //        Console.ForegroundColor = ConsoleColor.DarkYellow;
        //        Console.Write("ERROR: You must enter a whole number. Try again: ");
        //        Console.ResetColor();
        //        return GetIntInput();
        //    }
        //    catch (Exception)
        //    {
        //        Console.ForegroundColor = ConsoleColor.DarkYellow;
        //        Console.Write("ERROR: An error has occured. Try again: ");
        //        Console.ResetColor();
        //        return GetIntInput();
        //    }
        //}

        static void bitWise ()
        {
            uint a = 2;
            if ((a >> 1) == 1)
            { Console.WriteLine("Success"); }
        }

        static string StarTriangle2(int baseLength)
        {
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 1; i <= baseLength; i++)
            {
                stringBuilder.Append(' ', baseLength/2 - i);
                stringBuilder.Append('*', i);
                stringBuilder.Append(' ', baseLength/2 - i);
                stringBuilder.Append('\n', 1);
            }
            return stringBuilder.ToString();
        }

        // Prints a triangle of asterisks
        static void StarTriangle()
        {
            Console.Write("Input triangle base length: ");
            int baseLength = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            int space = baseLength;

            for (int i = 1; i <= baseLength; i++)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                if (i % 2 == 0)
                {
                Console.ForegroundColor = ConsoleColor.Magenta;
                }
                for (int j = 1; j <= space; j++)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }

                for (int k = 1; k <= space; k++)
                {
                    Console.Write(" ");
                }

                Console.WriteLine();

                space -= 1;
            }
        }

        // Swaps the values of every neighboring pair of array index values (Ex. a[0] = a[1] AND a[1] = a[0], THEN a[2] = a[3] AND a[3] = a[2]
        static int[] SwapEveryTwo (int[] a)
        {
            int[] swappedArray = new int[a.Length];
            for (int i = 0; i < a.Length; i+=2)
            {
                int temp = a[i];
                a[i] = a[i + 1];
                a[i + 1] = temp;
            }

            swappedArray = a;

            return swappedArray;
        }

        // Returns the sum of all even numbers in an integer array
        static int SumOfEvens (int[] arr)
        {
            int sum = 0;
            foreach (int item in arr)
            {
                if (item % 2 == 0)
                {
                    sum += item;
                }
            }

            return sum;
        }

        // Returns the average of any amount of doubles
        static double dblAvg(params double[] doubles)
        {
            double sum = 0;
            foreach (double item in doubles)
            {
                sum += item;
            }

            double average = 0;
            average = sum / doubles.Length;
            return average;
        }

        // Deletes a given position in an array by moving all the positions to the right of the given position to the left, then removing the last array element
        // Ex. { 1, 2, 3, 4, 5 } if you remove the first index (which is the number 2), the array now becomes { 1, 3, 4, 5 }
        static void deleteArrayPosition(ref int [] intArray, int position)
        {
            for (int i = position; i < intArray.Length - 1; i++)
            {
                intArray[i] = intArray[i + 1];
            }

            Array.Resize(ref intArray, intArray.Length - 1);
        }

        // Determines whether or not a given positive integer is within 10 of any multiple of a hundred
        static bool isWithinTenOfMultipleOfHundred(int num)
        {
            if (num < 0)
            {
                throw new ArgumentOutOfRangeException("num", "Number must be equal to or over 0.");
            }

            bool withinTen = false;
            int multiplesOfHundred = 0;

            while (withinTen == false && multiplesOfHundred < num + 100)
            {
                if (num >= (multiplesOfHundred - 10) && num <= (multiplesOfHundred + 10))
                {
                    withinTen = true;
                }
                multiplesOfHundred += 100;
            }

            return withinTen;
        }

        /* Returns the absolute value of the difference between two integers.
           If the first integer is larger than the second, returns twice that absolute value. */
        static int AbsDiff(int num1, int num2)
        {
            int absDiff = Math.Abs(num1 - num2);
            if (num1 > num2)
            {
                absDiff *= 2;
            }
                return absDiff;
        }

        // Generic method that returns a deep copy of the inputted array
        static T[] CopyArray<T>(T[] inputArray)
        {
            T[] copiedArray = new T[inputArray.Length];
            inputArray.CopyTo(copiedArray, 0);
            return copiedArray;
        }

        // Returns a string that is 4 copies of the first two characters of a string
        // If the input string is less than two characters long, simply return the input string without making any changes to it
        static string FirstTwoCharFourTimes(string input)
        {
            if (input.Length <= 2)
                return input;

            char[] inputArray = input.ToCharArray(0, 2);
            Array.Resize(ref inputArray, 8);

            for (int i = 2; i < 8; i += 2)
            {
                inputArray[i] = inputArray[0];
                inputArray[i + 1] = inputArray[1];
            }

            string output = new string(inputArray);
            return output;
        }

        // Returns TRUE only if one int paramteter is negative AND one int parameter is positive
        static bool IsPosAndNeg(int num1, int num2)
        {
            if ((num1 < 0 || num2 < 0) && (num1 > 0 || num2 > 0))
                return true;
            else
                return false;
        }

        /*String Compression: Implement a method to perform basic string compression using the counts of repeated characters.
         * For example, the string "aabcccccaaa" would become "a2b1c5a3". If the "compressed" string would not become smaller than the original
         * string, your method should return the original string. You can assume the string has only uppercase and lowercase letters (a-z, A-Z). */
        //static string BasicStringCompression(string input)
        //{
        //    char[] inputToCharArray = input.ToCharArray(); // Convert input string into a character array

        //    for (int i = 0; i < input.Length; i++)
        //    {
        //        char currentChar = inputToCharArray[0];
        //        while (currentChar == )
        //        {
        //            // TODO: Finish this method!!
        //        }
        //    }
        //}

        // This method tests if the last two bytes in a character array are English or Japanese characters
        public static int NumChars(char[] engOrJapChars)
        {
            byte[] lastTwoBytes = Encoding.UTF8.GetBytes(engOrJapChars);

            byte highByte = lastTwoBytes[lastTwoBytes.Length - 1];
            byte lowByte = lastTwoBytes[lastTwoBytes.Length - 2];

            if ((highByte >> 7 == 1) && (lowByte >> 7 == 1 || lowByte >> 7 == 0))
            {
                return 2;
            }

            else if ((highByte >> 7 == 0) && (lowByte >> 7 == 0))
            {
                return 1;
            }

            else return 0;
        }

        // This method returns the second-largest number in an integer array
        public static int SecondLargestNum(int[] intArray)
        {
            // -- NOT USING LINQ
            //Array.Sort(intArray);
            //int secondLargestNum = intArray[intArray.Length - 2];


            // -- USING LINQ
            int secondLargestNum = intArray
                .OrderByDescending(i => (int)i)
                .Skip(1)
                .First();

            return secondLargestNum;
        }
    }
}