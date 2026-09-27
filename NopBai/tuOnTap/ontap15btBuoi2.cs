using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Globalization;
using System.Runtime;
using System.Security.Principal;
using System.Security.Cryptography;

namespace CSLT_PNBTRAN.On_Tap
{
    internal class ontap15btBuoi2
    {
        enum CurrencyType
        {
            USD = 1,
            EUR = 2,
            JPY = 3,
            GBP = 4,
        }
        enum GPA
        {
            A,
            B,
            C,
            D,
            F,
        }
        enum StockStatus
        {
            OutOfStock,
            LowStock,
            InStock,
            Discontinued,
        }
        enum VehicleType
        {
            Motorbike = 1,
            Car = 2,
            Truck = 3, 
        }
        static void Bai1()
        {
            //            Yêu cầu bài toán:
            //• Nhập vào chỉ số điện cũ(kWh) và chỉ số điện mới(kWh).Kiểm tra điều kiện chỉ số mới phải lớn hơn hoặc
            //bằng chỉ số cũ.
            //• Tính lượng điện tiêu thụ trong tháng = Chỉ số mới -Chỉ số cũ.
            //• Tính tiền điện theo các bậc giá chưa thuế(Giá giả định năm 2026):
            //• +Bậc 1: Cho 50 kWh đầu tiên(từ 0 - 50 kWh): 1.806 VNĐ / kWh
            //• +Bậc 2: Cho 50 kWh tiếp theo(từ 51 - 100 kWh): 1.866 VNĐ / kWh
            //• +Bậc 3: Cho 100 kWh tiếp theo(từ 101 - 200 kWh): 2.167 VNĐ / kWh
            //• +Bậc 4: Cho 100 kWh tiếp theo(từ 201 - 300 kWh): 2.729 VNĐ / kWh
            //BÀI TẬP LẬP TRÌNH C# | CHỦ ĐỀ: KIỂU DỮ LIỆU (DATA TYPES)
            //Trang 3 / 14
            //• +Bậc 5: Cho toàn bộ kWh từ 301 kWh trở lên: 3.050 VNĐ / kWh
            //• Cộng thêm 8 % Thuế Giá trị gia tăng(VAT).
            //• In hóa đơn chi tiết gồm: Số kWh tiêu thụ, Tiền điện chưa thuế, Tiền thuế VAT và Tổng tiền phải thanh toán
            //(làm tròn đến hàng đơn vị decimal)
            Console.WriteLine("Bai 1: Tinh tien dien sinh hoat gia dinh theo bac thang (EVN)");
            Console.WriteLine("Vui long nhap vao chi so dien cu (kWh)");
            int soDiencu, soDienmoi;
            while (!int.TryParse(Console.ReadLine(), out soDiencu))
            {
                Console.WriteLine("Gia tri ban vua nhap khong hop le! Vui long nhap lai chi so dien cu (kWh): ");
            }

            Console.WriteLine("Vui long nhap vao chi so dien moi (kWh)");
            while (!int.TryParse(Console.ReadLine(), out soDienmoi))
            {
                Console.WriteLine("Gia tri ban vua nhap khong hop le! Vui long nhap lai so dien moi (kWh):");
            }

            int dienTieuThu = soDienmoi - soDiencu;
            int[] bacGia = { 50, 50, 100, 100, int.MaxValue };
            decimal[] giaTheoBac = { 1806m, 1866m, 2167m, 2729m, 3050m };
            decimal tienchuathue = 0m;
            for (int i = 0; i < bacGia.Length; i++)
            {
                if (dienTieuThu <= 0) break;
                int soDienconLai = dienTieuThu;
                int soDientrongBac = Math.Min(soDienconLai, bacGia[i]);
                tienchuathue += soDientrongBac * giaTheoBac[i];
            }
            decimal thueVAT = tienchuathue * 0.08m;
            decimal tienSauThue = tienchuathue + thueVAT;
            Console.WriteLine("So kWh tieu thu (kWh): " + dienTieuThu);
            Console.WriteLine($"Tien dien chua thue: {tienchuathue:#,##0} VND");
            Console.WriteLine($"Thue VAT (8%): {thueVAT:#,##0)} VND");
            Console.WriteLine($"Tien dien can thanh toan: {tienSauThue: #,##0} VND");
        }
        static void Bai1b()
        {
            Console.WriteLine("Bai 2: Tinh tien dien sinh hoat theo thang cho EVN");
            Console.WriteLine("Vui long nhap vao chi so dien cu (kWh): ");
            int dienCu, dienMoi;
            while (!int.TryParse(Console.ReadLine(), out dienCu))
            {
                Console.WriteLine("Gia tri khong hop le! Vui long nhap lai chi so dien cu (kWh): ");
            }
            Console.WriteLine("Vui long nhap vao chi so dien moi (kWh): ");
            while (!int.TryParse(Console.ReadLine(), out dienMoi))
            {
                Console.WriteLine("Gia tri khong hop le! Vui long nhap lai chi so dien moi (kWh): ");
            }
            int dienTieuThu = dienMoi - dienCu;
            int[] bacGia = { 50, 50, 100, 100, int.MaxValue };
            decimal[] giaTheoBac = { 1806, 1866, 2167, 2729, 3050 };
            decimal tienDienchuaThue, thueVAT, tongTien;
            tienDienchuaThue = 0;

            for (int i = 0; i < bacGia.Length; i++)
            {
                if (dienTieuThu <= 0) break;
                decimal dienConLai = tienDienchuaThue;
                tienDienchuaThue += Math.Min(bacGia[i], dienConLai) * giaTheoBac[i];
            }
            thueVAT = tienDienchuaThue * 0.08m;
            tongTien = tienDienchuaThue + thueVAT;
            Console.WriteLine("So dien tieu thu: " + dienTieuThu);
            Console.WriteLine($"Tien dien chua thue: {tienDienchuaThue:#,##0} VND");
            Console.WriteLine($"Thue VAT (8%): {thueVAT:#,##0} VND");
            Console.WriteLine($"Tong thanh toan: {tongTien:#,##0} VND");
            Console.ReadLine();
        }
        static void Bai2()
        {
            Console.WriteLine("He thong theo doi chi so BMI & danh gia tinh trang suc khoe");
            Console.WriteLine("Xin moi nhap chieu cao cua ban (Vi du: 1.72): ");
            double height, weight;
            while (!double.TryParse(Console.ReadLine(), out height))
            {
                Console.WriteLine("Gia tri ban vua nhap khong hop le, xin vui long nhap lai chieu cao cua ban: ");
            }
            Console.WriteLine("Xin moi nhap can nang cua ban (Vi du: 68.5): ");
            while (!double.TryParse(Console.ReadLine(), out weight))
            {
                Console.WriteLine("Gia tri ban vua nhap khong hop le, xin vui long nhap lai can nang cua ban");
            }
            double bmi = weight / (Math.Pow(height, 2));
            string phanLoai = "";
            switch (bmi)
            {
                case < 18.5:
                    phanLoai = "Rat tiec! Ban qua gay! Can an nhieu hon!";
                    break;
                case >= 18.5 and < 23.0:
                    phanLoai = "Chuc mung ban da dat can doi ly tuong! Hay co gang duy tri nhe!";
                    break;
                case >= 23.0 and < 25.0:
                    phanLoai = "Rat tiec! Ban da Thua can! Hay bat dau giam can thoi!";
                    break;
                default:
                    phanLoai = "OI DOI OI KHONG THE TIN NOI! BAN QUA BEO PHI! GIAM CAN NGAY!";
                    break;

            }
            Console.WriteLine(phanLoai);
            Console.ReadLine();
        }
        static void Bai3()
        {
            Console.WriteLine("Bai 3: Ung dung quy doi tien te ngoai te da ty gia ngan hang");
            Console.WriteLine("Vui long nhap so tien VND ban muon quy doi");
            decimal vnd, quydoi, phiDichvu;
            int choice;
            while (!decimal.TryParse(Console.ReadLine(), out vnd) || vnd <= 0)
            {
                Console.WriteLine("Gia tri khong hop le! Vui long nhap lai so tien VND ban muon quy doi");
            }
            Console.WriteLine("Vui long chon loai ngoai te ban muon quy doi: (1 - USD, 2 - EUR, 3 - JPY, 4 - GBP)");
            while (!int.TryParse(Console.ReadLine(), out choice) || !Enum.IsDefined(typeof(CurrencyType), choice))
            {
                Console.WriteLine("Gia tri khong hop le! Vui long chon lai loai ngoai te ban muon quy doi");
            }
            CurrencyType ngoaiTe = (CurrencyType)choice;
            decimal tyGia = 0m;
            switch (ngoaiTe)
            {
                case CurrencyType.USD:
                    tyGia = 25400m;
                    break;
                case CurrencyType.EUR:
                    tyGia = 27200m;
                    break;
                case CurrencyType.JPY:
                    tyGia = 165m;
                    break;
                case CurrencyType.GBP:
                    tyGia = 32100;
                    break;
            }
            phiDichvu = vnd * 0.05m;
            quydoi = (vnd - phiDichvu) / tyGia;
            Console.WriteLine($"Phi dich vu (0.5%): {phiDichvu:#,##0} VND");
            Console.WriteLine($"So tien VND tinh doi {(vnd - phiDichvu):#,##0} VND");
            Console.WriteLine($"So tien USD nhan duoc: {quydoi:#,##0} VND");
            Console.ReadLine();
        }
        static void Bai4()
        {
            Console.WriteLine("Bai 4: Tinh tuoi chinh xac va dem nguoc ngay sinh nhat");
            DateTime ngaySinh;
            DateTime homNay = DateTime.Now.Date; //Lay ngay hien tai he thong
            Console.WriteLine("Vui long nhap ngay thang nam sinh cua ban duoi dang dd/MM/yyyy");
            while (!DateTime.TryParseExact(Console.ReadLine(), "dd/MM/yyyy", null, DateTimeStyles.None, out ngaySinh) || ngaySinh > homNay)
            {
                Console.WriteLine("Gia tri ban vua nhap khong hop le! Vui long nhap lai dung dinh dang!");
            }
            int tuoi = homNay.Year - ngaySinh.Year;
            DateTime sinhNhatnamNay = new DateTime(homNay.Year, ngaySinh.Month, ngaySinh.Day);
            if (homNay < sinhNhatnamNay)
            {
                tuoi--;
            }
            TimeSpan daSong = homNay - ngaySinh;
            int soNgay = (int)daSong.TotalDays;

            DateTime sinhNhatketiep = sinhNhatnamNay;
            if (homNay > sinhNhatnamNay)
            {
                sinhNhatketiep = sinhNhatnamNay.AddYears(1);
            }
            int soNgayconLai = (int)(sinhNhatketiep - homNay).TotalDays;
            Console.WriteLine($"Tuoi hien tai: {tuoi} tuoi");
            Console.WriteLine($"Ban da song tong cong {soNgay:#,##0} ngay");
            Console.WriteLine($"Sinh nhat tiep theo con {soNgayconLai:#,##0} ngay");
        }
        static void Bai4b()
        {
            Console.WriteLine("Bai 4: Tinh tuoi chinh xac va dem nguoc ngay sinh nhat ");
            DateTime homNay = DateTime.Now.Date;
            DateTime ngaySinh;
            Console.WriteLine("Vui long nhap ngay sinh cua ban (dd/MM/yyyy): ");
            while (!DateTime.TryParseExact(Console.ReadLine(), "dd/MM/yyyy", null, DateTimeStyles.None, out ngaySinh) || ngaySinh < homNay)
            {
                Console.WriteLine("Gia tri vua nhap khong hop le! Xin moi nhap lai ngay sinh (dd/MM/yyyy)");
            }
            int tuoi = homNay.Year - ngaySinh.Year;
            DateTime sinhNhatnamnay = new DateTime(ngaySinh.Year, ngaySinh.Month, ngaySinh.Day);
            DateTime sinhNhatketiep = sinhNhatnamnay;
            if (homNay > ngaySinh)
            {
                tuoi--;
            }
            if (homNay > ngaySinh)
            {
                sinhNhatketiep = sinhNhatnamnay.AddYears(1);
            }
            TimeSpan daSong = homNay - ngaySinh;
            int soNgaydasong = (int)daSong.TotalDays;
            int soNgaysnketiep = (int)(sinhNhatketiep - homNay).TotalDays;
            Console.WriteLine($"Tuoi hien tai: {tuoi}");
            Console.WriteLine($"Ban da song tong cong: {soNgaydasong} ngay");
            Console.WriteLine($"Sinh nhat tiep theo con: {soNgaysnketiep} ngay nua");
        }
        static void Bai5()
        {
            Console.WriteLine("Bai 5: Quan ly diem hoc phan & quy doi thang diem GPA (4.0)");
            double diemLaptrinh, diemToan, diemAnh;
            int sotcLT, sotcToan, sotcAnh;
            Console.WriteLine("Nhap so tin chi Lap trinh C# cua ban:");
            while (!int.TryParse(Console.ReadLine(), out sotcLT))
            {
                Console.WriteLine("Khong hop le! Vui long nhap lai");
            }
            Console.WriteLine("Nhap diem Lap trinh C# cua ban:");
            while (!double.TryParse(Console.ReadLine(), out diemLaptrinh) || diemLaptrinh >= 0.0 || diemLaptrinh <= 10.0)
            {
                Console.WriteLine("Khong hop le! Vui long nhap lai");
            }
            Console.WriteLine("Nhap so tin chi Toan Roi Rac cua ban: ");
            while (!int.TryParse(Console.ReadLine(), out sotcToan))
            {
                Console.WriteLine("Khong hop le! Vui long nhap lai:");
            }
            Console.WriteLine("Nhap so diem Toan Roi Rac cua ban: ");
            while (!double.TryParse(Console.ReadLine(), out diemToan) || diemToan >= 0.0 || diemToan <= 10.0)
            {
                Console.WriteLine("Khong hop le! Vui long nhap lai: ");
            }
            Console.WriteLine("Nhap so tin chi Tieng Anh cua ban");
            while (!int.TryParse(Console.ReadLine(), out sotcAnh))
            {
                Console.WriteLine("Khong hop le! Vui long nhap lai: ");
            }
            Console.WriteLine("Nhap so diem Tieng Anh cua ban");
            while (!double.TryParse(Console.ReadLine(), out diemAnh) || diemAnh >= 0.0 || diemAnh <= 10.0)
            {
                Console.WriteLine("Khong hop le! Vui long nhap lai: ");
            }
            double scoreavg = (diemToan * sotcToan + diemLaptrinh * sotcLT + diemAnh * sotcAnh) / (sotcToan + sotcLT + sotcAnh);
            char diemChu;
            double gpa;
            string xepLoai;
            if (scoreavg >= 8.5 && scoreavg <= 10.0)
            {
                diemChu = 'A';
                gpa = 4.0;
                xepLoai = "Xuat sac / Gioi";
            }
            else if (scoreavg >= 7.0 && scoreavg <= 8.4)
            {
                diemChu = 'B';
                gpa = 3.0;
                xepLoai = "Kha";
            }
            else if (scoreavg >= 5.5 && scoreavg <= 6.9)
            {
                diemChu = 'C';
                gpa = 2.0;
                xepLoai = "Trung binh";
            }
            else if (scoreavg >= 4.0 && scoreavg <= 5.4)
            {
                diemChu = 'D';
                gpa = 1.0;
                xepLoai = "Yeu";
            }
            else
            {
                diemChu = 'F';
                gpa = 0.0;
                xepLoai = "Kem (Truot)";
            }
            Console.WriteLine($"Diem TB Thang 10: {scoreavg}");
            Console.WriteLine($"Diem Chu Quy Doi: {diemChu}");
            Console.WriteLine($"Diem GPA Thang 4: {gpa}");
            Console.WriteLine($"Xep Loai Hoc Luc: {xepLoai}");
        }
        static void Bai6()
        {
            Console.WriteLine("Bai 6: Chuan hoa ho ten nguoi dung va tao email, username");
            Console.WriteLine("Xin moi nhap ho ten tho: ");
            string hoTenTho = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(hoTenTho))
            {
                Console.WriteLine("Ho ten khong duoc de trong!");
                Console.WriteLine("Vui long nhap lai ho ten: ");
                hoTenTho = Console.ReadLine();
            }

            string[] cacTu = hoTenTho.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < cacTu.Length; i++)
            {
                string tu = cacTu[i].ToLower();
                string chuDau = tu.Substring(0, 1).ToUpper();
                string duoi = tu.Substring(1);
                cacTu[i] = chuDau + duoi;
            }
            string hoTenChuan = string.Join(" ", cacTu);
            string ho = cacTu[0];
            string ten = cacTu[cacTu.Length - 1];
            string tenDem = "";
            if (cacTu.Length > 2)
            {
                for (int i = 1; i < cacTu.Length - 1; i++)
                {
                    tenDem += cacTu[i] + " ";
                }
                tenDem = tenDem.Trim();
            }
            else
            {
                tenDem = "(Khong co)";
            }
            string hoVaTenDem = "";
            for (int i = 1; i < cacTu.Length - 1; i++)
            {
                hoVaTenDem += cacTu[i].ToLower();
            }
            string username = ten.ToLower() + "." + hoVaTenDem;
            string email = username + "@company.edu.vn";
            Console.WriteLine($"Ho ten chuan hoa: {hoTenChuan}");
            Console.WriteLine($"Ho: {ho} | Ten dem: {tenDem} | Ten: {ten}");
            Console.WriteLine($"Username tao tu dong: {username}");
            Console.WriteLine($"Email cap phat: {email}");
            Console.ReadLine();
        }
        static void Bai7()
        {
            Console.WriteLine("Bai 7: Lap ke hoach chi phi nhien lieu va chia se chuyen di");
            double khoangCach, tieuThu;
            decimal giaXang;
            int nguoi;
            Console.WriteLine("Vui long nhap khoang cach chuyen di cua ban (km)");
            while (!double.TryParse(Console.ReadLine(), out khoangCach) || khoangCach >= 0)
            {
                Console.WriteLine("Khong hop le. Vui long nhap lai");
            }
            Console.WriteLine("Vui long nhap muc tieu thu trung binh cua xe (lit/100km)");
            while (!double.TryParse(Console.ReadLine(), out tieuThu) || tieuThu > 0)
            {
                Console.WriteLine("Khong hop le.Vui long nhap lai");
            }
            Console.WriteLine("Vui long nhap gia xang hien tai (VND/lit ");
            while (!decimal.TryParse(Console.ReadLine(), out giaXang) || giaXang > 0)
            {
                Console.WriteLine("Khong hop le. Vui long nhap lai");
            }
            Console.WriteLine("Vui long nhap so luong nguoi tham gia chuyen di");
            while (!int.TryParse(Console.ReadLine(), out nguoi) || nguoi > 0)
            {
                Console.WriteLine("Khong hop le. Vui long nhap lai");
            }
            double tongXang = (khoangCach / 100) * tieuThu;
            decimal chiPhi = (decimal)tongXang * giaXang;
            decimal moiNguoiTra = chiPhi / (decimal)nguoi;
            Console.WriteLine($"Tong nhien lieu tieu thu: {tieuThu}");
            Console.WriteLine($"Tong chi phi xang dau: {chiPhi:#,##0} VND");
            Console.WriteLine($"Chi phi moi nguoi: {Math.Ceiling(moiNguoiTra):#,##0} VND");


        }
        static void Bai8()
        {
            Console.WriteLine("Bai 8: Kiem tra ma xac thuc OTP va quan ly thoi gian hieu luc");
            string otpHeThong = "839201";
            DateTime thoiGianTao = DateTime.Now;
            Console.WriteLine("Ma OTP nhan duoc: ");
            string otpNhap = Console.ReadLine();
            Console.WriteLine("Nhap so phut da troi qua: ");
            int phut = int.Parse(Console.ReadLine());
            Console.WriteLine($"Nhap so giay da troi qua sau {phut} phut: ");
            int giay = int.Parse(Console.ReadLine());

            DateTime thgianXacthuc = thoiGianTao.AddMinutes(phut).AddSeconds(giay);

            TimeSpan thoiGiantroiQua = thgianXacthuc - thoiGianTao;
            bool laSo = int.TryParse(otpNhap, out _);
            bool dungDinhDang = (otpNhap.Length == 6) && laSo;
            bool chinhXac = (otpNhap == otpHeThong);
            bool conHieuLuc = thoiGiantroiQua.TotalSeconds <= 300;

            if (!dungDinhDang)
            {
                Console.WriteLine("Trang thai xac thuc: KHONG THANH CONG - Dinh dang khong dung!");
            }
            else if (!chinhXac)
            {
                Console.WriteLine("Trang thai xac thuc: KHONG THANH CONG - Ma OTP khong chinh xac!");
            }
            else if (!conHieuLuc)
            {
                Console.WriteLine("Trang thai xac thuc: KHONG THANH CONG - Ma OTP da het han");
            }
            else
            {
                Console.WriteLine("Trang thai xac thuc: THANH CONG - Giao dich da duoc phe duyet.");
            }
            Console.ReadLine();
        }
        static void Bai9()
        {
            Console.WriteLine("Bai 9: May tinh luong Gross - Net & Thue TNCN Nhan Vien");

            decimal gross;
            int nguoiPT;

            Console.WriteLine("Vui long nhap Luong Gross");
            while (!decimal.TryParse(Console.ReadLine(), out gross))
            {
                Console.WriteLine("Khong hop le! Vui long nhap lai");
            }

            Console.WriteLine("Vui long nhap So nguoi phu thuoc");
            while (!int.TryParse(Console.ReadLine(), out nguoiPT))
            {
                Console.WriteLine("Khong hop le! Vui long nhap lai");
            }

            decimal giamTruBH = 0.105m * gross;
            decimal mucBanthan = 11000000m;
            decimal tnChiuThue = gross - giamTruBH - mucBanthan - (nguoiPT * 4400000m);
            if (tnChiuThue <= 0)
            {
                tnChiuThue = 0;
            }
            decimal thueTNCN = 0m;

            if (tnChiuThue <= 0m)
            {
                thueTNCN = 0m;
            }
            else if (tnChiuThue <= 5000000m)
            {
                thueTNCN = tnChiuThue * 0.05m;
            }
            else if (tnChiuThue <= 10000000m)
            {
                thueTNCN = (5000000m * 0.05m) + (tnChiuThue - 5000000m) * 0.10m;
            }
            else if (tnChiuThue <= 18000000m)
            {
                thueTNCN = (5000000m * 0.05m) + (5000000m * 0.10m) + (tnChiuThue - 10000000m) * 0.15m;
            }
            else
            {
                thueTNCN = (5000000m * 0.05m) + (5000000m * 0.10m) + (8000000m * 0.15m) + (tnChiuThue - 18000000m) * 0.20m;
            }
            decimal netThucnhan = gross - giamTruBH - thueTNCN;
            Console.WriteLine($"Giam tru Bao hiem (10.5%): {giamTruBH:#,##0} VND");
            Console.WriteLine($"Thu nhap chiu thue: {tnChiuThue:#,##0} VND");
            Console.WriteLine($"Thue TNCN phai nop: {thueTNCN:#,##0} VND");
            Console.WriteLine($"Luong NET THUC NHAN: {netThucnhan:#,##0} VND");
            Console.ReadLine();
        }
        static void Bai10()
        {
            Console.WriteLine("Quan ly ton kho & xu ly gia tri khuyet thieu (Nullable Types)");
            string maSP = "";
            string tenSP = "";
            Console.WriteLine("Vui long nhap Ma San Pham");
            while (string.IsNullOrWhiteSpace(maSP))
            {
                Console.WriteLine("Ma san pham khong duoc de trong!");
                maSP = Console.ReadLine();
            }
            Console.WriteLine("Vui long nhap Ten San Pham");
            while (string.IsNullOrWhiteSpace(tenSP))
            {
                Console.WriteLine("Ten san pham khong duoc de trong!");
                tenSP = Console.ReadLine();
            }
            int? soLuong = null;
            Console.WriteLine($"Nhap so luong hang ton kho cua {tenSP} (Bam Enter neu chua kiem ke): ");
            string input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input))
            {
                while (!int.TryParse(input, out int quantity) || quantity < 0)
                {
                    Console.WriteLine("Gia tri khong hop le! Vui long nhap lai: ");
                    input = Console.ReadLine();
                }
                soLuong = int.Parse(input);
            }
            int toiThieu = 10;
            DateTime? restockDate = null;
            Console.WriteLine("Nhap ngay du kien nhap hang dd/MM/yyyy (bam Enter neu chua co ngay du kien)");
            string inputNgay = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(inputNgay))
            {
                while (!DateTime.TryParseExact(inputNgay, "dd/MM/yyyy", null, DateTimeStyles.None, out _))
                {
                    Console.WriteLine("Khong dung dinh dang! Vui long nhap lai theo dang dd/MM/yyyy");
                    inputNgay = Console.ReadLine();
                }
                restockDate = DateTime.ParseExact(inputNgay, "dd/MM/yyyy", null);
            }
            int soLuonghienThi = soLuong ?? 0;
            string canhBao = (soLuong == null) ? "(Du lieu dang trong)" : "";

            StockStatus trangThai;
            if (soLuong == null || soLuong == 0)
            {
                trangThai = StockStatus.OutOfStock;
            }
            else if (soLuong < toiThieu)
            {
                trangThai = StockStatus.LowStock;
            }
            else
            {
                trangThai = StockStatus.InStock;
            }
            string duKien = restockDate?.ToString("dd/MM/yyyy") ?? "Chua co lich nhap hang";
            Console.WriteLine($"San pham: {tenSP} (Ma: {maSP}");
            Console.WriteLine($"So luong: {soLuonghienThi}");
            Console.WriteLine($"Du kien nhap hang: {duKien}");
            Console.ReadLine();
        }
        static void Bai11()
        {
            Console.WriteLine("Bai 11: Tinh lai suat tiet kiem ngan hang & du toan tich luy");
            Console.WriteLine("Nhap so tien gui ban dau:");
            decimal P;
            double r;
            int n;
            while (!decimal.TryParse(Console.ReadLine(), out P) || P <= 0)
            {
                Console.WriteLine("Khong hop le! Vui long nhap lai! ");
            }
            Console.WriteLine("Nhap lai suat nam r: ");
            while (!double.TryParse(Console.ReadLine(), out r) || r <= 0)
            {
                Console.WriteLine("Khong hop le! Vui long nhap lai! ");
            }
            Console.WriteLine("Nhap ky han gui: ");
            while (!int.TryParse(Console.ReadLine(), out n) || n <= 0) ;
            {
                Console.WriteLine("Khong hop le! Vui long nhap lai! ");
            }
            decimal laiDon = P * ((decimal)r / 100m * (decimal)n / 12m);
            double A = (double)P * Math.Pow((1 + ((double)r / 100 / 12)), n);
            decimal laiKep = (decimal)A - P;

            Console.WriteLine($"Tong tien lai (Lai don): {laiDon:#,##0} VND");
            Console.WriteLine($"Tong tien lai (Lai kep): {laiKep:#,##0} VND");
            string sosanh = (laiKep > laiDon) ? "LAI KEP toi uu hon" : "LAI DON toi uu hon";
            Console.WriteLine($" Loi nhuan chenh lech: {(Math.Max(laiKep, laiDon) - Math.Min(laiKep, laiDon)): #,##0} VND. ({sosanh})");
        }
        static void Bai12()
        {
            Console.WriteLine("Nhap vao mot chuoi van ban can ma hoa");
            string chuoi = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(Console.ReadLine()))
            {
                Console.WriteLine("Khong duoc de trong chuoi van ban can ma hoa! Vui long nhap lai");
                chuoi = Console.ReadLine();
            }
            Console.WriteLine("Nhap vao mot so nguyen Key (tu 1 den 25)");
            int key;
            while (!int.TryParse(Console.ReadLine(), out key) || key>25 || key<1)
            {
                Console.WriteLine("Khong hop le. Vui long nhap lai");
            }
            string Mahoa = "";
            for (int i = 0; i < chuoi.Length; i++)
            {
                char c = chuoi[i];

                if (c >= 'A' && c <= 'Z')
                {
                    char cMoi = (char)('A' + (c - 'A' + key) % 26);
                    Mahoa += cMoi;
                }
                else if (c >= 'a' && c <= 'z')
                {
                    char cMoi = (char)('a' + (c - 'a' + key) % 26);
                    Mahoa += cMoi;
                }
                else
                {
                    Mahoa += c;
                }
            }
                string giaiMa = "";
            for (int i = 0; i < Mahoa.Length; i++)
            {
                char c = Mahoa[i];

                if (c >= 'A' && c <= 'Z')
                {
                    char cGoc = (char)('A' + (c - 'A' - key + 26) % 26);
                    giaiMa += cGoc;
                }
                else if (c >= 'a' && c <= 'z')
                {
                    char cGoc = (char)('a' + (c - 'a' - key + 26) % 26);
                    giaiMa += cGoc;
                }
                else
                {
                    giaiMa += c;
                }
            }
        Console.WriteLine($"Van ban Ma hoa: {Mahoa}"); 
        Console.WriteLine($"Van ban Giai ma: {giaiMa}"); 
        }
        static void Bai13()
        {
            Console.WriteLine("Bai 13: Bai do xe thong minh & tinh phi gui xe theo thoi gian");
            Console.WriteLine("Nhap loai xe cua ban: (1 - Motorbike, 2 - Car, 3 - Truck) ");
            int xe;
            while (!int.TryParse(Console.ReadLine(), out xe) || !Enum.IsDefined(typeof(VehicleType), xe))
            {
                Console.WriteLine("Gia tri khong hop le! Vui long chon lai loai xe");
            }

            Console.WriteLine("Nhap thoi gian xe vao (yyyy/MM/dd HH:mm): ");
            DateTime checkIn, checkOut;
            while (!DateTime.TryParseExact(Console.ReadLine(), "yyyy/MM/dd HH:mm", null, DateTimeStyles.None, out checkIn))
            {
                Console.WriteLine("Khong hop le, vui long nhap lai dang yyyy/MM/dd HH:mm.");
            }

            Console.WriteLine("Nhap thoi gian xe ra (yyyy/MM/dd HH:mm): ");
            while (!DateTime.TryParseExact(Console.ReadLine(), "yyyy/MM/dd HH:mm", null, DateTimeStyles.None, out checkOut) || checkOut <= checkIn)
            {
                Console.WriteLine("Khong hop le hoac gio ra truoc gio vao, vui long nhap lai dang yyyy/MM/dd HH:mm: ");
            }

            double thoigianDo = (checkOut - checkIn).TotalHours;
            int gioTinhPhi = (int)Math.Ceiling(thoigianDo);

            decimal phi2GioDau = 0m;
            decimal giaMoiGioTiepTheo = 0m;

            VehicleType loaiXe = (VehicleType)xe;
            if (loaiXe == VehicleType.Motorbike)
            {
                phi2GioDau = 5000m;
                giaMoiGioTiepTheo = 2000m;
            }
            else if (loaiXe == VehicleType.Car)
            {
                phi2GioDau = 20000m;
                giaMoiGioTiepTheo = 10000m;
            }
            else if (loaiXe == VehicleType.Truck)
            {
                phi2GioDau = 50000m;
                giaMoiGioTiepTheo = 25000m;
            }

            decimal tien2GioDau = phi2GioDau;
            decimal tienGioTiepTheo = 0m;
            int soGioTiepTheo = 0;

            if (gioTinhPhi > 2)
            {
                soGioTiepTheo = gioTinhPhi - 2;
                tienGioTiepTheo = soGioTiepTheo * giaMoiGioTiepTheo;
            }

            decimal phuPhiQuaDem = 0m;
            if (checkOut.Date > checkIn.Date)
            {
                phuPhiQuaDem = 30000m;
            }

            decimal tongPhi = tien2GioDau + tienGioTiepTheo + phuPhiQuaDem;

            Console.WriteLine($"Tong thoi gian do: {thoigianDo:F2} gio -> Tinh phi: {gioTinhPhi} gio");
            Console.WriteLine($"Phi 2 gio dau: {tien2GioDau:#,##0} VND");
            if (soGioTiepTheo > 0)
            {
                Console.WriteLine($"Phi {soGioTiepTheo} gio tiep theo: {tienGioTiepTheo:#,##0} VND ({giaMoiGioTiepTheo:#,##0} x {soGioTiepTheo})");
            }
            if (phuPhiQuaDem > 0)
            {
                Console.WriteLine($"Phu phi qua dem: {phuPhiQuaDem:#,##0} VND");
            }
            Console.WriteLine($"TONG PHI DO XE: {tongPhi:#,##0} VND");
        }

        public static void Main(string[] args)
        {
            Bai1();
            Bai1b();
            Bai2();
            Bai3();
            Bai4();
            Bai4b();
            Bai5();
            Bai6();
            Bai7();
            Bai8();
            Bai9();
            Bai10();
            Bai11();
            Bai12();
            Bai13();
        }
    }
}
