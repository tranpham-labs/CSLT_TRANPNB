using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Globalization;
using System.Text;

namespace CSLT_26C1INF5090051_C2.SESSION07
{
    internal class Ex
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            CultureInfo culture = CultureInfo.InvariantCulture;
            Bai_20();

        }
        /* Bài 1: Tính tổng hai số nguyên
Yêu cầu: Viết hàm `int TinhTong(int a, int b)` nhận vào hai số nguyên và trả về tổng của chúng.
Hướng dẫn: Bên trong thân hàm, bạn sử dụng từ khóa `return a + b;`. Trong hàm `Main`, gọi hàm này, truyền vào 2
số cụ thể và in kết quả ra màn hình.    */
        static int TinhTong(int a, int b)
        {
            return a + b;
        }
        static void Bai_1()
        {
            int so1 = 5;
            int so2 = 10;
            int tong = TinhTong(so1, so2);
            Console.WriteLine($"Tổng của {so1} và {so2} là: {tong}");
        }
        /*Bài 2: Kiểm tra số chẵn lẻ
Yêu cầu: Viết hàm `bool KiemTraChan(int n)` trả về `true` nếu `n` là số chẵn, `false` nếu là số lẻ.
Hướng dẫn: Sử dụng toán tử chia lấy dư `%`. Nếu biểu thức `n % 2 == 0` đúng thì n là số chẵn. Bạn có thể return
thẳng biểu thức này.*/
        static bool KiemTraChan(int n)
        {
            return n % 2 == 0;
        }
        static void Bai_2()
        {
            int so = 7;
            if (KiemTraChan(so))
            {
                Console.WriteLine($"{so} là số chẵn.");
            }
            else
            {
                Console.WriteLine($"{so} là số lẻ.");
            }
        }
        /*Bài 3: Tìm số lớn nhất trong ba số
Yêu cầu: Viết hàm `int TimMax(int a, int b, int c)` trả về giá trị lớn nhất trong ba số được truyền vào.
Hướng dẫn: Bạn có thể sử dụng cấu trúc điều kiện `if-else` lồng nhau. Cách ngắn gọn hơn là tận dụng hàm có sẵn
`Math.Max(Math.Max(a, b), c)`.*/
        static int TimMax(int a, int b, int c)
        {
            return Math.Max(Math.Max(a, b), c);
        }
        static void Bai_3()
        {
            int so1 = 15;
            int so2 = 25;
            int so3 = 10;
            int max = TimMax(so1, so2, so3);
            Console.WriteLine($"Số lớn nhất trong ba số {so1}, {so2}, {so3} là: {max}");

        }
        /*Bài 4: Tính giai thừa của một số
Yêu cầu: Viết hàm `long TinhGiaiThua(int n)` tính và trả về giai thừa của số nguyên dương n (n!).
Hướng dẫn: Sử dụng một biến lưu kết quả (khởi tạo bằng 1). Dùng vòng lặp `for` chạy từ 1 đến `n` để nhân dồn vào
biến kết quả. Chú ý: dùng kiểu `long` để tránh tràn số lượng giới hạn của `int`*/
        static long tinhGiaiThua(int n)
        {
            if (n < 0)
            {
                throw new ArgumentException("n phải là số nguyên không âm.");
            }
            long ketQua = 1;
            for (int i = n; i >= 1; i--)
            {
                ketQua *= i;
            }
            return ketQua;
        }
        static void Bai_4()
        {
            int n = 5;
            long giaiThua = tinhGiaiThua(n);
            Console.WriteLine($"Giai thừa của {n} là: {giaiThua}");

        }
        /*Bài 5: Đảo ngược chuỗi ký tự
Yêu cầu: Viết hàm `string DaoNguocChuoi(string input)` nhận vào một chuỗi và trả về chuỗi bị đảo ngược.
Hướng dẫn: Chuyển chuỗi thành mảng ký tự `char[]` bằng phương thức `.ToCharArray()`. Sau đó dùng hàm
`Array.Reverse()` để đảo mảng, cuối cùng tạo lại chuỗi mới bằng `new string(char_array)*/
        static string DaoNguocChuoi(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input; // Trả về chuỗi gốc nếu nó rỗng hoặc null
            }
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
        static void Bai_5()
        {
            string input = "Pham Ngoc Bao Tran";
            string chuoiDaoNguoc = DaoNguocChuoi(input);
            Console.WriteLine($"Chuỗi gốc: {input}");
            Console.WriteLine($"Chuỗi đảo ngược: {chuoiDaoNguoc}");

        }
        /* Bài 6: Kiểm tra số nguyên tố
 Yêu cầu: Viết hàm `bool KiemTraNguyenTo(int n)` kiểm tra xem số nguyên n có phải số nguyên tố hay không.
 Kết quả mẫu: Input: 7 -> Output: True | Input: 10 -> Output: False*/
        static bool KiemTraNguyenTo(int n)
        {
            if (n < 2)
            {
                return false;
            }
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        static void Bai_6()
        {
            Console.WriteLine("Nhập một số nguyên để kiểm tra số nguyên tố:");
            int n = int.Parse(Console.ReadLine());
            if (KiemTraNguyenTo(n))
            {
                Console.WriteLine($"{n} là số nguyên tố.");
            }
            else
            {
                Console.WriteLine($"{n} không phải là số nguyên tố.");
            }
        }
        /*Bài 7: In dãy Fibonacci
Yêu cầu: Viết hàm `void InFibonacci(int n)` in ra n số đầu tiên của dãy Fibonacci.
Kết quả mẫu: Input: 6 -> Output: 0 1 1 2 3 5*/
        static void InFibonacci(int n)
        {
            if (n <= 0)
            {
                Console.WriteLine("Vui lòng nhập một số nguyên dương.");
                return;
            }
            long a = 0, b = 1;
            Console.Write("Dãy Fibonacci: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(a + " ");
                long next = a + b;
                a = b;
                b = next;
            }
            Console.WriteLine();
        }

        static void Bai_7()
        {
            Console.Write("Nhập số lượng số Fibonacci cần in:");
            int n = int.Parse(Console.ReadLine());
            InFibonacci(n);

        }
        /*Bài 8: Đếm số lượng nguyên âm trong chuỗi
Yêu cầu: Viết hàm `int DemNguyenAm(string s)` đếm số lượng các ký tự nguyên âm (a, e, i, o, u) trong chuỗi.
Kết quả mẫu: Input: "Hello World" -> Output: 3*/
        static int DemNguyenAm(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return 0;
            }
            int dem = 0;
            string nguyenAm = "aeiouAEIOU";
            foreach (char c in s)
            {
                if (nguyenAm.Contains(c))
                {
                    dem++;
                }
            }
            return dem;
        }
        static void Bai_8()
        {
            Console.Write("Nhập một chuỗi để đếm số lượng nguyên âm:");
            string input = Console.ReadLine();
            int soLuongNguyenAm = DemNguyenAm(input);
            Console.WriteLine($"Số lượng nguyên âm trong chuỗi \"{input}\" là: {soLuongNguyenAm}");
        }
        /*Bài 9: Tính lũy thừa
Yêu cầu: Viết hàm `double TinhLuyThua(double x, int y)` tính x^y (không dùng Math.Pow).
Kết quả mẫu: Input: x = 2, y = 3 -> Output: 8*/
        static double TinhLuyThua(double x, int y)
        {
            if (y < 0)
            {
                throw new ArgumentException("y phải là số nguyên không âm.");
            }
            double ketQua = 1; // Khởi tạo kết quả bằng 1 (x^0 = 1)
            for (int i = 0; i < y; i++)
            {
                ketQua *= x;
            }
            return ketQua;
        }
        static void Bai_9()
        {
            Console.Write("Nhập cơ số x:");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Nhập số mũ y:");
            int y = int.Parse(Console.ReadLine());
            double luyThua = TinhLuyThua(x, y);
            Console.WriteLine($"{x}^{y} = {luyThua}");

        }
        /*Bài 10: Tính điểm trung bình của mảng
Yêu cầu: Viết hàm `double TinhTrungBinh(int[] arr)` tính giá trị trung bình của mảng số nguyên.
Kết quả mẫu: Input: [4, 5, 6, 7] -> Output: 5.5*/
        static double TinhTrungBinh(int[] arr)
        {
            if (arr == null || arr.Length == 0)
            {
                throw new ArgumentException("Mảng không được rỗng.");
            }
            int tong = 0;
            foreach (int so in arr)
            {
                tong += so;
            }
            return (double)tong / arr.Length;
        }
        static void Bai_10()
        {
            int[] mang = { 4, 5, 6, 7 };
            double trungBinh = TinhTrungBinh(mang);
            Console.WriteLine($"Điểm trung bình của mảng [{string.Join(", ", mang)}] là: {trungBinh}"); // Sử dụng string.Join để hiển thị mảng
        }
        /*Bài 11: Kiểm tra chuỗi đối xứng (Palindrome)
Yêu cầu: Viết hàm `bool KiemTraDoiXung(string s)` kiểm tra chuỗi có đọc xuôi và ngược giống nhau không.
Kết quả mẫu: Input: "radar" -> Output: True | Input: "hello" -> Output: False*/
        static bool KiemTraDoiXung(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return true; // Chuỗi rỗng hoặc null được coi là đối xứng
            }
            string s = str.ToLower(); // Chuyển về chữ thường để so sánh
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            string reversed = new string(charArray);
            return s == reversed;
        }
        static void Bai_11()
        {
            Console.Write("Nhập một chuỗi để kiểm tra đối xứng:");
            string input = Console.ReadLine();
            if (KiemTraDoiXung(input))
            {
                Console.WriteLine($"Chuỗi \"{input}\" là chuỗi đối xứng.");
            }
            else
            {
                Console.WriteLine($"Chuỗi \"{input}\" không phải là chuỗi đối xứng.");
            }
        }
        /*Bài 12: Chuyển đổi nhiệt độ
Yêu cầu: Viết hàm `double CelsiusToFahrenheit(double c)` chuyển đổi từ độ C sang độ F.
Kết quả mẫu: Input: 25 -> Output: 77*/
        static double CelsiusToFahrenheit(double c)
        {
            return c * 9 / 5 + 32;
        }
        static void Bai_12()
        {
            Console.Write("Nhập nhiệt độ ở độ C:");
            double celsius = double.Parse(Console.ReadLine());
            double fahrenheit = CelsiusToFahrenheit(celsius);
            Console.WriteLine($"{celsius}°C = {fahrenheit}°F");
        }
        /*Bài 13:Bài 13: Tìm giá trị nhỏ nhất trong mảng
Yêu cầu: Viết hàm `int TimMin(int[] arr)` trả về phần tử nhỏ nhất trong mảng.
Kết quả mẫu: Input: [10, 5, 8, 2, 9] -> Output: 2*/
        static int TimMin(int[] arr)
        {
            if (arr == null || arr.Length == 0)
            {
                throw new ArgumentException("Mảng không được rỗng.");
            }
            int min = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            return min;
        }
        static void Bai_13()
        {
            int[] mang = { 10, 5, 8, 2, 9 };
            int min = TimMin(mang);
            Console.WriteLine($"Phần tử nhỏ nhất trong mảng [{string.Join(", ", mang)}] là: {min}");
        }
        /*Bài 14: Tính tổng các chữ số của một số nguyên
Yêu cầu: Viết hàm `int TongCacChuSo(int n)` để tính tổng từng chữ số tạo nên n.
Kết quả mẫu: Input: 1234 -> Output: 10 (Vì 1+2+3+4 = 10)*/
        static int TongCacChuSo(int n)
        {
            n = Math.Abs(n); // Đảm bảo n là số nguyên dương
            int tong = 0;
            while (n > 0)
            {
                tong += n % 10; // Lấy chữ số cuối cùng và cộng vào tổng
                n /= 10; // Loại bỏ chữ số cuối cùng
            }
            return tong;
        }
        static void Bai_14()
        {
            Console.Write("Nhập một số nguyên để tính tổng các chữ số:");
            int n = int.Parse(Console.ReadLine());
            int tong = TongCacChuSo(n);
            Console.WriteLine($"Tổng các chữ số của {n} là: {tong}");
        }
        /*Bài 16: Xóa ký tự trùng lặp
Yêu cầu: Viết hàm `string XoaTrungLap(string s)` trả về chuỗi với các ký tự xuất hiện lần đầu tiên được giữ lại.
Kết quả mẫu: Input: "programming" -> Output: "progamin"*/
        static string XoaTrungLap(string s)
        {
            string result = "";
            foreach (char c in s)
            {
                if (!result.Contains(c))
                {
                    result += c;
                }
            }
            return result;

        }
        static void Bai_16()
        {
            Console.Write("Nhập một chuỗi để xóa ký tự trùng lặp:");
            string input = Console.ReadLine();
            string ketQua = XoaTrungLap(input);
            Console.WriteLine($"Chuỗi sau khi xóa ký tự trùng lặp: {ketQua}");
        }
        /*Bài 17: Tìm ước chung lớn nhất (UCLN)
Yêu cầu: Viết hàm `int UCLN(int a, int b)` sử dụng thuật toán Euclid để tìm UCLN của 2 số.
Kết quả mẫu: Input: a = 12, b = 18 -> Output: 6*/
        static int UCLN(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
        static void Bai_17()
        {
            Console.Write("Nhập số nguyên a:");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhập số nguyên b:");
            int b = int.Parse(Console.ReadLine());
            int ucln = UCLN(a, b);
            Console.WriteLine($"Ước chung lớn nhất (UCLN) của {a} và {b} là: {ucln}");
        }
        /*Bài 18: Chuyển đổi hệ thập phân sang nhị phân
Yêu cầu: Viết hàm `string DecimalToBinary(int n)` nhận vào số thập phân và trả về chuỗi nhị phân.
Kết quả mẫu: Input: 10 -> Output: "1010"*/
        static string DecimalToBinary(int n)
        {
            if (n == 0)
            {
                return "0";
            }
            string Binary = "";
            while (n > 0)
            {
                int remainder = n % 2;
                Binary += remainder.ToString();
                n /= 2;
            }
            return Binary;
        }
        static void Bai_18()
        {
            Console.Write("Nhập một số nguyên thập phân để chuyển sang nhị phân:");
            int n = int.Parse(Console.ReadLine());
            string binary = DecimalToBinary(n);
            Console.WriteLine($"Số {n} trong hệ nhị phân là: {binary}");
        }
        /*Bài 19: Kiểm tra năm nhuận
Yêu cầu: Viết hàm `bool KiemTraNamNhuan(int year)` kiểm tra xem một năm có phải năm nhuận không.
Kết quả mẫu: Input: 2024 -> Output: True | Input: 2023 -> Output: False*/
        static bool KiemTraNamNhuan(int year)
        {
            return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
        }
        static void Bai_19()
        {
            Console.Write("Nhập một năm để kiểm tra năm nhuận:");
            int year = int.Parse(Console.ReadLine());
            if (KiemTraNamNhuan(year))
            {
                Console.WriteLine($"{year} là năm nhuận.");
            }
            else
            {
                Console.WriteLine($"{year} không phải là năm nhuận.");
            }
        }
        /*Bài 20: Đếm số từ trong câu
Yêu cầu: Viết hàm `int DemSoTu(string sentence)` trả về số lượng từ có trong câu.
Kết quả mẫu: Input: "Học lập trình C# rất thú vị" -> Output: 7*/
        static int DemSoTu(string sentence)
        {
            if (string.IsNullOrWhiteSpace(sentence))
            {
                return 0;
            }
            string[] words = sentence.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            return words.Length;
        }
        static void Bai_20()
        {
            Console.Write("Nhập một câu để đếm số từ:");
            string sentence = Console.ReadLine();
            int soTu = DemSoTu(sentence);
            Console.WriteLine($"Số lượng từ trong câu là: {soTu}");
        }
    }
}

