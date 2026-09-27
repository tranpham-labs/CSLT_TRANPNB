using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Threading.Channels;
using System.Xml.Serialization;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CSLT_PNBTRAN.On_Tap
{
    internal class ontapbuoi1
    {
        static void Bai1()
        { //Write programs that:
          //1.to Add / Sum Two Numbers.
            Console.WriteLine(" Bai 1: Add/Sum two number");
            float a, b;
            Console.WriteLine("Vui long nhap so thu nhat: ");
            while (!float.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Khong hop le! Vui long nhap lai so thu nhat:");
            }
            Console.WriteLine("Vui long nhap so thu hai"); 
            while (!float.TryParse(Console.ReadLine(), out b))
            {
                Console.WriteLine("Khong hop le!Vui long nhap lai so thu hai");
            }
            Console.WriteLine($"Tong cua hai so la: {a + b}");
        }
        static void Bai2()
        {
            Console.WriteLine("Bai 2: Swap Values of Two Variables");
            float a, b, swap;
            Console.WriteLine("Vui long nhap so thu nhat");
            while (!float.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Gia tri vua nhap khong hop le! Vui long nhap lai so thu nhat");
            }
            Console.WriteLine("Vui long nhap so thu hai");
            while (!float.TryParse(Console.ReadLine(), out b))
            {
                Console.WriteLine("Gia tri vua nhap khong hop le! Vui long nhap lai so thu hai");
            }
            Console.WriteLine("Gia tri truoc khi hoan doi: ");
            Console.WriteLine($"a = {a}, b = {b}");
            Console.WriteLine("Gia tri sau khi hoan doi: ");
            Console.WriteLine($"a = {b}, b = {a}");
            Console.ReadLine();
        }
        static void Bai3()
        {
            Console.WriteLine("Bai 3: Multiply two Floating Point Numbers");
            float a, b;
            Console.WriteLine("Vui long nhap so thu nhat");
            while( !float.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Khong hop le! Vui long nhap lai so thu nhat");
            }
            Console.WriteLine("Vui long nhap so thu hai");
            while(!float.TryParse(Console.ReadLine(), out b))
            {
                Console.WriteLine("Khong hople! Vui long nhap lai so thu hai");
            }
            Console.WriteLine("Tich cua hai so la: " + (a * b));
            Console.ReadLine(); 
        }
        static void Bai4()
        {
            Console.WriteLine("Bai 4: Convert feet to meter");
            float feet, meter;
            Console.WriteLine("Vui long nhap so feet can chuyen doi: ");
            while (!float.TryParse(Console.ReadLine(), out feet))
            {
                Console.WriteLine("Khong hop le! Vui long nhap lai so feet");
            }
            Console.WriteLine("So meter tuong ung la: " + (feet * 0.3048));
            Console.ReadLine();
        }
        static void Bai5()
        {
            Console.WriteLine("Bai 5: Convert Celsius to Fahrenheit and vice versa");
            float celsius, fahrenheit;
            Console.WriteLine("Ban muon chuyen doi tu Celsius sang Fahrenheit hay tu Fahrenheit sang Celsius? (Nhap C hoac F)");
            string choice = Console.ReadLine().ToUpper();

            while (choice != "C" && choice != "F")
            {
                Console.WriteLine("Lua chon khong hop le! Vui long nhap lai C hoac F");
                choice = Console.ReadLine().ToUpper();
            }   

            if (choice == "C")
            {
                Console.WriteLine("Vui long nhap nhiet do celsius can chuyen doi: ");
                while (!float.TryParse(Console.ReadLine(), out celsius))
                {
                    Console.WriteLine("Khong hop le! Vui long nhap lai nhiet do celsius");
                }
                Console.WriteLine("Nhiet do Fahrenheit tuong ung la: " + (celsius * 9 / 5 + 32));
            }
            else 
            {
                Console.WriteLine("Vui long nhap nhiet do Fahrenheit can chuyen doi: ");
                while(!float.TryParse(Console.ReadLine(), out fahrenheit))
                {
                    Console.WriteLine("Khong hop le! Vui long nhap lai nhiet do Fahrenheit");
                }
                Console.WriteLine("Nhiet do Celsius tuong ung la: " + (fahrenheit - 32) * 5 / 9);
            }
            Console.ReadLine();
        }
        static void Bai6()
        {
            Console.WriteLine("Bai 6: find the size of data types");
            Console.WriteLine("Vui long chon data type can tim size (1 - int, 2 - float, 3 - double, 4 - char): ");
            int choice;
            while (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Khong hop le! Vui long nhap lai 1 - int, 2 - float, 3 - double, 4 - char");
            }
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Size of int: " + sizeof(int) + " bytes");
                    break;
                case 2:
                    Console.WriteLine("Size of float: " + sizeof(float) + " bytes");
                    break;
                case 3:
                    Console.WriteLine("Size of double: " + sizeof(double) + " bytes");
                    break;
                case 4:
                    Console.WriteLine("Size of char: " + sizeof(char) + " bytes");
                    break;
            }
            Console.ReadLine();
        }
        static void Bai7()
        {
            Console.WriteLine("Bai 7: Print ASCII Value");
            Console.WriteLine("Vui long nhap ky tu can in ASCII value: ");
            char inputChar = Console.ReadKey().KeyChar;
            int asciiValue = (int)inputChar;
            Console.WriteLine("ASCII Value of" + inputChar + "is:" + asciiValue); 
            Console.ReadLine();
        }
        static void Bai8()
        {
            Console.WriteLine("Bai 8: Calculate Area of Circle");
            Console.WriteLine("Bai 8: Vui long nhap ban kinh hinh tron: ");
            float radius;
            while (!float.TryParse(Console.ReadLine(), out radius))
            {
                Console.WriteLine("Khong hop le! Vui long nhap lai ban kinh hinh tron");
            }
            Console.WriteLine("Dien tich hinh tron la" + (Math.PI * Math.Pow(radius, 2)));
            Console.ReadLine();
        }
        static void Bai9()
        {
            Console.WriteLine("Bai 9: Calculate area of square");
            Console.WriteLine("Bai 9: Vui long nhap canh hinh vuong: ");
            float canh;
            while (!float.TryParse(Console.ReadLine(), out canh))
            {
                Console.WriteLine("Khong hop le! Vui long nhap lai canh hinh vuong");
            }
            Console.WriteLine("Dien tich hinh vuong la" + Math.Pow(canh,2));
            Console.ReadLine();
        }
        static void Bai10()
        {
            Console.WriteLine("Bai 10: Convert days to years, weeks and days");
            Console.WriteLine("Bai 10: Vui long nhap so ngay can chuyend doi: ");
            int days;
            while (!int.TryParse(Console.ReadLine(), out days))
            {
                Console.WriteLine("Khong hop le! Vui long nhap lai so ngay");
            }
            Console.WriteLine("So nam tuong ung la : " + (days / 365));
            Console.WriteLine("So tuan tuong ung la : " + (days % 365) / 7);
            Console.WriteLine("So ngay tuong ung la : " + (days % 365) % 7);
            Console.ReadLine();
        }
        public static void Main(string[] args)
        {
            Bai1();
            Bai2();
            Bai3();
            Bai4();
            Bai5();
            Bai6();
            Bai7();
            Bai8();
            Bai9();
            Bai10();
        }
    }
}
