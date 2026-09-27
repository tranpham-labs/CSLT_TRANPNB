using System;
using System.Collections.Generic;
using System.Text;

namespace CSLT_PNBTRAN.Buoi6
{
    internal class BaiTapTrongSlide
    {
        class Exercises
        {
            public static int FindMax(int a, int b, int c)
            {
                return Math.Max(a, Math.Max(b, c));
            }

            public static int FindMaxImproved(int first, params int[] rest)
            {
                int max = first;
                foreach (int val in rest)
                {
                    if (val > max)
                    {
                        max = val;
                    }
                }
                return max;
            }

            public static long Factorial(int n)
            {
                if (n < 0) throw new ArgumentException("Số truyền vào phải là số không âm");
                long result = 1;
                for (int i = 2; i <= n; i++)
                {
                    result *= i;
                }
                return result;
            }

            public static bool IsPrime(int n1)
            {
                if (n1 < 2) return false;
                for (int i = 2; i <= n1 / 2; i++)
                {
                    if (n1 % i == 0) return false;
                }
                return true;
            }

            public static void PrintPrimeLessThan(int n2)
            {
                for (int i = 2; i < n2; i++)
                {
                    if (IsPrime(i))
                    {
                        Console.Write(i + ", ");
                    }
                }
                Console.WriteLine();
            }

            public static void PrintFirstNPrime(int n3)
            {
                int count = 0;
                int currentNumber = 2;
                while (count < n3)
                {
                    if (IsPrime(currentNumber))
                    {
                        Console.WriteLine(currentNumber + ", ");
                        count++;
                    }
                    currentNumber++;
                }
                Console.WriteLine();
            }

            public static bool IsPerfectNumber(int n4)
            {
                if (n4 <= 1) return false;
                int sum = 0;
                for (int i = 1; i < n4; i++)
                {
                    if (n4 % i == 0)
                    {
                        sum += i;
                    }
                }
                return sum == n4;
            }
            public static void PrintAllPerfectNumerLessThan1000()
            {
                for (int i = 0; i < 1000; i++)
                {
                    if (IsPerfectNumber(i))
                    {
                        Console.Write(i + ", ");
                    }
                }
                Console.WriteLine();
            }
            public static void Main(string[] args)
            {
                Console.WriteLine("---Bài 1---");
                Console.WriteLine("Nhập vào các số nguyên: ");
                int a = int.Parse(Console.ReadLine() ?? "0");
                int b = int.Parse(Console.ReadLine() ?? "0");
                int c = int.Parse(Console.ReadLine() ?? "0");
                int soLonNhat = FindMax(a, b, c);
                Console.WriteLine($"Số lớn nhất trong ba số là: {soLonNhat}");

                Console.WriteLine("---Bài 1b---");
                int max = FindMaxImproved(34, 5, 6, 7, 7, 5, 433, 67, 89);
                Console.WriteLine($"Số lớn nhất trong dãy số là: {max}");


                Console.WriteLine("---Bài 2---");
                Console.WriteLine("Nhập vào số nguyên dương n: ");
                int n = int.Parse(Console.ReadLine() ?? " ");
                long giaiThua = Factorial(n);
                Console.WriteLine($"Giai thừa của {n} là:  {giaiThua}");

                Console.WriteLine("---Bài 3---");
                Console.WriteLine("Nhập vào số nguyên dương n: ");
                int n1 = int.Parse(Console.ReadLine() ?? "0");
                bool nguyenTo = IsPrime(n1);
                if (nguyenTo)
                {
                    Console.WriteLine($"{n1} là số nguyên tố");
                }
                else
                {
                    Console.WriteLine($"{n1} không phải là số nguyên tố");
                }

                Console.WriteLine("---Bài 4.1---");
                Console.WriteLine("Nhập một số nguyên dương n: ");
                int n2 = int.Parse(Console.ReadLine() ?? " ");
                Console.WriteLine($"Các số nguyên tố nhỏ hơn {n2} là: ");
                PrintPrimeLessThan(n2);

                Console.WriteLine("---Bài 4.2---");
                Console.WriteLine("Nhập số nguyên dương n: ");
                int n3 = int.Parse(Console.ReadLine() ?? " ");
                Console.WriteLine($"{n3} số nguyên tố đầu tiên là: ");
                PrintFirstNPrime(n3);

                Console.WriteLine("---Bài 5---");
                Console.WriteLine("Nhập vào số nguyên dương n: ");
                int n4 = int.Parse(Console.ReadLine() ?? " ");
                bool soHoanHao = IsPerfectNumber(n4);
                if (soHoanHao)
                {
                    Console.WriteLine($"{n4} là số hoàn hảo");
                }
                else
                {
                    Console.WriteLine($"{n4} không phải là số hoàn hảo");
                }
                Console.WriteLine("Các số hoàn hảo dưới 1000 là: ");
                PrintAllPerfectNumerLessThan1000();
            }
        }
    }
}
