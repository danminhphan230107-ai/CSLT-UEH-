using System;
using System.IO;
using System.IO.Pipes;
namespace CSLT
{
    class BT_Ex8
    {
        static void Main(string[] args)
        {
            string DuongDan = TaoFileRong(@"/Users/dannie/Documents/KỲ 3/CS LẬP TRÌNH/CSLT-UEH-/BT_Ex8/BaiLam", @"Bai_Tap");
            CreateAndMove(DuongDan, "SauKhiMove.txt");
            DuongDan = TaoFileRong(@"/Users/dannie/Documents/KỲ 3/CS LẬP TRÌNH/CSLT-UEH-/BT_Ex8", @"Bai_Tap_1");
            XoaFile(DuongDan);
            string FileCoDong = CreateAndAdd(@"/Users/dannie/Documents/KỲ 3/CS LẬP TRÌNH/CSLT-UEH-/BT_Ex8", @"Bai_Tap_1");
            DocFile(DuongDan);
            ReadTheFirstLine(FileCoDong);
            ReadTheLastLine(@"/Users/dannie/Documents/KỲ 3/CS LẬP TRÌNH/CSLT-UEH-/BT_Ex8/BaiLam", "Bai_Tap_TumLum");
            ReadNLastLine(DuongDan, 2);
            ReadSpecificLine(DuongDan, 2);
            CountLines(DuongDan);
            CreateFileArray(DuongDan, new string[]{"An", "Bình", "Phú", "Lâm"});
            GhiDe(DuongDan, "Nội dung cần phải được Append");
            CopyFile(DuongDan, "Bai_2");
            GetStructure(@"/Users/dannie/Documents/KỲ 3/CS LẬP TRÌNH/CSLT-UEH-/BT_Ex8");
            
        }

        static string TaoFileRong(string TenFolder, string TenFile)
        {
            string DuongDan = Path.Combine(TenFolder, TenFile);
            Directory.CreateDirectory(TenFolder);
            File.Create(DuongDan).Close();

            if(File.Exists(DuongDan)) Console.WriteLine("Tạo file thành công: " + DuongDan);
            else Console.WriteLine("Tạo file thất bại");

            return DuongDan;
        }

        static void XoaFile(string TenFile)
        {
            if(File.Exists(TenFile))
            {
                File.Delete(TenFile);
                Console.WriteLine("Đã xoá thành công");
            }
            else Console.WriteLine("File không tồn tại");
        }

        static string CreateAndAdd(string TenFolder, string TenFile)
        {
            string DuongDan = TaoFileRong(TenFolder, TenFile);
            File.AppendAllText(DuongDan, "Nội dung thêm vào 1" + Environment.NewLine + "Nội dung thêm vào 2" + Environment.NewLine + "Nội dung thêm vào 3");
            return DuongDan;
        }

        static string DocFile(string TenFile)
        {
            string NoiDung = File.ReadAllText(TenFile);

            Console.WriteLine("Nội dung của file: ");
            Console.WriteLine(NoiDung);
            return NoiDung;
        }

        static string CreateFileArray(string TenFile, string[] DanhSanh)
        {
            File.WriteAllLines(TenFile, DanhSanh);
            DocFile(TenFile);
            return TenFile;
        }

        static string GhiDe(string TenFile, string NoiDung)
        {
            File.AppendAllText(TenFile, NoiDung);
            DocFile(TenFile);
            return TenFile;
        }

        static string CopyFile(string TenFile, string TenFileMoi)
        {
            string TenFolder = Path.GetDirectoryName(TenFile);
            string DuongDanMoi = Path.Combine(TenFolder, TenFileMoi);
            File.Copy(TenFile, DuongDanMoi, true);
            Console.WriteLine("Đã copy " + TenFile + " thành " + DuongDanMoi);
            DocFile(DuongDanMoi);
            return DuongDanMoi;
        }

        static string CreateAndMove(string TenFileCu, string TenFileMoi)
        {
            string DuongDanMoi = Path.Combine(Path.GetDirectoryName(TenFileCu), TenFileMoi);
            if(File.Exists(DuongDanMoi)) File.Delete(DuongDanMoi);
            File.Move(TenFileCu, DuongDanMoi);
            return DuongDanMoi;
        }

        static string ReadTheFirstLine(string TenFile)
        {
            using (StreamReader rd = new StreamReader(TenFile))
            {
                string DongDau = rd.ReadLine();
                Console.WriteLine("Dòng đầu tiên là: "+DongDau);
                return DongDau;
            }
        }

        static string ReadTheLastLine(string TenFolder, string TenFile)
        {
            string DuongDan = CreateAndAdd(TenFolder, TenFile);
            string[] CacDong = File.ReadAllLines(DuongDan);
            string DongCuoi = CacDong[CacDong.Length-1];
            Console.WriteLine("Dòng cuối là: " + DongCuoi);
            return DongCuoi;
        }

        static void ReadNLastLine(string TenFileDuongDan, int n)
        {
            string[] CacDong = File.ReadAllLines(TenFileDuongDan);
            Console.WriteLine("n dòng cuối là: ");
            for (int i = CacDong.Length - n; i < CacDong.Length; i++)
                Console.WriteLine(CacDong[i]);
        }

        static void ReadSpecificLine(string TenFileDuongDan, int n)
        {
            string[] CacDong = File.ReadAllLines(TenFileDuongDan);
            Console.WriteLine($"Dòng thứ {n} là: " + CacDong[n-1]);
        }

        static int CountLines(string TenFileDuongDan)
        {
            string[] CacDong = File.ReadAllLines(TenFileDuongDan);
            int SoDong = CacDong.Length;
            Console.WriteLine($"Số dòng trong file là: " + SoDong);
            return SoDong;
        }

        static void GetStructure(string TenFolder)
        {
            if(!Directory.Exists(TenFolder))
            {
                Console.WriteLine("Thư mục không tồn tại");
                return;
            }
            Console.WriteLine("Thư mục " + Path.GetFileName(TenFolder));
            DetailStructure(TenFolder, " ");
        }

        static void DetailStructure(string TenFolder, string KhoangCachThuLe)
        {
            foreach (string ThuMucCon in Directory.GetDirectories(TenFolder))
            {
                Console.WriteLine(KhoangCachThuLe + Path.GetFileName(ThuMucCon));
                DetailStructure(ThuMucCon, KhoangCachThuLe + "   "); //Đệ quy, gọi lại chính nó 
            }

            //Chạy hết thư mục rồi thì bỏ qua và chạy foreach ở dưới để lấy tên file

            foreach (string TenFile in Directory.GetFiles(TenFolder)) //Bây giờ Tenfolder đã đc gán là ThuMucCon
            {
                Console.WriteLine(KhoangCachThuLe + Path.GetFileName(TenFile));
            }
        }
    }
}