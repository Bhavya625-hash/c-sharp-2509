using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace c__assignments_on_string_and_arrays
{
    internal class Program
    {
        private static object i;

        static void Main(string[] args)
        {

            //1 Write C# programs on Matrix addition, Matrix Multiplication and Matrix Transpose.

            //Addition
            //int rows = 2;
            //int cols = 2;

            //int[,] matrixA = { { 1, 2 }, { 3, 4 } };
            //int[,] matrixB = { { 5, 6 }, { 7, 8 } };


            //int[,] resultmatrix = new int[rows, cols];
            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < cols; j++)
            //    {
            //        resultmatrix[i, j] = matrixA[i, j] + matrixB[i, j];
            //    }
            //}
            //Console.WriteLine("Result of matrix addition");
            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < cols; j++)
            //    {
            //        Console.Write(resultmatrix[i, j] + "\t");
            //    }
            //    Console.WriteLine();
            //}

            //multiplication matrix
            //int rowsA = 2; int rowsB = 2; int colsA = 2; int colsB = 2;

            //int[,] matrixA = { { 1, 2 }, { 3, 4 } };
            //int[,] matrixB = { { 5, 6 }, { 7, 8 } };

            //if (colsA != rowsB)
            //{
            //    Console.WriteLine("multiplication is not  possible");
            //    return;
            //}
            //int[,] resultmatrix = new int[rowsA, colsB];
            //for (int i = 0; i < rowsA; i++)
            //{
            //    for (int j = 0; j < colsB; j++)
            //    {
            //        resultmatrix[i, j] = 0;

            //        for (int k = 0; k < colsA; k++)
            //        {
            //            resultmatrix[i, j] += matrixA[i, k] * matrixB[k, j];
            //        }
            //    }
            //}
            //Console.WriteLine("result of multiplication");
            //for (int i = 0; i < rowsA; i++)
            //{
            //    for (int j = 0; j < colsB; j++)
            //    {
            //        Console.Write(resultmatrix[i, j] + "\t");
            //    }
            //    Console.WriteLine();
            //}

            //transpose matrix
            //int rows = 2;
            //int cols = 3;

            //int[,] matrixA = { { 1, 2, 1 }, { 3, 4, 4 } };

            //Console.WriteLine("matrixA");
            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < cols; j++)
            //    {
            //        Console.Write(matrixA[i, j] + "\t");
            //    }
            //    Console.WriteLine();
            //}
            //int[,] transposematrix = new int[cols, rows];

            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < cols; j++)
            //    {
            //        transposematrix[j, i] = matrixA[i, j];
            //    }
            //}
            //Console.WriteLine("transpose matrix");
            //for (int i = 0; i < cols; i++)
            //{
            //    for (int j = 0; j < rows; j++)
            //    {
            //        Console.Write(transposematrix[i, j] + "\t");
            //    }
            //    Console.WriteLine();
            //}

            //2  Write C# programs to sort an array using bubble sort and insertion sort.

            //bubble sort
            //int[] a = { 3, 0, 2, 5, -1, 4, 1 };
            //int t;                       //temporary variable for swappiing

            //Console.WriteLine("original array");
            //foreach (int aa in a)
            //    Console.Write(aa + " ");

            //for (int i = 0; i < a.Length - 2; i++)
            //{
            //    for (int j = 0; j <= a.Length - 2; j++)
            //    {
            //        if (a[j] > a[j + 1])     // checking 
            //        {
            //            t = a[j + 1];     //swapping
            //            a[j + 1] = a[j];
            //            a[j] = t;
            //        }
            //    }
            //}
            //Console.WriteLine("\n" + "sorted array");
            //foreach (int aa in a)
            //    Console.Write(aa + " ");


            // Console.Write("\n");   //adding a newline

            //insertion sort
            //for (int i = 1; i < a.Length; i++)
            //{
            //    int val = a[i];
            //    int j = i - 1;
            //    while(j>=0 && a[j] > val)
            //    {
            //        a[j+1]= a[j];
            //        j=j-1;
            //    }
            //    a[j+1] = val;
            //}
            //Console.Write("\nAfter sorting:");
            //for (int i = 0; i < a.Length; i++)
            //{
            //    Console.Write(a[i] + " ");
            //}

            //3  Write C# programs to search an array using linear search and binary search. 




            //5  Write a C# programs to count vowels, consonants and special characters. 

            //Console.Write("Enter a string:");
            //string input = Console.ReadLine();

            //int vowels = 0, consonants = 0, specialCharacters = 0;

            //foreach (char ch in input)
            //{
            //    if ("aeiou".Contains(ch)) // Check if character is a vowel
            //    {
            //        vowels++;
            //    }
            //    else if (char.IsLetter(ch)) // Check if character is a consonant
            //    {
            //        consonants++;
            //    }
            //    else
            //    {
            //        specialCharacters++;
            //    }
            //}

            //Console.WriteLine("Vowels: " + vowels);
            //Console.WriteLine("Consonants: " + consonants);
            //Console.WriteLine("Special Characters: " + specialCharacters);

            //6  Write a C# program to reverse a string. 

            //Console.Write("Enter a string: ");
            //string input = Console.ReadLine(); // Read the input string from the user

            //char[] charArray = input.ToCharArray(); // Convert the string to a character array
            //Array.Reverse(charArray); // Reverse the character array

            //string reversedString = new string(charArray); // Convert the reversed character array back to a string
            //Console.WriteLine("Reversed string: " + reversedString); // Display the reversed string


            //9  Write a C# program to remove whitespace from a string. 

            //Console.WriteLine("Enter the string");
            //var inputString = Console.ReadLine();
            //inputString = inputString.Replace(" ", "");
            ////replacing whitespace with null
            //Console.WriteLine($"string after removing whitespace:{inputString}");

            //10  Write a C# program to replace all occurrences of a substring.

            //Console.WriteLine("Enter a string");
            //var inputString=Console.ReadLine();
            //Console.WriteLine("Enter a substring to replace");
            //var inputSubString=Console.ReadLine();
            //inputString = inputString.Replace(inputSubString, " ");
            ////Replacing substring with whitespace
            //Console.WriteLine($"String after removing substring:{inputString}");

            //11  Write a C# program to find the longest word in a sentence. 

            //Console.Write("Enter a sentence: ");
            //string input = Console.ReadLine();

            //// Split the sentence into words
            //string[] words = input.Split(' ');

            //string longestWord = "";

            //// Loop through each word to find the longest one
            //foreach (string word in words)
            //{
            //    // Check if the current word is longer than the longestWord found so far
            //    if (word.Length > longestWord.Length)
            //    {
            //        longestWord = word;
            //    }
            //}

            //// Display the longest word
            //Console.WriteLine("The longest word is: " + longestWord);

            //12  Write a C# program to count words in a sentence. 

            //Console.Write("Enter a sentence: ");
            //string sentence = Console.ReadLine();

            //// Split the sentence into words
            //string[] words = sentence.Split(' ');

            //// Count the words
            //int wordCount = words.Length;

            //// Display the word count
            //Console.WriteLine("The number of words is: " + wordCount);

            //13  Write a C# program to remove duplicate characters from a string.

            //Console.Write("Enter a string: ");
            //string input = Console.ReadLine();

            //// Variable to store the result with no duplicate characters
            //string result = "";

            //// Loop through each character in the input string
            //foreach (char c in input)
            //{
            //    // If the character is not already in the result, add it
            //    if (!result.Contains(c))
            //    {
            //        result += c;
            //    }
            //}

            //// Display the result
            //Console.WriteLine("String after removing duplicates: " + result);

            //14  Write a C# program to check if two strings are anagrams

            //String string1 = "rock";
            //String string2 = "cork";

            ////convert strings to lowercase
            //string1=string1.ToLower();
            //string2 = string2.ToLower();

            ////convert strings to character arrays
            //char[] s1Array=string1.ToCharArray();
            //char[] s2Array=string2.ToCharArray();

            ////sort the charactor arrays
            //Array.Sort(s1Array);
            //Array.Sort(s2Array);

            ////compare the sorted arrays
            //bool areAnagrams =s1Array.SequenceEqual(s2Array);

            //if (areAnagrams)
            //{
            //    Console.WriteLine($"{string1} and {string2} are anagrams");
            //}
            //else
            //{
            //    Console.WriteLine($"{string1} and {string2} are not anagrams");
            //}

            //15  Write a C# program to find the frequency of each character in a string. 

            //String string1 = "Malayalam";
            //Dictionary<char,int>frequency = new Dictionary<char,int>();
            //foreach (char c in string1.ToLower())
            //{
            //    if (frequency.ContainsKey(c))
            //    {
            //        frequency[c]++;
            //    }
            //    else
            //    {
            //        frequency[c] = 1;
            //    }
            //}
            //Console.WriteLine("string:"+string1);
            ////print the frequency of each charactor
            //Console.WriteLine("charactor frequencies:");
            //foreach(var keyvalue in frequency)
            //{
            //    Console.WriteLine($"charactor  {keyvalue.Key}: {keyvalue.Value}");
            //}
            //16 . Write a C# program to find the first non-repeating character in a string.
            //String string1 = "hello hy";
            //Dictionary<char,int>frequency = new Dictionary<char,int>();

            ////count the frequency of each charactor
            //foreach (char c in string1.ToLower())
            //{
            //    if (frequency.ContainsKey(c))
            //    {
            //        frequency[c]++;
            //    }
            //    else
            //    {
            //        frequency[c] = 1;
            //    }
            //} 
            //Console.WriteLine("string;"+string1);
            ////print the first non repeating charactor
            //foreach (char c in string1.ToLower())
            //{
            //    if (frequency[c] == 1)
            //    {
            //        Console.WriteLine("first non-repeating charactor:" + c);
            //        break;
            //    }
            //}
            //17  Write a C# program to reverse words in a sentence. 

            //string sentence = "hy hello";
            //Console.WriteLine("original sentence:"+sentence);
            ////spilt the sentence into words
            //string[] words=sentence.Split(' ');

            ////reverse the order of the words
            //Array.Reverse(words);

            ////join the reversed words into a new sentence
            //string reversedSentence=string.Join(" ", words);

            //Console.WriteLine("reversed sentence;"+reversedSentence);

            //18  Write a C# program to check if a string contains only digits.

            Console.WriteLine("enter a string");
            string string1=Console.ReadLine();

            bool containsOnlyDigits=true;

            foreach(char c in string1)
            {
                if (!char.IsDigit(c))
                {
                    Console.WriteLine("The string contains non-digit charactors");
                    containsOnlyDigits = false;
                    break;
                }
            }
            if (containsOnlyDigits)
            {
                Console.WriteLine("The string contains only digits");
            }





            Console.ReadLine();
        }



       



            
        
    }
}
