using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CSLT_PNBTRAN.On_Tap
{
    internal class Ontapbuoi4
    {
        public static void Main(string[] args)
        {
            //Control flow statements
            //1. Write a program to check whether a triangle is Equilateral, Isosceles or Scalene.
            Console.WriteLine("Bai 1: Write a program to check whether a triangle is Equilateral, Isosceles or Scalene.");
            float a, b, c;
            Console.WriteLine("Vui long nhap do dai canh thu nhat:");
            while (!float.TryParse(Console.ReadLine(), out a) || a <= 0)
            {
                Console.WriteLine("Gia tri ban vua nhap khong hop le, vui long nhap lai");
            }
            Console.WriteLine("Vui long nhap do dai canh thu hai:");
            while (!float.TryParse(Console.ReadLine(), out b) || b <= 0)
            {
                Console.WriteLine("Gia tri ban vua nhap khong hop le, vui long nhap lai");
            }
            Console.WriteLine("Vui long nhap do dai canh thu ba:");
            while (!float.TryParse(Console.ReadLine(), out c) || c <= 0)
            {
                Console.WriteLine("Gia tri ban vua nhap khong hop le, vui long nhap lai");
            }
            if (a == b && a == c)
            {
                Console.WriteLine("The triangle is TAM GIAC DEU");
            }
            else if (a == b || b == c || c == a)
            {
                Console.WriteLine("The triangle is TAM GIAC CAN");
            }
            else if (!(a + b > c && a + c > b && b + c > a))
            {
                Console.WriteLine("Tam giac ban nhap KHONG HOP LE");
            }
            else
            {
                Console.WriteLine("The triangle is TAM GIAC THUONG");
            }
            Console.ReadLine();
            Console.WriteLine("Bai 2: Write a program to read 10 numbers and find their average and sum");



            //2. Write a program to read 10 numbers and find their average and sum.
            double tong = 0;
            int soLuong = 10;
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"Nhap so thu {i}:");
                double sol;
                while (!double.TryParse(Console.ReadLine(), out sol)) ;
                {
                    Console.WriteLine("Khong hop le, nhap lai.");
                }
                tong += sol;
            }
            double avrg = tong / 10;
            Console.WriteLine("Tong: " + tong);
            Console.WriteLine("Trung binh cong: " + avrg);
            Console.ReadLine();


            //3. Write a program to display the multiplication table of a given integer.
            Console.WriteLine("Bai 3: Display the multiplication table of a given integer");

            Console.Write("Nhap mot so nguyen: ");
            int n;
            while (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.Write("Gia tri khong hop le! Vui long nhap lai mot so nguyen: ");
            }

            Console.WriteLine($"\n--- Bang cuu chuong {n} ---");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{n} x {i} = {n * i}");
            }
            Console.ReadLine();

            Console.WriteLine("Bai 4: Display pattern like triangles with a number");

            Console.Write("Nhap so hang (rows): ");
            int N;
            while (!int.TryParse(Console.ReadLine(), out N) || N <= 0)
            {
                Console.Write("So hang phai la so nguyen duong! Nhap lai: ");
            }

            Console.WriteLine("\n--- Pattern 1 ---");
            for (int i = 1; i <= N; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n--- Pattern 2 ---");
            int count = 1;
            for (int i = 1; i <= N; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{count} ");
                    count++;
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n--- Pattern 3 ---");
            count = 1;
            for (int i = 1; i <= N; i++)
            {
                for (int space = 1; space <= N - i; space++)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{count} ");
                    count++;
                }
                Console.WriteLine();
            }

            //6. Write a program to display the n terms of harmonic series and their
            //sum. 1 + 1/2 + 1/3 + 1/4 + 1/5 ... 1/n terms
            Console.WriteLine("Bai 6: Display the n terms of harmonic series and their sum");

            Console.Write("Nhap so luong so hang n: ");
            int R;
            while (!int.TryParse(Console.ReadLine(), out R) || R <= 0)
            {
                Console.Write("n phai la so nguyen duong! Nhap lai: ");
            }

            double sum = 0.0;

            Console.WriteLine("\n--- OUTPUT ---");
            for (int i = 1; i <= R; i++)
            {
                if (i == 1)
                {
                    Console.Write("1 ");
                }
                else
                {
                    Console.Write($"+ 1/{i} ");
                }

                sum += 1.0 / i;
            }
            Console.WriteLine($"\nSum of Series up to {n} terms: {sum:F4}");
            //7. Write a program to find the ‘perfect’ numbers within a given number
            //range.
            Console.WriteLine("Write a program to find the perfect numbers within a given number range.");
            int start, end;
            Console.WriteLine("Nhap so bat dau cua day so");
            while (!int.TryParse(Console.ReadLine(), out start) || start <= 0)
            {
                Console.WriteLine("Khong hop le! Vui long nhap lai!");
            }
            Console.WriteLine("Nhap so ket thuc day so");
            while (!int.TryParse(Console.ReadLine(), out end) || end < start)
            {
                Console.WriteLine("Khong hop le! So ket thuc phai lon hon so bat dau day so");
            }
            Console.WriteLine($"Cac so hoan hao trong khoang [{start},{end}]");
            int num = end - start;
            bool timThay = false;
            int tongUoc = 0;
            for (num = start; num <= end; num++)
            {
                tongUoc = 0;
                for (int i = 1; i < num; i++)
                {
                    if (num % i == 0)
                    {
                        tongUoc += i;
                    }
                }

                if (tongUoc == num)
                {
                    Console.WriteLine($"{num}");
                    timThay = true;
                }
            }
            if (!timThay)
            {
                Console.WriteLine("Khong tim thay so hoan hao nao trong khoang nay! ");
            }
            else
            {
                Console.ReadLine();
            }

            Console.WriteLine("Bai 7: write a program to find perfect numbers in a range of number");
            int batdau, ketthuc;
            Console.WriteLine("Vui long nhap so bat dau");
            while (!int.TryParse(Console.ReadLine(), out batdau) || batdau < 0)
            {
                Console.WriteLine("Khong hop le! Nhap lai!");
            }
            Console.WriteLine("Vui long nhap so ket thuc");
            while (!int.TryParse(Console.ReadLine(), out ketthuc) || ketthuc <= batdau)
            {
                Console.WriteLine("khong hop le! Nhap lai");
            }
            int kiemTra = ketthuc - batdau;
            int congUoc = 0;
            bool found = false; //Chua tim thay
            for (kiemTra = ketthuc; kiemTra <= batdau; kiemTra++)
            {
                for (int i = 1; i < kiemTra; i++)
                {
                    if (kiemTra % i == 0)
                    {
                        tongUoc += i;

                    }
                    if (tongUoc == kiemTra)
                    {
                        Console.WriteLine($"{num}");
                        found = true;
                    }
                    else
                    {
                        Console.WriteLine();
                    }
                }
                
            }
            if (!found)
            {
                Console.WriteLine("Khong tim thay so hoan hao nao");
            }
            Console.ReadLine();
            //8. Write a program to determine whether a given number is prime or not.
            Console.WriteLine("Nhap vao so ban muon kiem tra");
            int so;
            bool laSoNguyenTo = true;
            while (!int.TryParse(Console.ReadLine(), out so))
            {
                Console.WriteLine("Khong hop le! Vui long nhap lai");
            }
            if (so <= 1)
            {
                laSoNguyenTo = false;
            }
            else
            {
                // Kiểm tra các ước từ 2 đến căn bậc hai của số đó
                for (int i = 2; i * i <= so; i++)
                {
                    if (so % i == 0)
                    {
                        laSoNguyenTo = false;
                        break; // Đã tìm thấy ước số thì dừng vòng lặp ngay
                    }
                }
            }

            if (laSoNguyenTo)
            {
                Console.WriteLine("Day la so nguyen to!");
            }
            else
            {
                Console.WriteLine("Day khong phai la so nguyen to!");
            }
            Console.ReadLine();
        }
    }
}
