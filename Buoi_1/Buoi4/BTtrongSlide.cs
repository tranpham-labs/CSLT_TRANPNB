using System;
using System.Collections.Generic;
using System.Text;

namespace CSLT_PNBTRAN.Buoi4
{
    internal class BTtrongSlide
    {
        static void Bai1()
        {
            //Write a C# Sharp program to check whether a given number is even or odd 
            Console.WriteLine("Xin chao, chuc ban mot ngay tot lanh! ");
            Console.WriteLine("Bai 1: Check whether a given number is even or odd ");
            Console.WriteLine("Xin moi nhap so can kiem tra");
            int so = int.Parse(Console.ReadLine());
            if (so % 2 == 0)
            {
                Console.WriteLine($"So {so} la so chan");
            }
            else
            {
                Console.WriteLine($"So {so} la so le");
            }
            Console.WriteLine("Nhan enter de tiep tuc");
            Console.ReadLine();
        }
        static void Bai2()
        {
            //Write a C# Sharp program to find the largest of three numbers
            Console.WriteLine(" Bai 2: Find the largest of three numbers");
            Console.WriteLine("Xin moi nhap so thu nhat");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("Xin moi nhap so thu hai");
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine("Xin moi nhap so thu ba");
            float c = float.Parse(Console.ReadLine());
            Console.WriteLine($"So lon nhat trong ba so la {Math.Max(Math.Max(a, b), c)}");
            Console.WriteLine("Nhan enter de tiep tuc");
            Console.ReadLine();
        }
        static void Bai3()
        {
            //Write a C# Sharp program to accept a coordinate point in an XY coordinate system and determine in which quadrant the coordinate point lies.
            Console.WriteLine("Bai 3: Accept a coordinate point in an XY coordinate sysyem and determine in which quadrant the coordinate point lies");
            Console.WriteLine("Xin moi nhap toa do x");
            float x = float.Parse(Console.ReadLine());
            Console.WriteLine("Xin moi nhap toa do y");
            float y = float.Parse(Console.ReadLine());
            if (x == 0 && y == 0)
            { Console.WriteLine("Diem nam o goc toa do"); }
            else if (x == 0 && y != 0)
            { Console.WriteLine("Diem nam tren truc tung Oy"); }
            else if (x != 0 && y == 0)
            { Console.WriteLine("Diem nam tren truc hoanh Ox"); }
            else if (x > 0 && y > 0)
            { Console.WriteLine("Diem thuoc goc phan tu thu nhat"); }
            else if (x < 0 && y < 0)
            { Console.WriteLine("Diem thuoc goc phan tu thu hai"); }
            else if (x > 0 && y < 0)
            { Console.WriteLine("Diem thuoc goc phan tu thu ba"); }
            else if (x < 0 && y > 0)
            { Console.WriteLine("Diem thuoc goc phan tu thu tu"); }
            Console.WriteLine("Nhan Enter de tiep tuc");
            Console.ReadLine();
        }
        static void Bai4()
        {
            //Write a program to check whether a triangles is Equilateral, Isosceles or Scalene
            Console.WriteLine("Bai 4: Check whether a triangles is Equilateral, Isosceles or Scalene");
            Console.WriteLine("Xin moi nhap canh thu nhat");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("Xin moi nhap canh thu hai");
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine("Xin moi nhap canh thu ba");
            float c = float.Parse(Console.ReadLine());
            if (a == b && b == c)
            {
                Console.WriteLine("Tam giac deu");
            }
            else if (a == b || b == c || a == c)
            {
                Console.WriteLine("Tam giac can");
            }
            else
            {
                Console.WriteLine("Tam giac thuong");
            }
            Console.WriteLine("Nhan enter de tiep tuc");
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            Bai1();
            Bai2();
            Bai3();
            Bai4();
        }
    }
}

    

