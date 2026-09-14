using System;
using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Runtime.ConstrainedExecution;
namespace CSLT
{
    class BTEx2
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Nhập thứ tự bài tập muốn chạy \nChọn 0 để chạy tất cả");
            string chon = Console.ReadLine();
            switch(chon)
            {
                case "0": Bai1(); Bai2(); Bai3(); Bai4(); Bai5(); Bai6(); break;
                case "1": Bai1(); break;
                case "2": Bai2(); break;
                case "3": Bai3(); break;
                case "4": Bai4(); break;
                case "5": Bai5(); break;
                case "6": Bai6(); break; 
            }

        }
    // Bai 1
    static void Bai1()
    {
            Console.WriteLine("Nhập chỉ số điện cũ");
            float chiSoCu = float.Parse(Console.ReadLine());
            float chiSoMoi;
            do
            {
                Console.WriteLine("Nhập chỉ số điện mới");
                chiSoMoi = float.Parse(Console.ReadLine());
                if (chiSoMoi < chiSoCu)
                {
                    Console.WriteLine("Chỉ số điện mới phải lớn hơn chỉ số điện cũ");
                }
                else
                {
                    break;
                }
                
            } while(true);

            float chiSoTieuThu = chiSoMoi - chiSoCu;
            decimal soKw = (decimal)chiSoTieuThu;
            decimal tienDien = 0m;
            if (soKw <= 50)
            {
                tienDien = soKw * 1806;
            }
            else if (soKw <= 100)
            {
                tienDien = 50 * 1806 + (soKw - 50) * 1866;
            }
            else if (soKw <= 200)
            {
                tienDien = 50 * 1806 + 50 * 1866 + (soKw - 100) * 2167;
            }
            else if (soKw <= 300)
            {
                tienDien = 50 * 1806 + 50 * 1866 + 100 * 2167 + (soKw - 200) * 2729;
            }
            else
            {
                tienDien = 50 * 1806 + 50 * 1866 + 100 * 2167 + 100 * 2729 + (soKw - 300) * 3050;
            }
            decimal VAT = tienDien * 0.08m;
            decimal tienTong = tienDien + VAT;
            Console.WriteLine($"Chỉ số điện tiêu thụ: {soKw} \nTiền điện chưa thuế: {tienDien:#,##0} VND \nTiền thuế: {VAT} \nTiền điện đã thuế: {tienTong:#,##0} VND");
            
    }

    // Bai 2
    static void Bai2()
    {
            double chieuCao;
            double canNang;
            double chiSoBMI;
            Console.WriteLine("Nhập chỉ số chiều cao tính bằng mét");
            chieuCao = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhập chỉ số cân nặng tính bằng kg");
            canNang = double.Parse(Console.ReadLine());
            chiSoBMI = canNang/Math.Pow(chieuCao, 2);
            string phanLoai;
            double canMin = 18.5 * Math.Pow(chieuCao, 2);
            double canMax = 22.9 * Math.Pow(chieuCao, 2);
            if (chiSoBMI < 18.5)
            {
                phanLoai = "Gầy (Thiếu Cân)";
            }
            else if (chiSoBMI < 23 )
            {
                phanLoai = "Bình thường (Lý tưởng)";
            }
            else if (chiSoBMI < 25)
            {
                phanLoai = "Thừa cân (Tiền béo phì)";
            }
            else
            {
                phanLoai = "Béo phì";
            }

            Console.WriteLine($"Chỉ số BMI của bạn: {chiSoBMI:F2} \nPhân loại sức khoẻ: {phanLoai} \nKhuyên dùng: Cân nặng lý tưởng của bạn là từ {canMin:F2} Kg đến {canMax:F2} Kg");
    }
    enum CurrencyType
        {
            USD = 1,
            EUR = 2,
            JPY = 3,
            GBP = 4}

    // Bai 3
    static void Bai3()
    {
            double soTien = 0;
            int key = 0;
            double phiDichVu = 0;
            double tienDoi = 0;
            Console.WriteLine("Nhập số tiền VNĐ: ");
            soTien = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Chọn ngoại tệ (1-USD, 2-EUR, 3-JPY, 4-GBP): ");
            key = Convert.ToInt16(Console.ReadLine());
            phiDichVu = soTien * 0.005;
            string loaiTien = "";
        switch ((CurrencyType)key)
            {
        case CurrencyType.USD:
                tienDoi = (soTien - phiDichVu)/25400;
                loaiTien = "USD";
                break;
        case CurrencyType.EUR:
                tienDoi = (soTien - phiDichVu)/27200;
                loaiTien = "EUR";
                break;
        case CurrencyType.JPY:
                tienDoi = (soTien - phiDichVu)/165;
                loaiTien = "JPY";
                break;
        case CurrencyType.GBP:
                tienDoi = (soTien - phiDichVu)/32100;
                loaiTien = "GBP";
                break;
            }
        Console.WriteLine($"Phí dịch vụ: {phiDichVu:#,##0} \nSố tiền VNĐ tính đổi: {(soTien - phiDichVu):#,##0} \nSố tiền {loaiTien} nhận được: {tienDoi:#,##0}");

    }

    // Bai 4
    static void Bai4()
    {
    Console.WriteLine("Nhập ngày sinh của bạn theo dịnh dạng dd/mm/yyyy ");
    string input = Convert.ToString(Console.ReadLine());
    // DateTime ngaySinh = DateTime.ParseExact( input, "dd/mm/yyyy", CultureInfo.InvariantCulture); 
    if (DateTime.TryParseExact(
        input,
        "dd/MM/yyyy",
        CultureInfo.InvariantCulture,
        DateTimeStyles.None, // ko can them rule gi nua
        out DateTime ngaySinh)) // tra ket qua
    {
        Console.WriteLine($"Ngày sinh: {ngaySinh:dd/MM/yyyy}");
        DateTime homNay = DateTime.Now.Date;
        int soTuoi = homNay.Year - ngaySinh.Year;
        DateTime sinhNhatNamNay = new DateTime(homNay.Year, ngaySinh.Month, ngaySinh.Day);
        if (ngaySinh.Date > homNay.AddYears(-soTuoi)) // trừ đi năm của số tuổi
        {
            soTuoi--; // Trừ 1 tuổi vì chưa đến sinh nhật
        }
        DateTime sinhNhatKeTiep;
        if (sinhNhatNamNay >= homNay) // Nếu ngày sinh chưa đến, thời gian sau lớn hơn thời gian trước
        {
            sinhNhatKeTiep = sinhNhatNamNay; // Nếu chưa qua sinh nhật thì lấy sinh nhật năm nay 
        }
        else
        {
            sinhNhatKeTiep = sinhNhatNamNay.AddYears(1); // Nếu qua sinh nhật rồi thì lấy sinh nhật năm sau
        }
        int soNgaySong = (homNay - ngaySinh.Date).Days;
        int ngayConLai = (sinhNhatKeTiep - homNay).Days;

        Console.WriteLine($"Số tuổi của bạn là: {soTuoi} tuổi \nTổng số ngày bạn đã sống là: {soNgaySong} ngày \nSố ngày còn lại đến sinh nhật là: {ngayConLai} ngày");
    }
    else
    {
        Console.WriteLine("Ngày không hợp lệ!");
    }
    }

    // Bai 5
    enum GradLetter
        {
            F,
            D,
            C,
            B,
            A,
        }

    static (GradLetter letter, double scale4, string xepLoai) QuyDoi(double diem)
    {
        if (diem >= 8.5) return (GradLetter.A, 4.0, "Xuất sắc / Giỏi");
        if (diem >= 7.0) return (GradLetter.B, 3.0, "Khá");
        if (diem >= 5.5) return (GradLetter.C, 2.0, "Trung bình");
        if (diem >= 4.0) return (GradLetter.A, 1.0, "Yếu");
        return (GradLetter.F, 0.0, "Kém / Trượt");
    }
    static void Bai5()
    {
           // Bai 5
        Console.WriteLine("Nhập số TC môn Lập trình C#");
        int TC1 = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Nhập điểm số môn Lập trình C# theo thang 10");
        double diemLapTrinh = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Nhập số TC môn Toán rời rạc");
        int TC2 = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Nhập điểm số môn Toán rời rạc theo thang 10");
        double diemToan = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Nhập số TC môn Tiếng Anh");
        int TC3 = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Nhập điểm số môn Tiếng Anh theo thang 10");
        double diemTiengAnh = Convert.ToDouble(Console.ReadLine());

        // Input 
        Console.WriteLine($"C# ({TC1} TC): {diemLapTrinh} \nToán rời rạc ({TC2} TC): {diemToan} \nTiếng Anh ({TC3} TC): {diemTiengAnh}");
        double ScoreAver = (diemLapTrinh*TC1+diemToan*TC2+diemTiengAnh*TC3)/(TC1+TC2+TC3);
        var (letter, scale4, xepLoai) = QuyDoi(ScoreAver);
        Console.WriteLine($"Điểm TB thang 10: {ScoreAver}");
        Console.WriteLine($"Điểm chữ quy đổi: {letter}");
        Console.WriteLine($"Điểm GPA thang 4: {scale4}");
        Console.WriteLine($"Xếp loại học lực: {xepLoai}");
    }
    // Bai 6
    static void Bai6()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Hãy nhập tên của bạn:");
            string TenTho = Convert.ToString(Console.ReadLine());
            string[] TachTenTho = TenTho.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            int n = 0;
            foreach(string x in TachTenTho)
            {
                TachTenTho[n] = x.Substring(0,1).ToUpper() + x.Substring(1).ToLower(); //Substring(startIndex, length) - lấy từ vị trí startIndex, lấy đúng length ký tự
                n++;
            }
            int ChieuDaiTen = TachTenTho.Length;
            string Ho = TachTenTho[0];
            string Ten = TachTenTho[ChieuDaiTen-1];
            string TenDem = "";
            for ( int i = 1; i <= ChieuDaiTen - 2; i++ )
            {
                if (i > 1) TenDem += " ";
                TenDem += TachTenTho[i];
            }
            // Normalize(NormalizationForm.FormD) — tách chữ ra khỏi dấu
            string TachTenRaKhoiDau = Ho + TenDem + Ten;
            string TenKoDau = "";
            TachTenRaKhoiDau = TachTenRaKhoiDau.Normalize(System.Text.NormalizationForm.FormD).Replace(" ","").ToLower().Trim();
            Console.WriteLine(TachTenRaKhoiDau);
            // NonSpacingMark là kiểu dấu, ko phải ký tự chữ
            foreach (char c in TachTenRaKhoiDau)
            {
                var KieuTxt = System.Globalization.CharUnicodeInfo.GetUnicodeCategory(c); // Lấy kiểu của kí tự
                if ( KieuTxt != System.Globalization.UnicodeCategory.NonSpacingMark)
                {
                    TenKoDau += c;
                }
            }
            Console.WriteLine(TenKoDau);
            TenKoDau = TenKoDau.Replace("đ", "d").Replace("Đ","D"); // Ko thể lọc đc đ và Đ vì với Unicode, gạch ngang giữa chữ "đ" không được coi là một "dấu" riêng biệt như dấu mũ/dấu sắc — nó là một phần cố định của chính chữ cái đó,
            string emailTen = TenKoDau.Substring(TenKoDau.Length-Ten.Trim().Length);
            Console.WriteLine(emailTen);
            string emailDem = TenKoDau.Substring(0,TenKoDau.Length-Ten.Trim().Length);
            Console.WriteLine(emailDem);
            string username = $"{emailTen}.{emailDem}";
            string emailUser = username + "@company.edu.vn";
            Console.WriteLine($"Họ tên chuẩn hoá: {Ho} {TenDem} {Ten} \nHọ: {Ho} | Tên đệm: {TenDem} | Tên: {Ten} \nUsername tạo tự động: {username} \nEmail cấp phát: {emailUser}");   

        }
    }
}