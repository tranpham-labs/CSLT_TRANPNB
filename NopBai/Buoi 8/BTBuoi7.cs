using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Drawing;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CSLT_PNBTRAN.Buoi_8
{
    internal class BTBuoi7
    {
        static void PrintAString()
        {
            Console.WriteLine(" Bai 1: to input a string and print it.");
            Console.WriteLine("Vui long nhap chuoi ban can in ra: ");
            string inputString = Console.ReadLine();
            Console.WriteLine($"Chuoi vua nhap la: {inputString}");
        }
        static void FindAStringLength()
        {
            Console.WriteLine("Bai 2: to find the length of a string without using a library function.");
            Console.WriteLine("Vui long nhap vao chuoi ban can tinh do dai: ");
            string inputString = Console.ReadLine();
            int length = 0;
            foreach (char c in inputString)
            {
                length++;
            }
            Console.WriteLine($"Do dai cua chuoi la: {length}");
        }
        static void SeparateIndividualCharacters()
        {
            Console.WriteLine("Bai 3: Separate individual character from a string .");
            Console.WriteLine("Vui long nhap vao chuoi ban can tach ky tu: ");
            string inputString = Console.ReadLine();
            Console.WriteLine("Cac ky tu trong chuoi la: ");
            foreach (char c in inputString)
            {
                Console.WriteLine(c);
            }
        }
        static void PrintInidividualCharactersInReverseOrder()
        {
            Console.WriteLine("Bai 4: Print individual characters of the string in reverse order.");
            Console.WriteLine("Vui long nhap vao chuoi ban can in ra theo thu tu nguoc lai: ");
            string inputString = Console.ReadLine();
            Console.WriteLine("Cac ky tu trong chuoi theo thu tu nguoc lai la: ");
            for (int i = inputString.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(inputString[i]);
            }
        }
        static void CountTotalNumberOfWords()
        {
            Console.WriteLine("Bai 5: Count the total number of words in a string.");
            Console.WriteLine("Vui long nhap vao chuoi ban can dem so tu: ");
            string inputString = Console.ReadLine();
            int wordCount = 0;
            string[] words = inputString.Split(new char[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string word in words)
            {
                if (!string.IsNullOrWhiteSpace(word))
                {
                    wordCount++;
                }
            }
            Console.WriteLine($"So tu trong chuoi la: {wordCount}");
        }
        static void CompareTwoStrings()
        {
            Console.WriteLine("Bai 6: Compare two strings without using a string library functions.");
            Console.WriteLine("Vui long nhap vao chuoi thu nhat: ");
            string firstString = Console.ReadLine() ?? "";
            Console.WriteLine("Vui long nhap vao chuoi thu hai: ");
            string secondString = Console.ReadLine() ?? "";
            int length1 = 0;
            int length2 = 0;
            foreach (char c in firstString)
            {
                length1++;
            }
            foreach (char c in secondString)
            {
                length2++;
            }
            if (length1 != length2)
            {
                Console.WriteLine("Hai chuoi khong bang nhau.");
                return;
            }
            for (int i = 0; i < length1; i++)
            {
                if (firstString[i] != secondString[i])
                {
                    Console.WriteLine("Hai chuoi khong bang nhau.");
                    if (firstString[i] < secondString[i])
                    {
                        Console.WriteLine($"Chuoi thu nhat nho hon chuoi thu hai.");
                    }
                    else
                    {
                        Console.WriteLine($"Chuoi thu nhat lon hon chuoi thu hai.");
                    }
                    return;
                }
            }
            Console.WriteLine("Hai chuoi bang nhau.");
        }
        static void CountAlphabetsDigitsSpecialCharacters()
        {
            Console.WriteLine("Bai 7: Count the number of alphabets, digits, and special characters in a string.");
            Console.WriteLine("Vui long nhap vao chuoi ban can dem: ");
            string inputString = Console.ReadLine() ?? "";
            int alphabetCount = 0;
            int digitCount = 0;
            int specialCharCount = 0;
            foreach (char c in inputString)
            {
                if (char.IsLetter(c))
                {
                    alphabetCount++;
                }
                else if (char.IsDigit(c))
                {
                    digitCount++;
                }
                else
                {
                    specialCharCount++;
                }
            }
            Console.WriteLine($"So chu cai: {alphabetCount}");
            Console.WriteLine($"So chu so: {digitCount}");
            Console.WriteLine($"So ky tu dac biet: {specialCharCount}");
        }
        static void CountVowelsConsonants()
        {
            Console.WriteLine("Bai 8: Count the number of vowels or consonants in a string.");
            Console.WriteLine("Vui long nhap vao chuoi ban can dem: ");
            string inputString = Console.ReadLine() ?? "";
            int vowelCount = 0;
            int consonantCount = 0;
            foreach (char c in inputString)
            {
                if (char.IsLetter(c))
                {
                    char lowerChar = char.ToLower(c);
                    if (lowerChar == 'a' || lowerChar == 'e' || lowerChar == 'i' || lowerChar == 'o' || lowerChar == 'u')
                    {
                        vowelCount++;
                    }
                    else
                    {
                        consonantCount++;
                    }
                }
            }
            Console.WriteLine($"So nguyen am: {vowelCount}");
            Console.WriteLine($"So phu am: {consonantCount}");
        }
        static void CheckSubstringPresence()
        {
            Console.WriteLine("Bai 9: Check whether a given substring is present in the given string.");
            Console.WriteLine("Type your main string:");
            string mainString = Console.ReadLine() ?? "";
            Console.WriteLine("Type your substring:");
            string subString = Console.ReadLine() ?? "";
            bool presence = false;
            if (subString.Length > 0 && subString.Length <= mainString.Length)
            {
                for (int i = 0; i <= mainString.Length - subString.Length; i++)
                {
                    bool match = true;
                    for (int j = 0; j < subString.Length; j++)
                    {
                        if (mainString[i + j] != subString[j])
                        {
                            match = false;
                            break;
                        }
                    }

                    if (match)
                    {
                        presence = true;
                        break;
                    }
                }
            }

            if (presence)
            {
                Console.WriteLine("The substring exists in the string.");
            }
            else
            {
                Console.WriteLine("The substring is not found.");
            }
        }
        static void SearchSubstringPosition()
        {
            Console.WriteLine("Bai 10: Search for the position of a substring within a string.");
            Console.WriteLine("Type your main string:");
            string mainString = Console.ReadLine() ?? "";
            Console.WriteLine("Type your substring:");
            string subString = Console.ReadLine() ?? "";
            int position = -1;
            if (subString.Length > 0 && subString.Length <= mainString.Length)
            {
                for (int i = 0; i <= mainString.Length - subString.Length; i++)
                {
                    bool match = true;
                    for (int j = 0; j < subString.Length; j++)
                    {
                        if (mainString[i + j] != subString[j])
                        {
                            match = false;
                            break;
                        }
                    }
                    if (match)
                    {
                        position = i;
                        break;
                    }
                }
            }
            if (position != -1)
            {
                Console.WriteLine($"The substring is found at position: {position}");
            }
            else
            {
                Console.WriteLine("The substring is not found.");
            }
        }
        static void CheckCharacterAlphabetAndCase()
        {
            Console.WriteLine("Bai 11: Check whether a character is an alphabet and not and if so, check for the case.");
            Console.WriteLine("Type your character:");
            char inputChar = Console.ReadKey().KeyChar;
            Console.WriteLine();
            if (char.IsLetter(inputChar))
            {
                if (char.IsUpper(inputChar))
                {
                    Console.WriteLine($"The character '{inputChar}' is an uppercase alphabet.");
                }
                else
                {
                    Console.WriteLine($"The character '{inputChar}' is a lowercase alphabet.");
                }
            }
            else
            {
                Console.WriteLine($"The character '{inputChar}' is not an alphabet.");
            }
        }
        static void CountSubstringOccurrences()
        {
            Console.WriteLine("Bai 12: Find the number of times a substring appears in a given string.");
            Console.WriteLine("Type your main string:");
            string mainString = Console.ReadLine() ?? "";
            Console.WriteLine("Type your substring:");
            string subString = Console.ReadLine() ?? "";
            int count = 0;
            if (subString.Length > 0 && subString.Length <= mainString.Length)
            {
                for (int i = 0; i <= mainString.Length - subString.Length; i++)
                {
                    bool match = true;
                    for (int j = 0; j < subString.Length; j++)
                    {
                        if (mainString[i + j] != subString[j])
                        {
                            match = false;
                            break;
                        }
                    }
                    if (match)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine($"The substring appears {count} times in the main string.");
        }
        static void InsertSubstringBeforeFirstOccurrence()
        {
            Console.WriteLine("Bai 13: Insert a substring before the first occurrence of a string.");
            Console.WriteLine("Type your main string:");
            string mainString = Console.ReadLine() ?? "";
            Console.WriteLine("Type the substring to insert:");
            string subStringToInsert = Console.ReadLine() ?? "";
            Console.WriteLine("Type the target substring to find:");
            string targetSubstring = Console.ReadLine() ?? "";
            int position = -1;
            if (targetSubstring.Length > 0 && targetSubstring.Length <= mainString.Length)
            {
                for (int i = 0; i <= mainString.Length - targetSubstring.Length; i++)
                {
                    bool match = true;
                    for (int j = 0; j < targetSubstring.Length; j++)
                    {
                        if (mainString[i + j] != targetSubstring[j])
                        {
                            match = false;
                            break;
                        }
                    }
                    if (match)
                    {
                        position = i;
                        break;
                    }
                }
            }
            if (position != -1)
            {
                string resultString = mainString.Substring(0, position) + subStringToInsert + mainString.Substring(position);
                Console.WriteLine($"The new string after insertion is: {resultString}");
            }
            else
            {
                Console.WriteLine("The target substring is not found in the main string.");
            }
        }
        
        public static void Main(string[] args)
        {
            PrintAString();
            FindAStringLength();
            SeparateIndividualCharacters();
            PrintInidividualCharactersInReverseOrder();
            CountTotalNumberOfWords();
            CompareTwoStrings();
            CountAlphabetsDigitsSpecialCharacters();
            CountVowelsConsonants();
            CheckSubstringPresence();
            SearchSubstringPosition();
            CheckCharacterAlphabetAndCase();
            CountSubstringOccurrences();
            InsertSubstringBeforeFirstOccurrence();
        }
//Write a program in C# Sharp
//-to input a string and print it.
//-to find the length of a string without using a library function.
//-to separate individual characters from a string.
//-to print individual characters of the string in reverse order.
//-to count the total number of words in a string.
//-to compare two strings without using a string library functions.
//-to count the number of alphabets, digits, and special characters in a string.
//-to count the number of vowels or consonants in a string.
//-to check whether a given substring is present in the given string.
//-to search for the position of a substring within a string.
//-to check whether a character is an alphabet and not and if so, check for the case.
//-to find the number of times a substring appears in a given string.
//-to insert a substring before the first occurrence of a string.

        
    }
}
