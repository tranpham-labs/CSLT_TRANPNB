using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
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
    internal class _15tinhhuongthucte
    {
        public static void Main(string[] args)
        {
            //Bài 1: Tính Tiền Điện Sinh Hoạt Gia Đình Theo Bậc Thang(EVN)
            //Tình huống thực tế: Tập đoàn Điện lực Việt Nam(EVN) áp dụng biểu giá điện sinh hoạt bậc thang lũy tiến
            //để khuyến khích người dân tiết kiệm điện.Hãy viết chương trình tính hóa đơn tiền điện hàng tháng cho một
            //hộ gia đình.
            //Kiến thức trọng tâm: Kiểu decimal, ép kiểu dữ liệu, định dạng tiền tệ({ 0:C} hoặc #,##0 VNĐ), tính toán toán học.
            //Yêu cầu bài toán:
            //• Nhập vào chỉ số điện cũ (kWh) và chỉ số điện mới (kWh). Kiểm tra điều kiện chỉ số mới phải lớn hơn hoặc bằng chỉ số cũ.
            //• Tính lượng điện tiêu thụ trong tháng = Chỉ số mới - Chỉ số cũ.
            //• Tính tiền điện theo các bậc giá chưa thuế (Giá giả định năm 2026):
            //• + Bậc 1: Cho 50 kWh đầu tiên(từ 0 - 50 kWh) : 1.806 VNĐ/kWh
            //• + Bậc 2: Cho 50 kWh tiếp theo(từ 51 - 100 kWh) : 1.866 VNĐ/kWh
            //• + Bậc 3: Cho 100 kWh tiếp theo(từ 101 - 200 kWh) : 2.167 VNĐ/kWh
            //• + Bậc 4: Cho 100 kWh tiếp theo(từ 201 - 300 kWh) : 2.729 VNĐ/kWh
            //• + Bậc 5: Cho toàn bộ kWh từ 301 kWh trở lên: 3.050 VNĐ/kWh
            //• Cộng thêm 8 % Thuế Giá trị gia tăng(VAT).
            //• In hóa đơn chi tiết gồm: Số kWh tiêu thụ, Tiền điện chưa thuế, Tiền thuế VAT và Tổng tiền phải thanh toán (làm tròn đến hàng đơn vị decimal).
            //Ví dụ minh họa Input / Output:
            //--- INPUT ---
            //Nhập chỉ số điện cũ(kWh): 1250
            //Nhập chỉ số điện mới(kWh): 1520
            //--- OUTPUT ---
            //Số điện tiêu thụ: 270 kWh
            //Tiền điện chưa thuế: 636,650 VNĐ
            //Thuế VAT(8%) : 50,932 VNĐ
            //Tổng thanh toán: 687,582 VNĐ
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
                //Bài 2: Hệ Thống Theo Dõi Chỉ Số BMI & Đánh Giá Tình Trạng Sức Khỏe
                //Tình huống thực tế: Một ứng dụng theo dõi sức khỏe cá nhân cần tính chỉ số khối cơ thể(BMI -Body Mass
                //Index) dựa trên chiều cao và cân nặng do người dùng cung cấp, đồng thời đưa ra lời khuyên về cân nặng lý
                //tưởng.
                //Kiến thức trọng tâm: Kiểu double, ép kiểu, Math.Pow(), định dạng số thập phân({ 0:F2}), cấu trúc rẽ nhánh.
                //Yêu cầu bài toán:
                //• Nhập vào chiều cao(tính bằng mét, ví dụ 1.72) và cân nặng(tính bằng kg, ví dụ 68.5).
                //• Tính chỉ số BMI theo công thức: BMI = Cân nặng / (Chiều cao ^ 2).
                //• Phân loại tình trạng sức khỏe theo chuẩn WHO dành cho người châu Á:
                //• +BMI < 18.5: Gầy(Thiếu cân)
                //• +18.5 <= BMI < 23.0: Bình thường(Lý tưởng)
                //• +23.0 <= BMI < 25.0: Thừa cân(Tiền béo phì)
                //• +BMI >= 25.0: Béo phì
                //• Tính dải cân nặng lý tưởng cho chiều cao đó(Cân nặng tối thiểu = 18.5 * Chiều cao^2; Cân nặng tối đa =
                //22.9 * Chiều cao ^ 2).
                //• Xuất ra chỉ số BMI(lấy 2 chữ số thập phân), phân loại và khoảng cân nặng lý tưởng.
                //Ví dụ minh họa Input / Output:
                //BÀI TẬP LẬP TRÌNH C# | CHỦ ĐỀ: KIỂU DỮ LIỆU (DATA TYPES)
                //Trang 4 / 14
                //-- - INPUT-- -
                //Chiều cao(m): 1.68
                //Cân nặng(kg): 72.0
                //-- - OUTPUT-- -
                //Chỉ số BMI của bạn: 25.51
                //Phân loại sức khỏe: Béo phì
                //Khuyên dùng: Cân nặng lý tưởng của bạn nên từ 52.21 kg đến 64.63 kg.
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
                //Bài 3: Ứng Dụng Quy Đổi Tiền Tệ Ngoại Tệ Đa Tỷ Giá Ngân Hàng
                //Tình huống thực tế: Một quầy đổi tiền tại sân bay cần ứng dụng tính toán nhanh số tiền khách hàng nhận
                //được khi đổi từ Việt Nam Đồng(VND) sang các loại ngoại tệ phổ biến(USD, EUR, JPY, GBP) có tính phí dịch
                //vụ.
                //Kiến thức trọng tâm: Kiểu decimal, enum (CurrencyType), switch-case, định dạng tiền tệ quốc tế.
                //Yêu cầu bài toán:
                //• Tạo một enum tên CurrencyType gồm: USD, EUR, JPY, GBP.
                //• Khai báo tỷ giá cố định(Ví dụ: 1 USD = 25,400 VNĐ; 1 EUR = 27,200 VNĐ; 1 JPY = 165 VNĐ; 1 GBP =
                //32,100 VNĐ).
                //• Nhập vào số tiền VNĐ cần đổi(decimal) và chọn loại ngoại tệ muốn đổi.
                //• Phí dịch vụ quy đổi là 0.5 % trên tổng số tiền VNĐ.
                //• Tính số tiền VNĐ thực tế sau khi trừ phí, sau đó quy đổi ra ngoại tệ tương ứng.
                //• In kết quả chính xác đến 2 chữ số thập phân kèm ký hiệu tiền tệ.
                //Ví dụ minh họa Input / Output:
                //--- INPUT ---
                //Nhập số tiền VNĐ: 10,000,000
                //Chọn ngoại tệ (1-USD, 2-EUR, 3-JPY, 4-GBP): 1
                //--- OUTPUT ---
                //Phí dịch vụ(0.5%) : 50,000 VNĐ
                //Số tiền VNĐ tính đổi: 9,950,000 VNĐ
                //Số tiền USD nhận được: 391.73 USD

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
                //Bài 4: Tính Tuổi Chính Xác & Đếm Ngược Ngày Sinh Nhật
                //Tình huống thực tế: Hệ thống chăm sóc khách hàng của một công ty bán lẻ cần tự động tính tuổi chính xác
                //của khách hàng và đếm số ngày còn lại đến sinh nhật tiếp theo để gửi voucher ưu đãi.
                //Kiến thức trọng tâm: Kiểu DateTime, TimeSpan, DateTime.ParseExact, toán tử trừ hai ngày, ép kiểu.
                //Yêu cầu bài toán:
                //• Nhập ngày tháng năm sinh của người dùng dưới dạng chuỗi 'dd/MM/yyyy'(ví dụ: '25/10/2002').
                //• Chuyển đổi chuỗi thành DateTime sử dụng DateTime.TryParseExact để đảm bảo không bị lỗi định dạng.
                //• Lấy ngày hiện tại hệ thống(DateTime.Now.Date).
                //• Tính tuổi chính xác tính theo số năm.
                //• Xác định ngày sinh nhật tiếp theo trong năm nay hoặc năm sau.Tính số ngày còn lại đến sinh nhật đó.
                //• Hiển thị: Tuổi hiện tại, Tổng số ngày đã sống từ lúc sinh ra, và Số ngày còn lại đến sinh nhật kế tiếp.
                //Ví dụ minh họa Input / Output:
                //---INPUT-- -
                //Nhập ngày sinh(dd/ MM / yyyy): 15 / 09 / 2003
                //-- - OUTPUT-- -
                //Tuổi hiện tại: 22 tuổi
                //Bạn đã sống tổng cộng: 8,376 ngày
                //Sinh nhật tiếp theo còn: 25 ngày nữa
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
                //Bài 5: Quản Lý Điểm Học Phần & Quy Đổi Thang Điểm GPA(4.0)
                //Tình huống thực tế: Hệ thống quản lý đào tạo đại học cần tính điểm trung bình tín chỉ(GPA) học kỳ cho sinh viên dựa trên điểm số các môn học và quy đổi sang thang điểm chữ(A, B, C, D, F) cùng thang điểm 4.
                //Kiến thức trọng tâm: Kiểu float hoặc double, char, enum, ép kiểu điểm số, định dạng bảng xuất.
                //Yêu cầu bài toán:
                //• Nhập điểm số(thang 10, kiểu double) và số tín chỉ(int) của 3 môn học: Lập trình C#, Toán rời rạc, Tiếng
                //Anh.
                //• Tính điểm trung bình trọng số (Weighted Average Score):
                // Score_Avg = (Điểm1* TC1 + Điểm2* TC2 +Điểm3 * TC3) / (TC1 + TC2 + TC3).
                //• Quy đổi Score_Avg sang Điểm chữ(char/string) và Thang điểm 4 (double):
                //• + [8.5 - 10.0]: Điểm A | Thang 4: 4.0 | Xếp loại: Xuất sắc / Giỏi
                //• + [7.0 - 8.4] : Điểm B | Thang 4: 3.0 | Xếp loại: Khá
                //• + [5.5 - 6.9] : Điểm C | Thang 4: 2.0 | Xếp loại: Trung bình
                //• + [4.0 - 5.4] : Điểm D | Thang 4: 1.0 | Xếp loại: Yếu
                //• + [< 4.0] : Điểm F | Thang 4: 0.0 | Xếp loại: Kém(Trượt)
                //• Xuất bảng điểm chi tiết và GPA làm tròn 2 chữ số thập phân.
                //Ví dụ minh họa Input / Output:
                //--- INPUT ---
                //C# (4 TC): 8.8
                //Toán (3 TC): 7.2
                //Tiếng Anh(2 TC): 6.5
                //--- OUTPUT ---
                //Điểm TB Thang 10: 7.76
                //Điểm Chữ Quy Đổi: B
                //Điểm GPA Thang 4: 3.0
                //Xếp Loại Học Lực: Khá
                Console.WriteLine("Bai 5: Quan ly diem hoc phan & quy doi thang diem GPA(4.0)");
                double diemToan, diemCSharp, diemTiengAnh, gpaThang10;
                int tcToan, tcCSharp, tcTiengAnh;
                Console.WriteLine("Xin moi nhap diem so thang 10 cua mon Lap trinh C#:");
                diemCSharp = double.Parse(Console.ReadLine());
                Console.WriteLine("Xin moi nhap so tin chi cua mon Lap trinh C#:");
                tcCSharp = int.Parse(Console.ReadLine());
                Console.WriteLine("Xin moi nhap diem so thang 10 cua mon Toan:");
                diemToan = double.Parse(Console.ReadLine());
                Console.WriteLine("Xin moi nhap so tin chi cua mon Toan:");
                tcToan = int.Parse(Console.ReadLine());
                Console.WriteLine("Xin moi nhap diem so thang 10 cua mon Tieng Anh:");
                diemTiengAnh = double.Parse(Console.ReadLine());
                Console.WriteLine("Xin moi nhap so tin chi cua mon Tieng Anh:");
                tcTiengAnh = int.Parse(Console.ReadLine());
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
                } Console.WriteLine("Nhan Enter de ket thuc chuong trinh");
                Console.ReadLine();
//            Tình huống thực tế: Bộ phận Nhân sự(HR) cần một công cụ xử lý dữ liệu thô nhập vào từ biểu mẫu đăng
//ký.Họ tên nhập vào thường bị lỗi thừa khoảng trắng, hoa thường lộn xộn.Cần chuẩn hóa tên và tạo tài
//khoản công ty.
//Kiến thức trọng tâm: Kiểu string, các phương thức Trim(), Split(), Substring(), ToLower(), ToUpper(),
//string.Join().
//Yêu cầu bài toán:
//• Nhập vào một chuỗi họ tên thô từ bàn phím(Ví dụ: " ngUYỄN vĂn aN ").
//• Loại bỏ khoảng trắng thừa ở đầu, cuối và giữa các từ(chỉ giữ lại 1 khoảng trắng giữa các từ).
//• Chuyển đổi chuỗi thành dạng Viết Hoa Chữ Cái Đầu Mỗi Từ(Title Case): "Nguyễn Văn An".
//• Tách thành Họ, Tên Đệm và Tên chính.
//• Tạo Username không dấu theo quy tắc: ten.hovatenm. (Ví dụ: an.nguyenvan).
//• Tạo Email công ty: username + "@company.edu.vn".
//Ví dụ minh họa Input / Output:
//---INPUT-- -
//Nhập họ tên thô: tRẦN qUỐC tUẤN
//BÀI TẬP LẬP TRÌNH C# | CHỦ ĐỀ: KIỂU DỮ LIỆU (DATA TYPES)
//Trang 7 / 14
//-- - OUTPUT-- -
//Họ tên chuẩn hóa: Trần Quốc Tuấn
//Họ: Trần | Tên đệm: Quốc | Tên: Tuấn
//Username tạo tự động: tuan.tranquoc
//Email cấp phát: tuan.tranquoc @company.edu.vn
            Console.WriteLine("Bai 6: Xu ly du lieu ho ten nhap vao tu ban phim");
            Console.WriteLine("Xin moi nhap ho ten cua ban");
            string hotentho = Console.ReadLine();






        }
    }
}
