using System;
using System.IO;
using System.Reflection.Metadata.Ecma335;

namespace ListOchArrayUppg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Array tal
            int[] testTal = { 1, 2, 3, 5 , 6};
            // List
            List<int> testIntList = new List<int> { 5, 1, 2, 7 };


            // Summan
            Console.WriteLine("Demonstration av Summan:");
            Console.WriteLine("Summan av testdatan är: " + Summan(testTal));

            // Största talet
            Console.WriteLine();
            Console.WriteLine("Demonstration av Största talet:");
            Console.WriteLine("Största talet av testdatan är: " + Greatest(testIntList));

            // Demonstration av Contains
            string[] names = { "Anna", "Bertil", "Cesar" };
            Console.WriteLine();
            Console.WriteLine("Demonstration av Contains:");
            Console.WriteLine("Contains(Bertil): " + Contains(names, "Bertil")); // true
            Console.WriteLine("Contains(David): " + Contains(names, "David")); // false

            // Demonstration av Swap
            int[] swapTestData = { 8, 4, 6, 9, 2, 7, 3 };
            Console.WriteLine();
            Console.WriteLine("Demonstration av Swap:");
            Console.WriteLine("Före: element på index 2: " + swapTestData[2]); // 6
            Console.WriteLine("Före: element på index 5: " + swapTestData[5]); // 7
            Swap(2, 5, swapTestData);
            Console.WriteLine("Efter: element på index 2: " + swapTestData[2]); // 7
            Console.WriteLine("Efter: element på index 5: " + swapTestData[5]); // 6

            // Demostration av Concatenate
            string[] testPart1 = { "foo", "bar", "baz" };
            string[] testPart2 = { "apa", "bpa", "cpa" };
            Console.WriteLine();
            Console.WriteLine("Demonstration av Concatenate:");
            string[] concatResult = Concatenate(testPart1, testPart2);
            Console.WriteLine("Sammansatt array: " + string.Join(",", concatResult));

            // Reverse
            int[] reverseTestData = { 1, 2, 3, 4, 5, 6, 7 };
            Console.WriteLine();
            Console.WriteLine("Demonstration av Reverse:");
            Console.WriteLine("Före: " + string.Join(",", reverseTestData));
            Reverse(reverseTestData);
            Console.WriteLine("Efter: " + string.Join(",", reverseTestData));
            Console.WriteLine();

            // Rotate
            string[] rotateTestData = { "a", "b", "c", "d", "e" };
            Console.WriteLine("Demonstration av Rotate:");
            Console.WriteLine("Före: " + string.Join(",", rotateTestData));
            string[] rotateTestDataResult = Rotate(rotateTestData, 2);
            Console.WriteLine("Efter: " + string.Join(",", rotateTestDataResult));

        }

        public static int Summan(int[] listOfNumbers)
        {
            int sum = 0;

            for (int i = 0; i < listOfNumbers.Length; i++)
            {
                sum = sum + listOfNumbers[i];
            }

            return sum;
        }

        public static int Greatest(List<int> numbers)
        {
            int greatest = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] > greatest) 
                { 
                    greatest = numbers[i];
                }
            }

            return greatest;
        }

        public static bool Contains(string[] names, string name)
        {
            foreach (string s in names)
            {
                if(s == name)  return true;
               
            }
            return false;
        }

        public static void Swap(int index1, int index2, int[] intarray)
        {
            int swap = intarray[index1];
            intarray[index1] = intarray[index2];
            intarray[index2] = swap;
        }

        public static string[] Concatenate(string[] part1, string[] part2)
        {
            string[] result = new string[part1.Length + part2.Length];
            for (int i = 0; i < part1.Length; i++)
            {
                result[i] = part1[i];
            }
            for (int i = 0; i < part2.Length; i++)
            {
                result[part1.Length + i] = part2[i];
            }
            return result;
        }

        public static void Reverse(int[] numbers)
        {
            for (int i = 0; i < numbers.Length / 2; i++)
            {
                Swap(i, numbers.Length - 1 - i, numbers);
            }
            return;

        }
        public static string[] Rotate(string[] strings, int n)
        {
            string[] result = new string[strings.Length];
            for (int i = 0; i < strings.Length; i++)
            {
                result[(i + n) % strings.Length] = strings[i];
            }
            

            return result;
        }
    }
}