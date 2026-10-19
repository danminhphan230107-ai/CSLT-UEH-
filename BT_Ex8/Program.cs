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
            CreateFileArray(DuongDan, new string[]{"An", "Bình", "Phú", "Lâm"});
            GhiDe(DuongDan, "Nội dung cần phải được Append");
            CopyFile(DuongDan, "Bai_2");
            

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


    }
}