using System;
using System.Collections.Generic;
using System.Text;

namespace CSLT_PNBTRAN.Buoi6
{
    internal class Ex2
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("CHƯƠNG TRÌNH SẮP XẾP NỔI BỌT");
            int[] mangSoNguyen = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Nhập số thứ {0}: ", i + 1);
                mangSoNguyen[i] = int.Parse(Console.ReadLine());
            }

            SapXepNoiBot(mangSoNguyen);

            Console.WriteLine("Mảng sau khi sắp xếp tăng dần:");
            for (int i = 0; i < 10; i++)
            {
                Console.Write("{0} ", mangSoNguyen[i]);
            }
            Console.WriteLine();

            Console.WriteLine("\n=== CHƯƠNG TRÌNH TÌM KIẾM TUYẾN TÍNH ===");
            Console.Write("Nhập vào một câu bất kỳ: ");
            string cau = Console.ReadLine();

            Console.Write("Nhập vào từ cần tìm kiếm: ");
            string tuCanTim = Console.ReadLine();

            string[] danhSachTu = cau.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int viTri = TimKiemTuyenTinh(danhSachTu, tuCanTim);

            if (viTri != -1)
            {
                Console.WriteLine("Từ '{0}' xuất hiện trong câu tại vị trí từ số {1}.", tuCanTim, viTri + 1);
            }
            else
            {
                Console.WriteLine("Từ '{0}' không xuất hiện trong câu.", tuCanTim);
            }
        }

        public static void SapXepNoiBot(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int tam = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = tam;
                    }
                }
            }
        }

        public static int TimKiemTuyenTinh(string[] arr, string target)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Equals(target, StringComparison.OrdinalIgnoreCase))
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
