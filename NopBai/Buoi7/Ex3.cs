using System;
using System.Collections.Generic;
using System.Text;

namespace CSLT_PNBTRAN.Buoi6
{
    internal class Ex3
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.Write("Nhập số hàng N: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Nhập số cột M: ");
            int m = int.Parse(Console.ReadLine());

            int[,] maTrận = TaoMaTrậnNgauNhien(n, m);

            Console.WriteLine("Ma trận ngẫu nhiên");
            InMaTrận(maTrận);

            Console.Write("\nNhập chỉ số hàng i cần xem và tìm min (0 đến {0}): ", n - 1);
            int hangI = int.Parse(Console.ReadLine());

            Console.Write("Nhập chỉ số cột i cần xem và tìm min (0 đến {0}): ", m - 1);
            int cotI = int.Parse(Console.ReadLine());

            Console.WriteLine("\n--- Hàng thứ {0} ---", hangI);
            InHang(maTrận, hangI);

            Console.WriteLine("\n--- Cột thứ {0} ---", cotI);
            InCot(maTrận, cotI);

            int maxVal = TimMaxMaTrận(maTrận);
            Console.WriteLine("\nGiá trị lớn nhất của ma trận là: {0}", maxVal);

            int minHang = TimMinHang(maTrận, hangI);
            Console.WriteLine("Giá trị nhỏ nhất của hàng {0} là: {1}", hangI, minHang);

            int minCot = TimMinCot(maTrận, cotI);
            Console.WriteLine("Giá trị nhỏ nhất của cột {0} là: {1}", cotI, minCot);

            int[,] maTrậnChuyenVi = ChuyenViMaTrận(maTrận);
            Console.WriteLine("\n--- Ma trận chuyển vị ---");
            InMaTrận(maTrậnChuyenVi);

            if (n == m)
            {
                Console.WriteLine("\n--- Các phần tử đường chéo chính ---");
                InDuongCheoChinh(maTrận);

                Console.WriteLine("\n--- Các phần tử đường chéo phụ ---");
                InDuongCheoPhu(maTrận);
            }
            else
            {
                Console.WriteLine("\nMa trận không phải là ma trận vuông nên không thể in đường chéo chính và phụ.");
            }
        }

        public static int[,] TaoMaTrậnNgauNhien(int n, int m)
        {
            int[,] matrix = new int[n, m];
            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = rand.Next(1, 100);
                }
            }
            return matrix;
        }

        public static void InMaTrận(int[,] matrix)
        {
            int n = matrix.GetLength(0);
            int m = matrix.GetLength(1);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write("{0,-5}", matrix[i, j]);
                }
                Console.WriteLine();
            }
        }

        public static void InHang(int[,] matrix, int i)
        {
            int m = matrix.GetLength(1);
            for (int j = 0; j < m; j++)
            {
                Console.Write("{0} ", matrix[i, j]);
            }
            Console.WriteLine();
        }

        public static void InCot(int[,] matrix, int i)
        {
            int n = matrix.GetLength(0);
            for (int j = 0; j < n; j++)
            {
                Console.WriteLine("{0}", matrix[j, i]);
            }
        }

        public static int TimMaxMaTrận(int[,] matrix)
        {
            int max = matrix[0, 0];
            int n = matrix.GetLength(0);
            int m = matrix.GetLength(1);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (matrix[i, j] > max)
                    {
                        max = matrix[i, j];
                    }
                }
            }
            return max;
        }

        public static int TimMinHang(int[,] matrix, int i)
        {
            int m = matrix.GetLength(1);
            int min = matrix[i, 0];
            for (int j = 1; j < m; j++)
            {
                if (matrix[i, j] < min)
                {
                    min = matrix[i, j];
                }
            }
            return min;
        }

        public static int TimMinCot(int[,] matrix, int i)
        {
            int n = matrix.GetLength(0);
            int min = matrix[0, i];
            for (int j = 1; j < n; j++)
            {
                if (matrix[j, i] < min)
                {
                    min = matrix[j, i];
                }
            }
            return min;
        }

        public static int[,] ChuyenViMaTrận(int[,] matrix)
        {
            int n = matrix.GetLength(0);
            int m = matrix.GetLength(1);
            int[,] result = new int[m, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    result[j, i] = matrix[i, j];
                }
            }
            return result;
        }

        public static void InDuongCheoChinh(int[,] matrix)
        {
            int n = matrix.GetLength(0);
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0} ", matrix[i, i]);
            }
            Console.WriteLine();
        }

        public static void InDuongCheoPhu(int[,] matrix)
        {
            int n = matrix.GetLength(0);
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0} ", matrix[i, n - 1 - i]);
            }
            Console.WriteLine();
        }
    }
}
