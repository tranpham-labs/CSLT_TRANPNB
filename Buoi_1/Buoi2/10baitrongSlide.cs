using System;
using System.Collections.Generic;
using System.Text;

namespace CSLT_PNBTRAN.Buoi2
{
    internal class _10baitrongSlide
    {
        public static void Main(string[] args)
        {

            //        Write programs that:
            //1. to Add / Sum Two Numbers.
            Console.WriteLine("Xin chao, chuc ban mot ngay moi tot lanh");
            Console.WriteLine("Bai 1: Add/Sum Two Numbers");
            float a, b, sum;
            Console.WriteLine("Xin moi nhap so thu nhat: ");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine("Xin moi nhap so thu hai: ");
            b = float.Parse(Console.ReadLine());
            sum = a + b;
            Console.WriteLine("Tong cua hai so la: " + sum);
            Console.WriteLine("Nhan enter de tiep tuc");
            Console.ReadLine();
            //2. to Swap Values of Two Variables.
            Console.WriteLine("Bai 2: Swap Values of Two Variables");
            float c, d, doi;
            Console.WriteLine("Xin moi nhap gia tri thu nhat:");
            c = float.Parse(Console.ReadLine());
            Console.WriteLine("Xin moi nhap gia tri thu hai:");
            d = float.Parse(Console.ReadLine());
            doi = c;
            c = d;
            d = doi;
            Console.WriteLine("Cac gia tri sau khi hoan doi la: ");
            Console.WriteLine("So thu nhat: " + c);
            Console.WriteLine("So thu hai: " + d);
            Console.WriteLine("Nhan enter de tiep tuc");
            Console.ReadLine();
            //3. to Multiply two Floating Point Numbers
            Console.WriteLine("Bai 3: Multiply two Floating Point Numbers");
            float e, f, tich;
            Console.WriteLine("Xin moi nhap so thu nhat: ");
            e = float.Parse(Console.ReadLine());
            Console.WriteLine("Xin moi nhap so thu hai:");
            f = float.Parse(Console.ReadLine());
            tich = e * f;
            Console.WriteLine("Tich cua hai so la: " + tich);
            Console.WriteLine("Nhan enter de tiep tuc");
            Console.ReadLine();
            //4. to convert feet to meter
            Console.WriteLine("Bai 4: Convert feet to meter");
            float feet, meter;
            const float feetToMeter = 0.3048f;
            Console.WriteLine("Xin moi nhap so feet: ");
            feet = float.Parse(Console.ReadLine());
            meter = feet * feetToMeter;
            Console.WriteLine("So meter tuong ung la: " + meter);
            Console.WriteLine("Nhan enter de tiep tuc");
            Console.ReadLine();
            //5. to convert Celsius to Fahrenheit and vice versa
            Console.WriteLine("Bai 5: Convert Celsius to Fahrenheit and vice versa");
            float celsius, fahrenheit;
            string luachon;
            Console.WriteLine("Nhan phim 1 de chuyen tu Celsius sang Fahrenheit\nNhan phim 2 de chuyen tu Fahrenheit sang Celsius");
            luachon = Console.ReadLine();
            if (luachon == "1")
            {
                Console.WriteLine("Ban da chon Chuyen tu Celsius sang Fahrenheit");
                Console.WriteLine("Xin moi nhap nhiet do Celsius");
                celsius = float.Parse(Console.ReadLine());
                fahrenheit = (celsius * 9 / 5) + 32;
                Console.WriteLine($"Nhiet do {celsius}°C = {fahrenheit}°F");
            }
            else if (luachon == "2")
            {
                Console.WriteLine("Ban da chon Chuyen tu Fahrenheit sang Celsius");
                Console.WriteLine("Xin moi nhap nhiet do Fahrenheit");
                fahrenheit = float.Parse(Console.ReadLine());
                celsius = fahrenheit * 9 / (float)32;
                Console.WriteLine($"Nhiet do {fahrenheit}°F = {celsius}°C");
            }
            else
            { Console.WriteLine("Lua chon khong hop le! Xin moi nhap lai"); }
            Console.WriteLine("Nhan enter de tiep tuc");
            Console.ReadLine();
            //6. to find the Size of data type
            Console.WriteLine("Bai 6: Find the size of data type");
            Console.Write("Nhap ten kieu du lieu (int, float, double, char, bool, long): ");
            string loai = Console.ReadLine().ToLower().Trim();
            if (loai == "int")
            {
                Console.WriteLine("Kich thuoc cua int la: " + sizeof(int) + " bytes");
            }
            else if (loai == "float")
            {
                Console.WriteLine("Kich thuoc cua float la: " + sizeof(float) + " bytes");
            }
            else if (loai == "double")
            {
                Console.WriteLine("Kich thuoc cua double la: " + sizeof(double) + " bytes");
            }
            else if (loai == "char")
            {
                Console.WriteLine("Kich thuoc cua char la: " + sizeof(char) + " bytes");
            }
            else if (loai == "bool")
            {
                Console.WriteLine("Kich thuoc cua bool la: " + sizeof(bool) + " byte");
            }
            else if (loai == "long")
            {
                Console.WriteLine("Kich thuoc cua long la: " + sizeof(long) + " bytes");
            }
            else
            {
                Console.WriteLine("Kieu du lieu khong hop le! Vui long nhap lai");
            }
            Console.WriteLine("Nhan enter de tiep tuc");
            Console.ReadLine();
            //7. to Print ASCII Value (tip: read character, print number of this char)
            Console.WriteLine("Bai 7: Print ASCII Value");
            Console.WriteLine("Xin moi nhap mot ky tu: ");
            char kyTu = char.Parse(Console.ReadLine());
            Console.WriteLine($"ASCII value of '{kyTu}' is: {Convert.ToInt32(kyTu)}");
            Console.WriteLine("Nhan enter de tiep tuc");
            Console.ReadLine();
            //8. to Calculate Area of Circle 
            Console.WriteLine("Bai 8: Calculate Area of Circle");
            Console.WriteLine("Xin moi nhap ban kinh hinh tron: ");
            double r = double.Parse(Console.ReadLine());
            double area = Math.PI * r * r;
            Console.WriteLine($"Dien tich hinh tron co ban kinh {r} la: {area}");
            Console.WriteLine("Nhan enter de tiep tuc");
            Console.ReadLine();
            //9. to Calculate Area of Square
            Console.WriteLine("Bai 9: Calculate Area of Square");
            Console.WriteLine("Xin moi nhap do dai canh hinh vuong: ");
            double canh, dienTich;
            canh = double.Parse(Console.ReadLine());
            dienTich = canh * canh;
            Console.WriteLine($"Dien tich hinh vuong co canh {canh} la: {dienTich}");
            Console.WriteLine("Nhan enter de tiep tuc");
            Console.ReadLine();
            //10. to convert days to years, weeks and days
            Console.WriteLine("Bai 10: Convert days to years, weeks and days");
            Console.WriteLine("Xin moi nhap so ngay: ");
            int tongNgay = int.Parse(Console.ReadLine());

            int nam = tongNgay / 365;
            int ngayConLai = tongNgay % 365;

            int tuan = ngayConLai / 7;
            int ngay = ngayConLai % 7;

            Console.WriteLine(tongNgay + " ngay = " + nam + " nam, " + tuan + " tuan, " + ngay + " ngay");
            Console.WriteLine("Nhan enter de ket thuc chuong trinh");
            Console.ReadLine();
        }
    }
}
