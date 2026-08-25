using System;
using System.Collections.Generic;
using System.Text;

namespace CSLT_PNBTRAN.Buoi3
{
    internal class BTtrongSLide
    {
        public static void Main(string[] args)
        {
            //Create a C# program to convert from degrees Celsius to Kelvin and
            //Fahrenheit. Request the user the number of degrees celsius to convert
            //them using the following conversion tables:
            //-kelvin = celsius + 273
            //- fahrenheit = celsius x 18 / 10 + 32
            //- Input
            //• 33
            //- Output
            //• kelvin = 306
            //• fahrenheit = 91
            Console.WriteLine("Xin chao, day la Chuong trinh 1: Chuyen doi nhiet do");
            float celsius, kelvin, fahrenheit;
            Console.WriteLine("Xin moi nhap nhiet do theo Celsius:");
            celsius = float.Parse(Console.ReadLine());
            kelvin = celsius + 273;
            fahrenheit = celsius * 18 / 10 + 32;
            Console.WriteLine($"Kelvin = {kelvin}");
            Console.WriteLine($"Fahrenheit = {fahrenheit}");
            Console.WriteLine("Nhan enter de tiep tuc");
            Console.ReadLine();

            //Create a program in C# for calculate the surface and volume of a sphere, given its radius.
            //-surface = 4 * pi * radius squared
            //- volume = 4 / 3 * pi * radius cubed
            //- Input
            //• 60
            //- Output
            //• Surface: 45238,93
            //• Volume: 678584,1
            Console.WriteLine("Bai 2: Chuong trinh tinh dien tich va the tich hinh cau");
            double surface, volume, radius;
            Console.WriteLine("Xin moi nhap ban kinh hinh cau:");
            radius = double.Parse(Console.ReadLine());
            surface = 4 * Math.PI * radius * radius;
            volume = 4.0 / 3 * Math.PI * radius * radius * radius;
            Console.WriteLine($"Surface: {surface:F2}");
            Console.WriteLine($"Volume: {volume:F2}");
            Console.WriteLine("Nhan enter de tiep tuc");
            Console. ReadLine();

            //Write a program in C# that calculates the result of adding, subtracting,multiplying and dividing two numbers entered by the user.
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
            Console.WriteLine("Bai 3: Chuong trinh tinh toan tren hai so");
            float num1, num2;
            Console.WriteLine("Xin moi nhap so thu nhat:");
            num1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Xin moi nhap so thu hai:");
            num2 = float.Parse(Console.ReadLine());
            Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
            Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
            Console.WriteLine($"{num1} x {num2} = {num1 * num2}");
            if (num2 != 0)
            {
                Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
                Console.WriteLine($"{num1} mod {num2} = {num1 % num2}");
            }
            else
            {
                Console.WriteLine("Khong the chia cho 0, vui long nhap so khac 0");
            }
            Console.WriteLine("Chuc ban mot ngay tot lanh!");
            Console.ReadLine();
        }
    }
}
