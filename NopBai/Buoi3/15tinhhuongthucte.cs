using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Channels;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CSLT_PNBTRAN.Buoi3
{
     enum CurrencyType
    {
        USD,
        EUR,
        GBP,
        JPY,
    }
    enum trangthaiHang
    {
        outofStock,
        lowStock,
        inStock,
        discontinued,
    }
    enum VehicleType
    {
        Motorbike = 1,
        Car = 2,
        Truck = 3, 
    }

    internal class _15tinhhuongthucte
    {
        static void Bai1()
        {
            //Bài 1: Tính Tiền Điện Sinh Hoạt Gia Đình Theo Bậc Thang(EVN)
            Console.WriteLine("Chuc ban mot ngay tot lanh! Day la 15 chuong trinh thuc te");
            Console.WriteLine("Bai 1: Tinh tien dien sinh hoat theo bac thang");
            decimal diencu, dienmoi, sodien, tienchuathue, tienthuevat, thanhtoan;
            Console.WriteLine("Xin moi nhap chi so dien cu(kWh):");
            diencu = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Xin moi nhap chi so dien moi(kWh):");
            dienmoi = decimal.Parse(Console.ReadLine());
            if (diencu > dienmoi)
            {
                Console.WriteLine("Chi so dien moi phai lon hon hoac bang chi so dien cu. Vui long nhap lai!");
            }
            else
            {
                sodien = dienmoi - diencu;
                if (sodien <= 50)
                {
                    tienchuathue = sodien * 1806;
                }
                else if (sodien <= 100)
                {
                    tienchuathue = 50 * 1806 + (sodien - 50) * 1866;
                }
                else if (sodien <= 200)
                {
                    tienchuathue = 50 * 1806 + 50 * 1866 + (sodien - 100) * 2167;
                }
                else if (sodien <= 300)
                {
                    tienchuathue = 50 * 1806 + 50 * 1866 + 100 * 2167 + (sodien - 200) * 2729;
                }
                else
                {
                    tienchuathue = 50 * 1806 + 50 * 1866 + 100 * 2167 + 100 * 2729 + (sodien - 300) * 3050;

                }


                tienthuevat = Math.Round(tienchuathue * 0.08m, MidpointRounding.AwayFromZero);
                thanhtoan = tienchuathue + tienthuevat;

                Console.WriteLine($"So dien tieu thu: {sodien} kWh");
                Console.WriteLine($"Tien dien chua thue: {tienchuathue:#,##0} VNĐ");
                Console.WriteLine($"Thue VAT(8%): {tienthuevat:#,##0} VNĐ");
                Console.WriteLine($"Tong thanh toan: {thanhtoan:#,##0} VNĐ");
                Console.WriteLine("Xin moi thanh toan. Chuc ban mot ngay tot lanh!");
                Console.WriteLine("Nhan Enter de den chuong trinh tiep theo");
                Console.ReadLine();
            }
        }
        static void Bai2()
        {
            //Bài 2: Hệ Thống Theo Dõi Chỉ Số BMI & Đánh Giá Tình Trạng Sức Khỏe
            Console.WriteLine("Bai 2: Tinh chi so BMI");
            Console.WriteLine("Xin moi nhap chieu cao cua ban(tinh bang met, vi du: 1.72):");
            double chieuCao = double.Parse(Console.ReadLine());
            Console.WriteLine("Xin moi nhap can nang cua ban(tinh bang kg, vi du: 72.0):");
            double canNang = double.Parse(Console.ReadLine());
            double bmi = canNang / Math.Pow(chieuCao, 2);
            string phanLoai;
            if (bmi < 18.5)
            {
                phanLoai = "Gầy(Thiếu cân)";
            }
            else if (bmi < 23.0)
            {
                phanLoai = "Bình thường(Lý tưởng)";
            }
            else if (bmi < 25.0)
            {
                phanLoai = "Thừa cân(Tiền béo phì)";
            }
            else
            {
                phanLoai = "Béo phì";
            }
            double canNangToiThieu = 18.5 * Math.Pow(chieuCao, 2);
            double canNangToiDa = 22.9 * Math.Pow(chieuCao, 2);
            Console.WriteLine($"Chỉ số BMI của bạn: {bmi:F2}");
            Console.WriteLine($"Phân loại sức khỏe: {phanLoai}");
            Console.WriteLine($"Khuyên dùng: Cân nặng lý tưởng của bạn nên từ {canNangToiThieu:F2} kg đến {canNangToiDa:F2} kg.");
            Console.WriteLine("Nhan Enter de ket thuc chuong trinh");
            Console.ReadLine();
        }
        static void Bai3()
        {
            //Bài 3: Ứng Dụng Quy Đổi Tiền Tệ Ngoại Tệ Đa Tỷ Giá Ngân Hàng
            Console.WriteLine("Bai 3: Ung dung quy doi tien te ngoai te da ty gia ngan hang");
            const decimal tyGiaUSD = 25400m;
            const decimal tyGiaEUR = 27500m;
            const decimal tyGiaGBP = 32000m;
            const decimal tyGiaJPY = 165m;
            Console.WriteLine("Nhap so tien ngoai te can quy doi:");
            decimal soTien = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Nhap don vi tien te (USD/EUR/GBP/JPY):");
            string donVi = Console.ReadLine();
            Console.WriteLine("Chon loai tien te (USD/EUR/GBP/JPY):");
            CurrencyType loaiTien = (CurrencyType)Enum.Parse(typeof(CurrencyType), Console.ReadLine(), true);
            decimal thanhTienVND = 0;
            switch (loaiTien)
            {
                case CurrencyType.USD:
                    thanhTienVND = soTien * tyGiaUSD;
                    break;
                case CurrencyType.EUR:
                    thanhTienVND = soTien * tyGiaEUR;
                    break;
                case CurrencyType.GBP:
                    thanhTienVND = soTien * tyGiaGBP;
                    break;
                case CurrencyType.JPY:
                    thanhTienVND = soTien * tyGiaJPY;
                    break;
                default:
                    Console.WriteLine("Loai tien te khong hop le.");
                    break;
            }
            Console.WriteLine($"So tien sau khi quy doi sang VND: {thanhTienVND:#,##0} VND");
            Console.WriteLine("Nhan Enter de ket thuc chuong trinh");
            Console.ReadLine();
        }
        static void Bai4()
        {
            //Bài 4: Tính Tuổi Chính Xác & Đếm Ngược Ngày Sinh Nhật
            Console.WriteLine("Bai 4: Tinh tuoi chinh xac & dem nguoc ngay sinh nhat");
            Console.WriteLine("Nhap ngay sinh cua ban(dd/MM/yyyy):");
            DateTime ngaySinh = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
            Console.WriteLine("Nhap ngay hien tai(dd/MM/yyyy):");
            DateTime ngayhientai = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
            TimeSpan ngaysong = ngayhientai - ngaySinh;
            DateTime snTieptheo = new DateTime(ngayhientai.Year, ngaySinh.Month, ngaySinh.Day);
            Console.WriteLine("Tuoi hien tai: {0} tuoi", ngaysong.Days / 365);
            Console.WriteLine($"Ban da song tong cong: {ngaysong:#,##0} ngay");
            Console.WriteLine($"Sinh nhat tiep theo con: {(snTieptheo - ngayhientai).Days} ngay nua");
            Console.WriteLine("Nhan Enter de ket thuc chuong trinh");
            Console.ReadLine();
        }
        static void Bai5()
        {
            //Bài 5: Quản Lý Điểm Học Phần & Quy Đổi Thang Điểm GPA(4.0)
            Console.WriteLine("Bai 5: Quan ly diem hoc phan & quy doi thang diem GPA(4.0)");
            double diemToan, diemCSharp, diemTiengAnh, gpaThang10;
            int tcToan, tcCSharp, tcTiengAnh;
            Console.WriteLine("Xin moi nhap diem so thang 10 cua mon Lap trinh C#:");
            while (!double.TryParse(Console.ReadLine(), out diemCSharp) || diemCSharp < 0 || diemCSharp > 10)
            {
                Console.WriteLine("Diem khong hop le! Vui long nhap lai so tu 0 den 10:");
            }

            Console.WriteLine("Xin moi nhap so tin chi cua mon Lap trinh C#:");
            while (!int.TryParse(Console.ReadLine(), out tcCSharp) || tcCSharp <= 0)
            {
                Console.WriteLine("So tin chi khong hop le! Vui long nhap lai so nguyen lon hon 0:");
            }
            Console.WriteLine("Xin moi nhap diem so thang 10 cua mon Toan:");
            while (!double.TryParse(Console.ReadLine(), out diemToan) || diemToan < 0 || diemToan > 10)
            {
                Console.WriteLine("Diem khong hop le! Vui long nhap lai so tu 0 den 10:");
            }
            Console.WriteLine("Xin moi nhap so tin chi cua mon Toan:");
            while (!int.TryParse(Console.ReadLine(), out tcToan) || tcToan <= 0)
            {
                Console.WriteLine("So tin chi khong hop le! Vui long nhap lai so nguyen lon hon 0:");
            }
            Console.WriteLine("Xin moi nhap diem so thang 10 cua mon Tieng Anh:");
            while (!double.TryParse(Console.ReadLine(), out diemTiengAnh) || diemTiengAnh < 0 || diemTiengAnh > 10)
            {
                Console.WriteLine("Diem khong hop le! Vui long nhap lai so tu 0 den 10:");
            }
            Console.WriteLine("Xin moi nhap so tin chi cua mon Tieng Anh:");
            while (!int.TryParse(Console.ReadLine(), out tcTiengAnh) || tcTiengAnh <= 0)
            {
                Console.WriteLine("So tin chi khong hop le! Vui long nhap lai so nguyen lon hon 0:");
            }
            gpaThang10 = (diemCSharp * tcCSharp + diemToan * tcToan + diemTiengAnh * tcTiengAnh) / (tcCSharp + tcToan + tcTiengAnh);
            if (gpaThang10 >= 8.5)
            {
                Console.WriteLine($"Diem TB Thang 10: {gpaThang10:F2}");
                Console.WriteLine("Diem Chu Quy Doi: A");
                Console.WriteLine("Diem GPA Thang 4: 4.0");
                Console.WriteLine("Xep Loai Hoc Luc: Xuat sac / Gioi");
            }
            else if (gpaThang10 >= 7.0)
            {
                Console.WriteLine($"Diem TB Thang 10: {gpaThang10:F2}");
                Console.WriteLine("Diem Chu Quy Doi: B");
                Console.WriteLine("Diem GPA Thang 4: 3.0");
                Console.WriteLine("Xep Loai Hoc Luc: Kha");
            }
            else if (gpaThang10 >= 5.5)
            {
                Console.WriteLine($"Diem TB Thang 10: {gpaThang10:F2}");
                Console.WriteLine("Diem Chu Quy Doi: C");
                Console.WriteLine("Diem GPA Thang 4: 2.0");
                Console.WriteLine("Xep Loai Hoc Luc: Trung binh");
            }
            else if (gpaThang10 >= 4.0)
            {
                Console.WriteLine($"Diem TB Thang 10: {gpaThang10:F2}");
                Console.WriteLine("Diem Chu Quy Doi: D");
                Console.WriteLine("Diem GPA Thang 4: 1.0");
                Console.WriteLine("Xep Loai Hoc Luc: Yeu");
            }
            else
            {
                Console.WriteLine($"Diem TB Thang 10: {gpaThang10:F2}");
                Console.WriteLine("Diem Chu Quy Doi: F");
                Console.WriteLine("Diem GPA Thang 4: 0.0");
                Console.WriteLine("Xep Loai Hoc Luc: Kem(Truot)");
                        }
            Console.WriteLine("Nhan Enter de ket thuc chuong trinh");
            Console.ReadLine();
        }

        static void Bai6()
        {
            Console.WriteLine("Bai 6: Xu ly du lieu ho ten nhap vao tu ban phim");
            Console.WriteLine("Xin moi nhap ho ten cua ban");
            string hotentho = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(hotentho))
            {
                Console.WriteLine("Ho ten khong duoc de trong! Vui long nhap lai:");
                hotentho = Console.ReadLine();
            }
            string[] words = hotentho.Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToLower();
                words[i] = char.ToUpper(words[i][0]) + words[i].Substring(1);
            }
            string hotenChuanHoa = string.Join(" ", words);
            string ho = words[0];
            string ten = words[words.Length - 1];
            string tendem = string.Join(" ", words, 1, words.Length - 2);
            if (words.Length > 2)
            {
                string[] middleWords = new string[words.Length - 2];
                Array.Copy(words, 1, middleWords, 0, words.Length - 2);
                tendem = string.Join(" ", middleWords);
            }
            else if (words.Length == 2)
            {
                tendem = "";
            }
            string boDau(string text)
            {
                string normalized = text.Normalize(NormalizationForm.FormD);
                Regex regex = new Regex("\\p{IsCombiningDiacriticalMarks}+");
                string strWithoutDiacritics = regex.Replace(normalized, string.Empty);
                return strWithoutDiacritics;
            }
            string[] wordNosign = new string[words.Length];
            for (int i = 0; i < words.Length; i++)
            {
                wordNosign[i] = boDau(words[i].ToLower());
            }
            string username = " ";
            if ((wordNosign.Length) == 1)
            {
                username = wordNosign[0];
            }
            else
            {
                string tenKhongDau = wordNosign[words.Length - 1];
                string hoVaTenDemKhongDau = " ";
                for (int i = 0; i < words.Length - 1; i++)
                {
                    hoVaTenDemKhongDau += wordNosign[i];
                }
                username = tenKhongDau + "." + hoVaTenDemKhongDau;
            }
            string email = username + "@company.edu.vn";
            Console.WriteLine($"Họ tên chuẩn hóa: {hotenChuanHoa}");
            Console.WriteLine($"Họ: {ho} | Tên đệm: {tendem} | Tên: {ten}");
            Console.WriteLine($"Username: {username}");
            Console.WriteLine($"Email: {email}");
            Console.WriteLine("Nhan Enter de tiep tuc");
            Console.ReadLine();
        }
        static void Bai7()
        {
            Console.WriteLine("Bai 7: Lap ke hoach chi phi nhien lieu & chia se chuyen di");
            Console.WriteLine("Nhap khoang cach chuyen di (km):");
            double khoangCach = double.Parse(Console.ReadLine() ?? "Khong hop le! Vui long nhap lai");
            Console.WriteLine("Nhap muc tieu thu nhien lieu trung binh cua xe (lit/100km):");
            double tieuThu = double.Parse(Console.ReadLine() ?? "Khong hop le! Vui long nhap lai");
            Console.WriteLine("Nhap gia xang hien tai (VND/lit):");
            decimal giaXang = decimal.Parse(Console.ReadLine() ?? "Khong hop le! Vui long nhap lai");
            Console.WriteLine("Nhap so luong nguoi tham gia chuyen di:");
            int soLuongNguoi = int.Parse(Console.ReadLine() ?? "Khong hop le! Vui long nhap lai");
            double tongXang = (khoangCach /100) * tieuThu;
            decimal tienXang = (decimal)tongXang * giaXang;
            decimal phiShare = tienXang / soLuongNguoi;
            Console.WriteLine($"Tong nhien lieu tieu thu: {tongXang:F2} lit");
            Console.WriteLine($"Tong chi phi xang dau: {tienXang:C}");
            Console.WriteLine($"Chi phi moi nguoi: {phiShare:C}");
            Console.WriteLine("Nhan Enter de tiep tuc");
            Console.ReadLine();
        }
        static void Bai8()
        {
//Bai 8: Kiem tra ma xac thuc OTP & quan ly thoi gian hieu luc 
            Console.WriteLine("Bai 8: Kiem tra ma xac thuc OTP & quan ly thoi gian hieu luc");
            string otpDung = "123456";
            DateTime thoigianTao = DateTime.Now;
            const int thoiGianHieuLuc = 300;
            Console.WriteLine($"Ma OTP da gui: {otpDung}");
            Console.WriteLine($"Thoi gian tao: {thoigianTao}");
            Console.WriteLine($"OTP co hieu luc trong: {thoiGianHieuLuc} giay");
            Console.WriteLine("Xin moi nhap ma xac thuc OTP (6 chu so):");
            string otp = Console.ReadLine();
            DateTime thoigianNhap = DateTime.Now;
            TimeSpan khoangThoiGian = thoigianNhap - thoigianTao;
            bool dinhdangDung = !string.IsNullOrEmpty(otp) && otp.Length == 6 && int.TryParse(otp, out _);
            bool khopOTP = string.Equals(otp, otpDung);
            bool conHieuluc = khoangThoiGian.TotalSeconds <= thoiGianHieuLuc;
            Console.WriteLine($"Thoi diem gui xac nhan: {thoigianNhap:HH:mm:ss}");
            Console.WriteLine($"Thoi gian xu ly: {khoangThoiGian.Minutes} phut {khoangThoiGian.Seconds} giay");
            if (!dinhdangDung)
            {
                Console.WriteLine("Loi: Dinh dang OTP khong hop le. Vui long nhap lai 6 chu so.");
            }
            else if (!khopOTP)
            {
                Console.WriteLine("Loi: Ma OTP khong khop. Vui long kiem tra lai ma OTP.");
            }
            else if (!conHieuluc)
            {
                Console.WriteLine("Loi: OTP da het han. Vui long yeu cau gui OTP moi.");
            }
            else
            {
                Console.WriteLine("Trang thai xac thuc: THANH CONG - Giao dich da duoc phe duyet.");
            }
            Console.WriteLine("Nhan Enter de tiep tuc chuong trinh ");
            Console.ReadLine();
        }   
        static void Bai9()
        {
            //Bài 9: Máy Tính Lương Gross -Net & Thuế TNCN Nhân Viên
            Console.WriteLine("Bai 9: Tinh luong Gross - Net & Thue TNCN");
            Console.WriteLine("Nhap Luong Gross (VNĐ):");
            decimal luongGross = decimal.Parse(Console.ReadLine() ?? "Khong hop le, vui long nhap lai.");
            Console.WriteLine("Nhap So nguoi phu thuoc:");
            int soNguoiPhuThuoc = int.Parse(Console.ReadLine() ?? "Khong hop le, vui long nhap lai.");
            decimal bhxh = luongGross * 0.08m;
            decimal bhyt = luongGross * 0.015m;
            decimal bhtn = luongGross * 0.01m;
            decimal tongBaoHiem = bhxh + bhyt + bhtn;
            const decimal giamtrubanthan = 11000000m;
            const decimal giamtruphuthuoc = 4400000m;
            decimal thuNhapChiuThue = luongGross - tongBaoHiem - giamtrubanthan - (soNguoiPhuThuoc * giamtruphuthuoc);
            if (thuNhapChiuThue < 0)
            {
                thuNhapChiuThue = 0; 
            }
            decimal thueTNCN = 0;
            if (thuNhapChiuThue <= 5000000)
            {
                thueTNCN = thuNhapChiuThue * 0.05m;
            }
            else if (thuNhapChiuThue <= 10000000)
            {
                thueTNCN = 5000000 * 0.05m + (thuNhapChiuThue - 5000000) * 0.1m;
            }
            else if (thuNhapChiuThue <= 18000000)
            {
                thueTNCN = 5000000 * 0.05m + 5000000 * 0.1m + (thuNhapChiuThue - 10000000) * 0.15m;
            }
            else if (thuNhapChiuThue <= 32000000)
            {
                thueTNCN = 5000000 * 0.05m + 5000000 * 0.1m + 8000000 * 0.15m + (thuNhapChiuThue - 18000000) * 0.2m;
            }
            else if (thuNhapChiuThue <= 52000000)
            {
                thueTNCN = 5000000 * 0.05m + 5000000 * 0.1m + 8000000 * 0.15m + 14000000 * 0.2m + (thuNhapChiuThue - 32000000) * 0.25m;
            }
            else if (thuNhapChiuThue <= 80000000)
            {
                thueTNCN = 5000000 * 0.05m + 5000000 * 0.1m + 8000000 * 0.15m + 14000000 * 0.2m + 20000000 * 0.25m + (thuNhapChiuThue - 52000000) * 0.3m;
            }
            else
            {
                thueTNCN = thuNhapChiuThue * 0.35m;
            }
            decimal thunhapHienThi = luongGross - tongBaoHiem - giamtrubanthan - (soNguoiPhuThuoc * giamtruphuthuoc);
            if (thunhapHienThi < 0)
            {
                thunhapHienThi = 0;
            }
            decimal luongNet = luongGross - tongBaoHiem - thueTNCN;
            Console.WriteLine($"Giam tru Bao hiem (10.5%): {tongBaoHiem:#,##0} VND");
            Console.WriteLine($"Thu nhap chiu thua       : {thunhapHienThi:#,##0} VND");
            Console.WriteLine($"Thue TNCN phai nop       : {thueTNCN:#,##0} VND");
            Console.WriteLine($"Luong net thuc nhan      : {luongNet:#,##0} VND");
            Console.WriteLine("Nhan Enter de ket thuc chuong trinh");
            Console.ReadLine();  
        }
        static void Bai10()
        {
            //Bài 10: Quản Lý Tồn Kho &Xử Lý Giá Trị Khuyết Thiếu(Nullable Types)
            Console.WriteLine("Bai 10: Quan ly ton kho & xu ly gia tri khuyet thieu");
            Console.WriteLine("Vui long nhap Ma San Pham");
            string maSP = Console.ReadLine();
            Console.WriteLine("Vui long nhap Ten San Pham");
            string tenSP = Console.ReadLine();
            Console.WriteLine("Vui long nhap so luong ton kho (Nhan Enter neu chua kiem ke");
            int? quantity = null;
            string inputQty = Console.ReadLine();
            if (!string.IsNullOrEmpty( inputQty ) )
            {
                if (int.TryParse(inputQty, out int qty) && qty >= 0) ;
                {
                    quantity = qty;
                }
            }
            int minThreshold = 10;
            DateTime? restockDate = null;
            Console.WriteLine("Vui long nhap Ngay nhap tiep theo theo dang dd/MM/yyyy (Nhan Enter neu chua co lich): ");
            string inputDate = Console.ReadLine();
            if (inputDate != " ") ;

            {
                restockDate = DateTime.Parse(inputDate);
            }
            int displayQuantity = quantity ?? 0;
            trangthaiHang status; 
            if (quantity == null || quantity == 0)
            {
                status = trangthaiHang.outofStock;
            }
            else if (quantity <  minThreshold) 
            {
                status = trangthaiHang.lowStock;
            }
            else
            {
                status = trangthaiHang.inStock;
            }
            string ngayNhapHienthi = restockDate?.ToString("dd/MM/yyyy") ?? "Chua co lich nhap hang";
            Console.WriteLine($"San pham: {tenSP} (Ma: {maSP}");
            if (quantity == null)
            {
                Console.WriteLine($"So luong ton kho: {displayQuantity} (DU LIEU TRONG)");
            }
            else
            {
                Console.WriteLine($"So luong ton kho : {displayQuantity}");
            }
            Console.WriteLine($"Trang thai kho: {status}");
            Console.WriteLine($"Du kien nhap hang: {ngayNhapHienthi}");
            Console.WriteLine("Nhan Enter de tiep tuc");
            Console.ReadLine();
        }
        static void Bai11()
        {
            //Bai 11: Tinh lai suat tiet kiem ngan hang & du toan tich luy
            Console.WriteLine("Bai 11: Tinh lai suat tiet kiem ngan hang & du toan tich luy");
            Console.WriteLine("Vui long nhap so tien gui ban dau P (VND)");
            decimal P = decimal.Parse(Console.ReadLine() ?? "Khong hop le! Vui long nhap lai");
            Console.WriteLine("Nhap lai suat nam (%/nam)");
            double r = double.Parse(Console.ReadLine() ?? "Khong hop le! Vui long nhap lai");
            Console.WriteLine("Nhap ky han gui n (thang)");
            int n = int.Parse(Console.ReadLine() ?? "Khong hop le! Vui long nhap lai");
            decimal tienLaidon = P * (decimal)(r / 100) * (decimal)(n / 12.0);
            double tienLaikep = (double)P * Math.Pow((1 + (r / 100) / 12), n);
            decimal loinhuanChenhLech = (decimal)tienLaikep - tienLaidon; 
            Console.WriteLine($"Tong tien lai (lai don): {tienLaidon:#,##0}");
            Console.WriteLine($"Tong tien lai (lai kep): {tienLaikep:#,##0}");
            if (loinhuanChenhLech > 0)
            {
                Console.WriteLine($"Loi nhuan chenh lech: {Math.Abs(loinhuanChenhLech):#,##0} (Lai kep toi uu hon)");
            }
            else if (loinhuanChenhLech < 0)
            {
                Console.WriteLine($"Loi nhuan chenh lech: {loinhuanChenhLech: #,##0} (Lai don toi uu hon)");
            }
            else
            {
                Console.WriteLine("Loi nhuan chenh lech bang 0");
            }
            Console.WriteLine("Nhan Enter de tiep tuc");
            Console.ReadLine();
        }
        static void Bai12()
        {
            // Bai 12: Bo ma hoa & giai ma tin nhan mat ma Ceasar (Ceasar Cipher)
            Console.WriteLine("Bai 12: Bo ma hoa & giai ma tin nhan mat ma Ceasar");
            Console.WriteLine("Vui long nhap vao chuoi van ban can ma hoa");
            string vanBangoc = Console.ReadLine();
            int k;
            Console.WriteLine("Nhap khoa dich chuyen (Shift Key k tu 1 - 25");
            while (!int.TryParse(Console.ReadLine(), out k) || k < 1 || k > 25)
            {
                Console.Write("Khoa k khong hop le! Vui long nhap lai so nguyen tu 1 - 25");
            }
            string maHoa = " ";
            foreach(char c in vanBangoc)
            {
                if (char.IsUpper(c))
                {
                    char newChar = (char)('A' + (c - 'A' + k) % 26);
                        maHoa += newChar;
                }
                else if (char.IsLower(c))
                {
                    char newChar = (char)('a' + (c - 'a' - k + 26) % 26);
                    maHoa += newChar;
                }
                else
                {
                   maHoa += c;
                }
            }
            string decryptedText = "";

            foreach (char c in maHoa)
            {
                if (char.IsUpper(c))
                {
                    char originalChar = (char)('A' + (c - 'A' - k + 26) % 26);
                    decryptedText += originalChar;
                }
                else if (char.IsLower(c))
                {
                    char originalChar = (char)('a' + (c - 'a' - k + 26) % 26);
                    decryptedText += originalChar;
                }
                else
                {
                    decryptedText += c;
                }
            }
            Console.WriteLine($"Van ban sau Ma hoa: {maHoa}");
            Console.WriteLine($"Van ban Giai ma: {decryptedText}");
            Console.WriteLine("Nhan Enter de tiep tuc");
            Console.ReadLine();
        }
        static void Bai13()
        {
            //Bài 13: Bãi Đỗ Xe Thông Minh & Tính Phí Gửi Xe Theo Thời Gian
            Console.WriteLine("Bai 13: Bai do xe thong minh & tinh phi gui xe theo thoi gian");
            Console.WriteLine("Vui long chon loai xe cua ban:  1 - xe may // 2 - o to // 3 - xe tai");
            int chonXe = int.Parse(Console.ReadLine());
            VehicleType loaiXe = (VehicleType)chonXe;
            Console.WriteLine("Nhap thoi gian xe vao (yyyy-MM-dd HH:mm):");
            DateTime checkIn = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Nhap thoi gian xe ra  (yyyy-MM-dd HH:mm):");
            DateTime checkOut = DateTime.Parse(Console.ReadLine());
            TimeSpan thoigiangui = checkOut - checkIn;
            double tongGiothucte = thoigiangui.TotalHours;
            int soGiotinhphi = (int)Math.Ceiling(tongGiothucte);
            decimal phi2GioDau = 0;
            decimal giaMoiGioTiepTheo = 0;

            if (loaiXe == VehicleType.Motorbike)
            {
                phi2GioDau = 5000;
                giaMoiGioTiepTheo = 2000;
            }
            else if (loaiXe == VehicleType.Car)
            {
                phi2GioDau = 20000;
                giaMoiGioTiepTheo = 10000;
            }
            else if (loaiXe == VehicleType.Truck)
            {
                phi2GioDau = 50000;
                giaMoiGioTiepTheo = 25000;
            }
            decimal phiGioDau = 0;
            decimal phiGioTiepTheo = 0;
            int soGioThem = 0;

            if (soGiotinhphi <= 2)
            {
                phiGioDau = phi2GioDau;
            }
            else
            {
                phiGioDau = phi2GioDau;
                soGioThem = soGiotinhphi - 2;
                phiGioTiepTheo = soGioThem * giaMoiGioTiepTheo;
            }
            decimal phuPhiQuaDem = 0;
            if (checkOut.Date > checkIn.Date)
            {
                phuPhiQuaDem = 30000;
            }
            decimal tongTien = phiGioDau + phiGioTiepTheo + phuPhiQuaDem;
            Console.WriteLine($"Tong thoi gian do: {tongGiothucte:F2} gio -> Tinh phi: {soGiotinhphi} gio");
            Console.WriteLine($"Phi 2 gio dau: {phiGioDau:#,##0} VNĐ");
            if (soGioThem > 0)
            {
                Console.WriteLine($"Phi {soGioThem} gio tiep theo: {phiGioTiepTheo:#,##0} VNĐ ({giaMoiGioTiepTheo:#,##0} x {soGioThem})");
            }
            if (phuPhiQuaDem > 0)
            {
                Console.WriteLine($"Phu phi qua dem: {phuPhiQuaDem:#,##0} VNĐ");
            }
            Console.WriteLine($"TONG PHI DO XE: {tongTien:#,##0} VNĐ");
            Console.WriteLine("Nhan Enter de thoat...");
            Console.ReadLine();
        }
        static void Bai14()
        {
            //Bài 14: Xử Lý Chuỗi Số An Toàn &Kiểm Tra Tràn Số(Overflow Exception)
            int soNguyen;
            Console.WriteLine("Bai 14: Xu ly chuoi so an toan & kiem tra tran so (Overflow Exception)");
            Console.WriteLine("Xin moi nhap vao mot chuoi bat ky tu ban phim");
            string input = Console.ReadLine();
            while (!int.TryParse(input, out soNguyen))
            {
                Console.Write("Loi: Gia tri khong phai la so nguyen hop le! Vui long nhap lai:");
                input = Console.ReadLine();
            }
            Console.WriteLine();
            Console.WriteLine($"Kiem tra Parse: Thanh cong! Gia tri int = {soNguyen}");
            if (soNguyen >= byte.MinValue && soNguyen <= byte.MaxValue)
            {
                Console.WriteLine("Phu hop kieu byte: OK (nam trong dai 0 - 255)");
            }
            else
            {
                Console.WriteLine("Phu hop kieu byte: KHONG");
            }
            if (soNguyen >= short.MinValue && soNguyen <= short.MaxValue)
            {
                Console.WriteLine("Phu hop kieu short: OK (nam trong dai -32,768 den 32,767");
            }
            else
            {
                Console.WriteLine("Phu hop kieu short: KHONG");
            }
            int soGoc = Math.Abs(soNguyen);
            int tongChuSo = 0;
            string phepTinh = "";
            if (soGoc == 0)
            {
                tongChuSo = 0;
                phepTinh = "0";
            }
            else
            {
                string chuoiSo = soGoc.ToString();
                for (int i = 0; i < chuoiSo.Length; i++)
                {
                    int chuSo = chuoiSo[i] - '0'; // Chuyen ky tu char thanh so int
                    tongChuSo += chuSo;

                    phepTinh += chuSo;
                    if (i < chuoiSo.Length - 1)
                    {
                        phepTinh += " + ";
                    }
                }
            }
            Console.WriteLine($"Tong cac chu so: {phepTinh} = {tongChuSo}");
            try
            {
                checked
                {
                    int ketQuaNhan = soNguyen * 10000000;
                    Console.WriteLine($"Kiem tra Tran so: An toan trong pham vi (Ket qua nhan voi 10,000,000 = {ketQuaNhan:#,##0}).");
                }
            }
            catch (OverflowException)
            {
                Console.WriteLine("Kiem tra Tran so: PHAT HIEN TRAN SO (OverflowException) khi thuc hien phep nhan lon!");
            }
            Console.WriteLine();
            Console.WriteLine("Nhan Enter de tiep tuc");
            Console.ReadLine();
        }
        static void Main(string[] args)
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
                Bai11();
                Bai12();
                Bai13();
                Bai14();
            }
    }
}
