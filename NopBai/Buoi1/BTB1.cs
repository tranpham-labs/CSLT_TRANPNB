using System;
using System.Collections.Generic;
using System.Text;

namespace CSLT_PNBTRAN.Buoi1
{
    internal class BTB1
    {
        static void Main(string[] args)
        {
            // In noi dung bat ky
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Hello, World!");
            Console.WriteLine("Đây là bài tập code đầu tiên của tôi ");
            Console.WriteLine("Chúc bạn thành công nhé Trân");
            Console.WriteLine("Is this how we finish the project?");
            Console.WriteLine("Toi ten la Pham Ngoc Bao Tran");
            Console.WriteLine("Nu, 18 tuoi");
            Console.WriteLine("Sinh vien truong dai hoc kinh te thanh pho ho chi minh");
            Console.WriteLine("Toi sinh nam 2007");
            Console.WriteLine("Nhan enter de tiep tuc");
            Console.ReadLine();

            // Viet chuong trinh giai phuong trinh bac 1
            float a, b, x;
            Console.WriteLine("Giai phuong trinh bac 1: ax + b = 0");
            Console.WriteLine("Xin moi nhap he so a: ");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine("Xin moi nhap he so b: ");
            b = float.Parse(Console.ReadLine());
            if (a == 0)
            {
                if (b == 0)
                {
                    Console.WriteLine("Phuong trinh co vo so nghiem.");
                }
                else
                {
                    Console.WriteLine("Phuong trinh vo nghiem.");
                }
            }
            else
            {
                x = -b / a;
                Console.WriteLine("Nghiem cua phuong trinh la: {0}", x);
                Console.WriteLine("Nhan enter de tiep tuc");
                Console.ReadLine();
            }
            // Viet chuong trinh giai phuong trinh bac 2
            Console.WriteLine("Giai phuong trinh bac 2: ax^2 + bx + c = 0");
            float a1, b1, c, delta, x1, x2;
            Console.WriteLine("Xin moi nhap he so a: ");
            a1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Xin moi nhap he so b: ");
            b1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Xin moi nhap he so c: ");
            c = float.Parse(Console.ReadLine());
            delta = b1 * b1 - 4 * a1 * c;
            if (delta < 0)
            {
                Console.WriteLine("Phuong trinh vo nghiem.");
            }
            else if (delta == 0)
            {
                x1 = -b1 / (2 * a1);
                Console.WriteLine("Phuong trinh co nghiem kep: {0}", x1);
            }
            else
            {
                x1 = (-b1 + (float)Math.Sqrt(delta)) / (2 * a1);
                x2 = (-b1 - (float)Math.Sqrt(delta)) / (2 * a1);
                Console.WriteLine("Phuong trinh co hai nghiem phan biet:");
                Console.WriteLine("x1 = {0}", x1);
                Console.WriteLine("x2 = {0}", x2);
            }
            Console.WriteLine("Chuc ban mot ngay tot lanh");
            Console.ReadLine();
        }
    }
}
