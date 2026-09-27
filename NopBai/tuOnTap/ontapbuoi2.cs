using CSLT_PNBTRAN.Buoi2;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CSLT_PNBTRAN.On_Tap
{
    internal class ontapbuoi2
    {
        //Exercises
        //▸The Celsius scale is centigrade, 100 divisions separate the freezing point from the boiling point of water.On the Fahrenheit scale of Anglo - Saxons,
        //these two points are 180 degrees apart.The Kelvin scale is an absolute scale used in science.
        //▸Create a C# program to convert from degrees Celsius to Kelvin and Fahrenheit. Request the user the number of degrees celsius to convert
        //them using the following conversion tables:
        //- kelvin = celsius + 273
        //- fahrenheit = celsius x 18 / 10 + 32
        //- Input
        //• 33
        //- Output
        //• kelvin= 306
        //• fahrenheit= 91
        static void Bai1()
        {
        Console.WriteLine("Bai 1: Convert from degrees Celsius to Kelvin and fahrenheit"); 
        Console.WriteLine("Vui long nhap nhiet do Celsius can chuyen doi: ");
            float celsius;
            while (!float.TryParse(Console.ReadLine(), out celsius))
            {
                Console.WriteLine("Gia tri vua nhap khong hop le! Vui long nhap lai nhiet do Celsius can chuyen doi: ");
            }
            float kelvin = celsius + 273;
            float fahrenheit = celsius * 18 / 10 + 32;
            Console.WriteLine($"Chuyen doi nhiet do tu {celsius}Celsius sang Kelvin va Fahrenheit:" );
            Console.WriteLine($"Kelvin: {kelvin}");
            Console.WriteLine($"Fahrenheit: {fahrenheit}");
            Console.ReadLine();
        }
        static void Bai2()
        {
            //Create a program in C# for calculate the surface and volume of a sphere, given its radius.
            //-surface = 4 * pi * radius squared
            //- volume = 4 / 3 * pi * radius cubed
            //- Input
            //• 60
            //- Output
            //• Surface: 45238,93
            //• Volume: 678584,1
            //▸Write a program in C# that calculates the result of adding, subtracting,
            //multiplying and dividing two numbers entered by the user.
            //-In addition you should also calculate the rest of the division on the last line.
            //-Input
            //• 12
            //• 3
            //- Output
            //• 12 + 3 = 15
            //• 12 - 3 = 9
            //• 12 x 3 = 36
            //• 12 / 3 = 4
            //• 12 mod 3 = 0
            Console.WriteLine("Bai 2: Tinh dien tich va the tich hinh cau");
            Console.WriteLine("Vui long nhap ban kinh hinh cau");
            float radius;
            while (!float.TryParse(Console.ReadLine(), out radius))
            {
                Console.WriteLine("Gia tri vua nhap khong hop le! Vui long nhap lai ban kinh hinh cau");
            }
            float dienTich = 4 * (float)Math.PI * (float)Math.Pow(radius,2);
            float theTich = 4 / 3 * (float)Math.PI * (float)Math.Pow(radius, 3);
            Console.WriteLine($"Dien tich hinh cau la: {dienTich}");
            Console.WriteLine($"The tich hinh cau la: {theTich}");
            Console.ReadLine();
        }
        static void Bai3()
        {
            Console.WriteLine("Bai 3: Tinh tong, hieu, tich, thuong va du cua hai so");
            Console.WriteLine("Vui long nhap so thu nhat: ");
            float a;
            while (!float.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Gia tri vua nhap khong hop le! Vui long nhap lai so thu nhat");
            }
            Console.WriteLine("Vui long nhap so thu hai: ");
            float b;
            while (!float.TryParse(Console.ReadLine(), out b))
            {
                Console.WriteLine("Gia tri vua nhap khong hop le! Vui long nhap lai so thu hai");
            }
            float tong = a + b;
            float hieu = a - b;
            float tich = a * b;
            float thuong = a / b;
            float du = a % b;
            Console.WriteLine($"Tong cua {a} va {b} la: {tong}");
            Console.WriteLine($"Hieu cua {a} va {b} la: {hieu}");
            Console.WriteLine($"Tich cua {a} va {b} la: {tich}");
            Console.WriteLine($"Thuong cua {a} va {b} la: {thuong}");
            Console.WriteLine($"Du cua {a} va {b} la: {du}");
            Console.ReadLine();
        }
        public static void Main(string[] args)
        {
            Bai1();
            Bai2();
            Bai3();
        }
    }

}
