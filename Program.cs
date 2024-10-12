using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1  Multiplication table of a given number 
            //Console.WriteLine("Enter the number");
            //int num=Convert.ToInt32(Console.ReadLine());
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine($"{num} * {i} = {num * i}");
            //}
            //Console.ReadLine();

            //2 Display a right-angled triangle
            //Console.Write("Enter the number of rows: ");
            //int rows = Convert.ToInt32(Console.ReadLine());
            //for (int i = 1; i <= rows; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("* ");
            //    }

            //    Console.WriteLine();
            //}
            //Console.ReadLine();

            //3 Sum of all even numbers between 1 and 100
            //int sum = 0;
            //int number = 2; 

            //while (number <= 100)
            //{
            //    sum += number; 
            //    number += 2;   
            //}

            //Console.WriteLine("The sum of all even numbers between 1 and 100 is: " + sum);
            //Console.ReadLine();

            //4  Multiplication table from 1 to 5  
            //int i = 1;

            //while (i <= 5)
            //{
            //    int j = 1;

            //    while (j <= 5)
            //    {
            //        Console.Write(i * j + "\t");
            //        j++;
            //    }

            //    Console.WriteLine();
            //    i++;
            //}
            //Console.ReadLine();

            //5 Print Positive Number
            //int num;

            //do
            //{
            //    Console.Write("Enter a positive number (or a negative number to stop): ");
            //    num = Convert.ToInt32(Console.ReadLine());

            //    if (num >= 0)
            //    {
            //        Console.WriteLine($"You entered:{num} " );
            //    }

            //} while (num>= 0); 
            //Console.WriteLine("Program has ended because a negative number was entered.");
            //Console.ReadLine();

            //6  Create Menu Driven Calculator 

            //char choice;

            //do
            //{
            //    Console.WriteLine("Basic Calculator Menu");
            //    Console.WriteLine("1. Add (+)");
            //    Console.WriteLine("2. Subtract (-)");
            //    Console.WriteLine("3. Multiply (*)");
            //    Console.WriteLine("4. Divide (/)");
            //    Console.WriteLine("5. Exit");
            //    Console.Write("Enter your choice (1-5): ");
            //    choice = Console.ReadKey().KeyChar;
            //    Console.WriteLine();

            //    if (choice == '5')
            //    {
            //        Console.WriteLine("Exiting the calculator. Goodbye!");
            //        break;
            //    }


            //    Console.Write("Enter the first number: ");
            //    double num1 = Convert.ToDouble(Console.ReadLine());

            //    Console.Write("Enter the second number: ");
            //    double num2 = Convert.ToDouble(Console.ReadLine());

            //    double result = 0;


            //    switch (choice)
            //    {
            //        case '1': 
            //            result = num1 + num2;
            //            Console.WriteLine($"Result: {num1} + {num2} = {result}");
            //            break;
            //        case '2': 
            //            result = num1 - num2;
            //            Console.WriteLine($"Result: {num1} - {num2} = {result}");
            //            break;
            //        case '3': 
            //            result = num1 * num2;
            //            Console.WriteLine($"Result: {num1} * {num2} = {result}");
            //            break;
            //        case '4': 
            //            if (num2 != 0)
            //            {
            //                result = num1 / num2;
            //                Console.WriteLine($"Result: {num1} / {num2} = {result}");
            //            }
            //            else
            //            {
            //                Console.WriteLine("Error: Division by zero is not allowed.");
            //            }
            //            break;
            //        default:
            //            Console.WriteLine("Invalid choice. Please enter a valid option (1-5).");
            //            break;
            //    }

            //    Console.WriteLine();

            //} while (true);
            //Console.ReadLine();

            //7 Print All Numbers From 1 to 100 
            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i > 50)
            //    {
            //        break;
            //    }

            //    if (i % 3 == 0)
            //    {
            //        continue;
            //    }

            //    Console.WriteLine(i);
            //}

            // Console.ReadLine();

            //8 Sum of Odd Numbers 
            //    int sum = 0;

            //    for (int i = 1; i <= 100; i += 2) 
            //    {
            //        sum += i; 
            //    }

            //    Console.WriteLine($"The sum of all odd numbers between 1 and 100 is: {sum}");
            //    Console.ReadLine();

            //9  Factorial Calculation  
            //Console.Write("Enter a number to calculate its factorial: ");
            //int number = int.Parse(Console.ReadLine());

            //int factorial = 1;
            //int i = number;

            //while (i > 0)
            //{
            //    factorial *= i; 
            //    i--;            
            //}

            //Console.WriteLine($"The factorial of {number} is: {factorial}");
            //Console.ReadLine();

            //10  Number Pyramid
            //int rows = 5;
            //int i = 1;

            //while (i <= rows)
            //{
            //    int j = 1;

            //    while (j <= i)
            //    {
            //        Console.Write(i + " ");
            //        j++;
            //    }

            //    Console.WriteLine();
            //    i++;
            //}
            //Console.ReadLine();

            //11  Guess the Number Game
            //Random random = new Random();
            //char playAgain;

            //do
            //{
            //    int randomNumber = random.Next(1, 101);
            //    int userGuess = 0;

            //    Console.WriteLine("I have generated a random number between 1 and 100. Can you guess it?");


            //    do
            //    {
            //        Console.Write("Enter your guess: ");
            //        userGuess = int.Parse(Console.ReadLine());

            //        if (userGuess > randomNumber)
            //        {
            //            Console.WriteLine("Too high!");
            //        }
            //        else if (userGuess < randomNumber)
            //        {
            //            Console.WriteLine("Too low!");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Congratulations! You guessed the correct number.");
            //        }

            //    } while (userGuess != randomNumber);


            //    Console.Write("Do you want to play again? (y/n): ");
            //    playAgain = Console.ReadKey().KeyChar;
            //    Console.WriteLine(); 

            //} while (playAgain == 'y' || playAgain == 'Y'); 

            //Console.WriteLine("Thank you for playing!");
            //Console.ReadLine();

            //12  Simple Calculator 
            //double num1, num2, result = 0;
            //char operation;

            //Console.WriteLine("Enter the first number:");
            //num1 = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Enter an operator (+, -, *, /):");
            //operation = Console.ReadLine()[0];
            //Console.WriteLine("Enter the second number:");
            //num2 = Convert.ToDouble(Console.ReadLine());


            //switch (operation)
            //{
            //    case '+':
            //        result = num1 + num2;
            //        break;
            //    case '-':
            //        result = num1 - num2;
            //        break;
            //    case '*':
            //        result = num1 * num2;
            //        break;
            //    case '/':
            //        if (num2 != 0)
            //        {
            //            result = num1 / num2;
            //        }
            //        else
            //        {
            //            Console.WriteLine("Error! Division by zero is not allowed.");
            //            return;
            //        }
            //        break;
            //    default:
            //        Console.WriteLine("Invalid operator.");
            //        return;
            //}
            //Console.WriteLine($"Result: {num1} {operation} {num2} = {result}");

            //13  Sum of Digits 
            //int number, sum = 0, digit;


            //Console.WriteLine("Enter a number:");
            //number = Convert.ToInt32(Console.ReadLine());

            //number = Math.Abs(number);

            //do
            //{
            //    digit = number % 10;  
            //    sum += digit;         
            //    number /= 10;         
            //} while (number > 0);


            //Console.WriteLine("Sum of the digits: " + sum);

            //14 Finding the Largest Number  
            //int number, largest = int.MinValue;


            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine($"Enter number {i}:");
            //    number = Convert.ToInt32(Console.ReadLine());
            //    if (number > largest)
            //    {
            //        largest = number;
            //    }
            //}


            //Console.WriteLine($"The largest number is: {largest}");

            //15  Sum of Squares 
            //int number, sum = 0, i = 1;
            //Console.WriteLine("Enter a number:");
            //number = Convert.ToInt32(Console.ReadLine());
            //while (i <= number)
            //{
            //    sum += i * i;  
            //    i++;           
            //}

            //Console.WriteLine($"The sum of squares from 1 to {number} is: {sum}");
            //Console.ReadLine();

            //16  Countdown Timer  
            //int count = 10;
            //do
            //{
            //    Console.WriteLine(count);
            //    count--;
            //    System.Threading.Thread.Sleep(1000);
            //}
            //while (count > 0);
            //Console.WriteLine("count down complete!");
            //Console.ReadLine();

            //17  Finding the First Multiple of 5 
            //int[] numbers = { 12, 3, 7, 22, 18, 25, 11, 30 };
            //foreach (int number in numbers)
            //{
            //    if (number % 5 == 0)
            //    {
            //        Console.WriteLine($"The first multiple of 5 is: {number}");
            //        break;

            //    }
            //}

            //18  Print Non-Multiples of 3 
            //for (int i = 1; i <= 20; i++)
            //{
            //    if (i % 3 == 0)
            //    {
            //        continue; 
            //    }


            //    Console.WriteLine(i);

            //}
            // 19 Checking for Palindrome  
            //int number, reverse = 0, remainder, original;


            //Console.WriteLine("Enter a number:");
            //number = Convert.ToInt32(Console.ReadLine());

            //original = number;

            //while (number > 0)
            //{
            //    remainder = number % 10;        
            //    reverse = reverse * 10 + remainder;  
            //    number /= 10;                   
            //}


            //if (original == reverse)
            //{
            //    Console.WriteLine($"{original} is a palindrome.");
            //}
            //else
            //{
            //    Console.WriteLine($"{original} is not a palindrome.");
            //}

            //20 Average of Positive Numbers  
            //int number, sum = 0, count = 0;
            //double average;


            //do
            //{
            //    Console.WriteLine("Enter a positive number (or a negative number to stop):");
            //    number = Convert.ToInt32(Console.ReadLine());


            //    if (number >= 0)
            //    {
            //        sum += number;
            //        count++;
            //    }

            //} while (number >= 0); 
            //if (count > 0)
            //{
            //    average = (double)sum / count;
            //    Console.WriteLine($"The average of the entered positive numbers is: {average}");
            //}
            //else
            //{
            //    Console.WriteLine("No positive numbers were entered.");
            //}

            //21  Reverse a Number  
            //int number, reverse = 0, remainder;


            //Console.WriteLine("Enter a number:");
            //number = Convert.ToInt32(Console.ReadLine());
            //do
            //{
            //    remainder = number % 10;          
            //    reverse = reverse * 10 + remainder; 
            //    number /= 10;
            //} while (number > 0);                
            //Console.WriteLine("Reversed number: " + reverse);

            //22  Menu-Driven String Operations  
            //string inputString;
            //int choice;
            //Console.WriteLine("Enter a string:");
            //inputString = Console.ReadLine();


            //Console.WriteLine("\nChoose an operation:");
            //Console.WriteLine("1. Reverse the string");
            //Console.WriteLine("2. Convert to uppercase");
            //Console.WriteLine("3. Convert to lowercase");
            //Console.WriteLine("4. Find the length of the string");

            //Console.Write("Enter your choice (1-4): ");
            //choice = Convert.ToInt32(Console.ReadLine());
            //switch (choice)
            //{
            //    case 1:

            //        char[] charArray = inputString.ToCharArray();
            //        Array.Reverse(charArray);
            //        Console.WriteLine("Reversed string: " + new string(charArray));
            //        break;

            //    case 2:

            //        Console.WriteLine("Uppercase: " + inputString.ToUpper());
            //        break;

            //    case 3:

            //        Console.WriteLine("Lowercase: " + inputString.ToLower());
            //        break;

            //    case 4:

            //        Console.WriteLine("Length of the string: " + inputString.Length);
            //        break;

            //    default:
            //        Console.WriteLine("Invalid choice. Please select a valid option.");
            //        break;
            //}

            //23  Skip Multiples of 4 
            //for (int i = 1; i <= 50; i++)
            //{
            //    // If the number is divisible by 4, skip it
            //    if (i % 4 == 0)
            //    {
            //        continue;  // Skip the current iteration
            //    }

            //    // Print the number if it's not divisible by 4
            //    Console.WriteLine(i);
            //}

            //24 Fibonacci Sequence  
            //int n = 10; 
            //int first = 0, second = 1, next;

            //Console.WriteLine("The first 10 numbers in the Fibonacci sequence are:");

            //for (int i = 0; i < n; i++)
            //{

            //    Console.WriteLine(first);


            //    next = first + second;
            //    first = second; 
            //    second = next;  
            //}

            //25 Find All Armstrong Numbers  
            //int number = 1;

            //Console.WriteLine("Armstrong numbers between 1 and 500 are:");
            //while (number <= 500)
            //{
            //    int originalNumber = number;
            //    int sumOfCubes = 0;

            //    while (originalNumber > 0)
            //    {
            //        int digit = originalNumber % 10;
            //        sumOfCubes += digit * digit * digit;
            //        originalNumber /= 10;
            //    }
            //    if (sumOfCubes == number)
            //    {
            //        Console.WriteLine(number);
            //    }

            //    number++;
            //}

            //26  Menu-Driven Number System Conversion 
            //int choice;
            //Console.WriteLine("Number Conversion Menu:");
            //Console.WriteLine("1. Binary to Decimal");
            //Console.WriteLine("2. Decimal to Binary");
            //Console.WriteLine("3. Decimal to Hexadecimal");
            //Console.WriteLine("4. Exit");

            //do
            //{
            //    Console.Write("Enter your choice (1-4): ");
            //    choice = Convert.ToInt32(Console.ReadLine());

            //    switch (choice)
            //    {
            //        case 1:

            //            Console.Write("Enter a binary number: ");
            //            string binaryInput = Console.ReadLine();
            //            try
            //            {
            //                int decimalFromBinary = Convert.ToInt32(binaryInput, 2);
            //                Console.WriteLine($"Binary {binaryInput} to Decimal: {decimalFromBinary}");
            //            }
            //            catch (FormatException)
            //            {
            //                Console.WriteLine("Invalid binary number.");
            //            }
            //            break;

            //        case 2:

            //            Console.Write("Enter a decimal number: ");
            //            int decimalInput = Convert.ToInt32(Console.ReadLine());
            //            string binaryFromDecimal = Convert.ToString(decimalInput, 2);
            //            Console.WriteLine($"Decimal {decimalInput} to Binary: {binaryFromDecimal}");
            //            break;

            //        case 3:

            //            Console.Write("Enter a decimal number: ");
            //            int decimalInputForHex = Convert.ToInt32(Console.ReadLine());
            //            string hexFromDecimal = Convert.ToString(decimalInputForHex, 16).ToUpper();
            //            Console.WriteLine($"Decimal {decimalInputForHex} to Hexadecimal: {hexFromDecimal}");
            //            break;

            //        case 4:

            //            Console.WriteLine("Exiting the program. Goodbye!");
            //            break;

            //        default:
            //            Console.WriteLine("Invalid choice. Please select a valid option (1-4).");
            //            break;
            //    }
            //    Console.WriteLine(); 

            //} while (choice != 4); 

            //27  Reverse a String  
            //Console.WriteLine("Enter a string:");
            //string inputString = Console.ReadLine();

            //string reversedString = "";

            //for (int i = inputString.Length - 1; i >= 0; i--)
            //{
            //    reversedString += inputString[i];
            //}
            //  Console.WriteLine("Reversed string: " + reversedString);

            //28  Count Vowels and Consonants in a String 
            //Console.WriteLine("Enter a string:");
            //string inputString = Console.ReadLine();

            //int vowelCount = 0;
            //int consonantCount = 0;


            //inputString = inputString.ToLower();

            //string vowels = "aeiou";


            //for (int i = 0; i < inputString.Length; i++)
            //{
            //    char currentChar = inputString[i];


            //    if (char.IsLetter(currentChar))
            //    {
            //        if (vowels.Contains(currentChar))
            //        {
            //            vowelCount++; 
            //        }
            //        else
            //        {
            //            consonantCount++; 
            //        }
            //    }
            //}

            //Console.WriteLine($"Number of vowels: {vowelCount}");
            //Console.WriteLine($"Number of consonants: {consonantCount}");

            //29  Find Maximum and Minimum  
            //int max = int.MinValue;
            //int min = int.MaxValue;
            //for (int i = 1; i <= 5; i++)
            //{
            //    Console.Write($"Enter number {i}: ");
            //    int number = Convert.ToInt32(Console.ReadLine());
            //    if (number > max)
            //    {
            //        max = number;
            //    }
            //    if (number < min)
            //    {
            //        min = number;
            //    }
            //}

            //Console.WriteLine($"Maximum number: {max}");
            //Console.WriteLine($"Minimum number: {min}");

            //30 Count Digits of a Number  
            //Console.WriteLine("Enter a number:");
            //int number = Convert.ToInt32(Console.ReadLine());
            //number = Math.Abs(number); 

            //int digitCount = 0;


            //if (number == 0)
            //{
            //    digitCount = 1;
            //}
            //else
            //{

            //    while (number > 0)
            //    {
            //        number /= 10; 
            //        digitCount++; 
            //    }
            //}

            //   Console.WriteLine($"Number of digits: {digitCount}");



        }
    }
}   

