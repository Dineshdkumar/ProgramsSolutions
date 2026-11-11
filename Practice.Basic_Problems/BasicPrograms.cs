using System;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json.Serialization.Metadata;

namespace Practice.Basic_Problems
{
    public class BasicPrograms
    {
        public static int ReadNumber()
        {
            while (true)
            {

                if (int.TryParse(Console.ReadLine(), out int num))
                {
                    return num;
                }
                Console.WriteLine("Please Enter a valid Number");
            }

        }

        public static void SumOfNumbers()
        {
            Console.WriteLine("How many Numbers you want to sum ?");
            int count;
            while (!int.TryParse(Console.ReadLine(), out count))
            {
                Console.WriteLine("Please enter a valid number.");
            }

            int sum = 0;
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"Enter number {i + 1}:");
                int num;
                while (!int.TryParse(Console.ReadLine(), out num))
                {
                    Console.WriteLine("Please enter a valid number.");
                }
                sum = sum + num;
            }
            Console.WriteLine("Sum Of Numbers are :" + sum);

        }

        public static void SwapNumber()
        {
            Console.WriteLine("Enter your first number");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your second number");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Before swap: a = {a}, b = {b}");

            int temp = a;
            a = b;
            b = temp;

            Console.WriteLine($"After swap: a = {a}, b = {b}");
            (a, b) = (b, a);

            Console.WriteLine($"After swap using (Tuple Swap): a = {a}, b = {b}");
            a = a + b;  // Sum
            b = a - b; // return other value 
            a = a - b;
            Console.WriteLine($"After swap withot third variable: a = {a}, b = {b}");

        }

        public static void EvenOrOdd()
        {
            Console.WriteLine("Enter your first number");
            int num;
            while (!int.TryParse(Console.ReadLine(), out num))
            {
                Console.WriteLine("Please Enter a valid number");
            }
            if (num % 2 == 0)
            {
                Console.WriteLine(num + " is a even number");
            }
            else
            {
                Console.WriteLine(num + " is a odd number");
            }

        }


        public static void GreatestNumber()
        {
            Console.WriteLine("Enter your first number");
            int num1 = ReadNumber();
            Console.WriteLine("Enter your second number");
            int num2 = ReadNumber();

            Console.WriteLine("Enter your third number");
            int num3 = ReadNumber();

            if (num1 >= num2 && num1 >= num3)
            {
                Console.WriteLine($"{num1} is the greatest number");
            }
            else if (num2 >= num1 && num2 >= num3)
            {
                Console.WriteLine($"{num2} is the greatest number");
            }
            else if (num3 >= num1 && num3 >= num2)
            {
                Console.WriteLine($"{num3} is the greatest number");
            }
        }

        public static void Calculator()
        {
            Console.WriteLine("Hi there!, I am calculator. Please choose the following to do");
            while (true)
            {
                Console.WriteLine("1.Add 2.Sub 3.Multiplication 4.Division 0.Exit");
                Console.Write("Choose an operation: ");
                int type = ReadNumber();

                if (type == 0)
                    break; // EXIT THE LOOP
                Console.WriteLine("Enter 1st number");
                int num1 = ReadNumber();
                Console.WriteLine("Enter 2nd number");
                int num2 = ReadNumber();

                switch (type)
                {
                    case 1:
                        Console.WriteLine($"Result is : {num1 + num2}");
                        break;
                    case 2:
                        Console.WriteLine($"Result is : {num1 - num2}");
                        break;
                    case 3:
                        Console.WriteLine($"Result is : {num1 * num2}");
                        break;
                    case 4:
                        if (num2 == 0)
                        {
                            Console.WriteLine("Cannot divide a number with 0");
                            return;
                        }
                        Console.WriteLine($"Result is : {(double)num1 / num2}");
                        break;
                    default:
                        Console.WriteLine("Choose the values between (1-4)");
                        break;
                }
            }
        }

        public static void BasicLoop()
        {
            Console.WriteLine("Numbers from 1 to 100");

            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(i);
            }
        }

        public static void MultiplicationTable()
        {
            Console.WriteLine("Enter a number for the Multiplication Table");
            int num = ReadNumber();
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{num} x {i} = {num * i}");
            }
        }

        public static void SumOfDigits(int num)
        {
            int sum = 0;
            while (num > 0)
            {
                int digit = num % 10;    // Last digit 
                sum = sum + digit;
                num = num / 10;         // Remove the Last digit
            }
            Console.WriteLine("Sum of digits is " + sum);
        }

        public static void RevereseNumber()
        {
            Console.WriteLine("Enter Number : ");
            int num = ReadNumber();
            string rev = "";

            while (num > 0)
            {
                int digit = num % 10;  // Last Digit
                rev = rev + digit;
                num = num / 10;   // Remove the Last digit
            }
            Console.WriteLine(rev);
        }

        public static void Palindrome()
        {
            Console.WriteLine("Enter Number : ");
            int num = ReadNumber();
            string rev = "";
            int num1 = num;
            while (num > 0)
            {
                int lastDigit = num % 10;
                rev += lastDigit;
                num = num / 10;
            }

            if (num1 == Convert.ToInt32(rev))
            {
                Console.WriteLine($"{num1} is a palindrome number");
            }
            else
                Console.WriteLine($"{num1} is not a palindrome number");
        }

        public static void Factorial()
        {
            Console.WriteLine("Enter Number : ");
            int num = ReadNumber();
            long fact = num;
            for (int i = num - 1; i >= 1; i--)
            {
                fact = fact * i;
            }
            Console.WriteLine($"Factorial of {num} is {fact}");
        }

        public static void isPrimeOrNot()
        {
            Console.WriteLine("Enter Number : ");
            int num = ReadNumber();
            if (num <= 1)
            {
                Console.WriteLine($"{num} is not a prime number");
                return;
            }
            int count = 0;
            for (int i = 1; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    count++;
                }

            }
            if (count == 1)
            {
                Console.WriteLine($"{num} is a prime number");
            }
            else
            {
                Console.WriteLine($"{num} is not a prime number");
            }
        }

        public static void isPrimeOrNot2()
        {
            Console.WriteLine("Enter Number");
            int num = ReadNumber();

            for (int i = 2; i * i <= num; i++)
            {
                if (num % i == 0)
                {
                    Console.WriteLine($"{num} is not a prime number");
                    return;
                }
            }
            Console.WriteLine($"{num} is a prime number");
        }

        public static void Fibinacci()
        {
            Console.WriteLine("Enter Number");
            int num = ReadNumber();

            int num1 = 0, num2 = 1, nextNum;
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine(num1);
                nextNum = num1 + num2;
                num1 = num2;
                num2 = nextNum;
            }
        }

        public static void CounttheDigits()
        {
            Console.WriteLine("Enter Number");
            int num = ReadNumber();
            int count = 0;

            while (num >= 0)
            {
                int lastDigit = num % 10;
                count++;
                num = num / 10;
            }
            Console.WriteLine($"Number of digits is {count}");

        }

        public static void SumOfEvenOrOdd()
        {
            Console.WriteLine("Enter Number");
            int num = ReadNumber();
            int evenSum = 0, oddSum = 0;
            while (num > 0)
            {
                int lastDigit = num % 10;
                if (lastDigit % 2 == 0)
                {
                    evenSum += lastDigit;
                }
                else
                {
                    oddSum += lastDigit;
                }
                num = num / 10;
            }

            Console.WriteLine($"evenSum :{evenSum}  Odd Sume :{oddSum}");
        }

        #region Strings
        public static void ReverseAString()
        {
            Console.WriteLine("Enter a String");
            string str = Console.ReadLine();
            string rev = "";
            //StringBuilder rev=new StringBuilder();
            for (int i = str.Length - 1; i >= 0; i--)
            {
                rev += str[i];
                //rev.Append(str[i]);
            }
            Console.WriteLine(rev);
        }

        public static void PalindromeString()
        {
            Console.WriteLine("Enter a String");
            string str = Console.ReadLine();
            string rev = "";
            for (int i = str.Length - 1; i >= 0; i--)
            {
                rev += str[i];
            }
            if (str.Equals(rev, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("It is palindrome string");
            }
            else
            {
                Console.WriteLine("It is not a palindrome string");
            }
        }

        public static void VowelAndConsonantCount()
        {
            Console.WriteLine("Enter a String");
            string str = Console.ReadLine();
            int vowelCount = 0, ConsonantCount = 0;
            for (int i = 0; i <= str.Length - 1; i++)
            {
                if (char.IsLetter(str[i]))
                {
                    if ("aeiou".Contains(char.ToLower(str[i])))
                    {
                        vowelCount++;
                    }
                    else
                    {
                        ConsonantCount++;
                    }
                }
            }
            Console.WriteLine($"Vowel Count {vowelCount} Consonant Count : {ConsonantCount}");
        }

        public static void NumberOfWords()
        {
            Console.WriteLine("Enter a String");
            string str = Console.ReadLine();
            int wordsCount = 1;
            for (int i = 0; i <= str.Length - 1; i++)
            {
                if (str[i] == ' ')
                {
                    wordsCount++;
                }
            }
            Console.WriteLine($"Words Count: {wordsCount}");

        }

        public static void FrequencyOfLetters()
        {
            Console.WriteLine("Enter a String");
            string str = Console.ReadLine();
            for (int i = 0; i < str.Length; i++)
            {
                int count = 0;
                bool alreadyCounted = false;

                for (int k = 0; k < i; k++)
                {
                    if (str[i] == str[k])
                    {
                        alreadyCounted = true;
                        break;
                    }
                }
                if (alreadyCounted)
                    continue;
                for (int j = 0; j < str.Length; j++)
                {
                    if (str[i] == str[j])
                    {
                        count++;
                    }
                }
                Console.Write(str[i] + ":" + count + ",");
            }
        }

        public static void DuplicateCharacters()
        {
            Console.WriteLine("Enter String");
            string str = Console.ReadLine();
           for (int i = 0; i < str.Length; i++)
            {
                bool isalreadySeen = false;
                for (int k = 0; k < i; k++)
                {
                    if (str[i] == str[k])
                    {
                        isalreadySeen = true;
                        break;
                    }
                }
                if (isalreadySeen)
                    continue;
                for (int j = 0; j < str.Length; j++)
                {
                    if (str[i] == str[j])
                    {
                        Console.Write($"{str[i]} ");
                        break;
                    }
                }
            }
        }

        public static void RemoveDuplicates()
        {
            Console.WriteLine("Enter String");
            string str = Console.ReadLine();
            string str2 = "";
            for (int i = 0; i < str.Length; i++)
            {
                bool isRepeated = false;
                for (int k = 0; k < i; k++)
                {
                    if (str[i] == str[k])
                    {
                        isRepeated = true;
                        break;
                    }
                }
                if (!isRepeated)
                {
                    str2 += str[i];
                }
            }
            Console.WriteLine(str2);
        }


        public static void Anagram()
        {
            Console.WriteLine("Enter first string");
            string str = Console.ReadLine().ToLower().Replace(" ", "");

            Console.WriteLine("Enter second string");
            string str2 = Console.ReadLine().ToLower().Replace(" ", "");

            if (str2.Length != str.Length)
            {
                Console.WriteLine("Not an Anagram");
                return;
            }
            char[] arr = str2.ToCharArray();
            for (int i = 0; i < str.Length; i++)
            {
                bool isFound = false;
                for (int j = 0; j < arr.Length; j++)
                {
                    if (str[i] == arr[j])
                    {
                        isFound = true;
                        arr[j] = '\0';
                        break;
                    }
                }
                if (!isFound)
                {
                    Console.WriteLine("Not an anagram");
                    return;
                }
            }
            Console.WriteLine("Anagram");
        }
        #endregion
    }
}
