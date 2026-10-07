using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CSLT_PNBTRAN.Buoi_8
{
    internal class BTBuoi8
    {
        static void CreateBlankFile(string filePath)
        {
            using (FileStream fs = File.Create(filePath))
            {
            }
        }
        static void RemoveFile(string filePath)
        {
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
        }
        static void CreateFileWithText(string filePath, string text)
        {
            File.WriteAllText(filePath, text);
        }
        static void ReadTextFile(string filePath)
        {
            if (File.Exists(filePath))
            {
                string content = File.ReadAllText(filePath);
                Console.WriteLine(content);
            }
        }
        static void WriteArrayToFile(string filePath, string[] lines)
        {
            File.WriteAllLines(filePath, lines);
        }
        static void AppendTextToFile(string filePath, string text)
        {
            File.AppendAllText(filePath, text);
        }
        static void CopyFile(string sourceFilePath, string destinationFilePath)
        {
            File.Copy(sourceFilePath, destinationFilePath, true);
        }
        static void MoveFile(string sourceFilePath, string destinationFilePath)
        {
            File.Move(sourceFilePath, destinationFilePath);
        }
        static string ReadFirstLine(string filePath)
        {
            if (File.Exists(filePath))
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    return sr.ReadLine();
                }
            }
            return null;
        }
        static string ReadLastLine(string filePath)
        {
            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);
                return lines.Length > 0 ? lines[lines.Length - 1] : null;
            }
            return null;
        }
        static string[] ReadLastNLines(string filePath, int n)
        {
            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);
                int startLine = Math.Max(0, lines.Length - n);
                return lines[startLine..];
            }
            return null;
        }
        static string ReadSpecificLine(string filePath, int lineNumber)
        {
            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);
                if (lineNumber >= 1 && lineNumber <= lines.Length)
                {
                    return lines[lineNumber - 1];
                }
            }
            return null;
        }
        static int CountLinesInFile(string filePath)
        {
            if (File.Exists(filePath))
            {
                return File.ReadAllLines(filePath).Length;
            }
            return 0;
        }
        static void PrintFolderStructure(string folderPath)
        {
            if (Directory.Exists(folderPath))
            {
                string[] files = Directory.GetFiles(folderPath);
                foreach (string file in files)
                {
                    Console.WriteLine(file);
                }
            }
        }
        static void CalculateCharacterStatistics(string filePath)
        {
            if (File.Exists(filePath))
            {
                string content = File.ReadAllText(filePath);
                Dictionary<char, int> charCount = new Dictionary<char, int>();
                foreach (char c in content)
                {
                    if (charCount.ContainsKey(c))
                    {
                        charCount[c]++;
                    }
                    else
                    {
                        charCount[c] = 1;
                    }
                }
                foreach (var kvp in charCount)
                {
                    Console.WriteLine($"Character: {kvp.Key}, Count: {kvp.Value}");
                }
            }
        }
        static void Main(string[] args)
        {
            // Example usage of the methods
            string filePath = "example.txt";
            CreateBlankFile(filePath);
            CreateFileWithText(filePath, "Hello, World!");
            ReadTextFile(filePath);
            WriteArrayToFile(filePath, new string[] { "Line 1", "Line 2", "Line 3" });
            AppendTextToFile(filePath, "\nAppended Line");
            CopyFile(filePath, "copy_example.txt");
            MoveFile("copy_example.txt", "moved_example.txt");
            Console.WriteLine($"First Line: {ReadFirstLine(filePath)}");
            Console.WriteLine($"Last Line: {ReadLastLine(filePath)}");
            Console.WriteLine($"Last 2 Lines: {string.Join(", ", ReadLastNLines(filePath, 2))}");
            Console.WriteLine($"Specific Line (2): {ReadSpecificLine(filePath, 2)}");
            Console.WriteLine($"Total Lines: {CountLinesInFile(filePath)}");
            PrintFolderStructure(".");
            CalculateCharacterStatistics(filePath);
        }
        //1.Write a program in C# Sharp
        //1.to create a blank file on the disk.
        //2.to remove a file from the disk.
        //3.to create a file and add some text.
        //4.create a text file and read it.
        //5.to create a file and write an array of strings to the file.
        //6.to append some text to an existing file.
        //7.to create and copy the file to another name and display the content.
        //8.create a file and move it into the same directory with another name.
        //9.read the first line of a file.
        //10.to create and read the last line of a file.
        //11.create and read the last n lines of a file.
        //12.to read a specific line from a file.
        //13.to count the number of lines in a file.
        //14.To print the structure of specific folder (include files)
        //15.Read a text file, then calculate the statistics of the appearance of characters and numbers. (Hint: dùng mảng chữ nhật để xử lý.
        //Trường hợp yêu cầu thêm ký tự xuất hiện ở các vị trí nào của file (dòng, cột) à dùng jagged array)

    }
}
