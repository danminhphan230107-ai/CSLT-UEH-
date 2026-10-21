using System;
using System.IO;
using System.IO.Pipes;
using System.Linq.Expressions;
namespace CSLT
{
    class BT_Ex8
    {
        static void Main(string[] args)
        {
            string DuongDan = @"/Users/dannie/Documents/KỲ 3/CS LẬP TRÌNH/CSLT-UEH-/BT_Ex9/Random.txt";
            BangKyTu(DuongDan);
            ViTriKyTu(DuongDan, BangKyTu(DuongDan));
        }

        static int[,] BangKyTu(string DuongDan)
        {
            int[,] Dem = new int[2,26]; //1 Hàng chữ, 1 Hàng số, Từ a -> z 26 cột 
            if(!File.Exists(DuongDan)) 
            {
                Console.WriteLine("File không tồn tại"); 
                return Dem;
            }

            string NoiDung = File.ReadAllText(DuongDan);
            foreach (char c in NoiDung)
            {
                char x = char.ToLower(c);
                if (x >= 'a' && x <= 'z') Dem[0, x - 'a']++; // x - 'a', vd 'c' - 'a' = 2 => index của c là 2
                else if (x >= '0' && x <= '9') Dem[1, x - '0']++;
            }

            Console.WriteLine("Chữ cái");
            for (int i = 0; i < 26; i++)
            {
                Console.WriteLine((char)('a' + i) + ": " + Dem[0,i]); // (char)('a' + i) từ mã ký tự trích ngược thành chữ lại
            }

            Console.WriteLine("Chữ số");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine((char)('0' + i)+": "+ Dem[1,i]);
            }
            return Dem;
        }

        static int IndexKyTu(char x)
        {
            x = char.ToLower(x);
            if ( x >= 'a' && x <= 'z' ) return x - 'a';
            else if ( x >= '0' && x <= '9' ) return x - '0' + 26;
            return -1; // Nếu ko phải chữ và số
        }

        static void ViTriKyTu(string DuongDan, int[,] Dem)
        {
            int[][] ViTri = new int[36][]; // Gộp số và chữ
            for (int i = 0; i < 36; i++)
            {
                int SoLan;
                if (i < 26) SoLan = Dem[0,i];
                else SoLan = Dem[1,i - 26];
                ViTri[i] = new int[SoLan*2]; // Nhân 2 để lưu 2 thông tin dòng và cột
            }

            int[] GhiNhoViTriDaGhi = new int[36];
            
            string[] CacDong = File.ReadAllLines(DuongDan);
            for ( int d = 0; d < CacDong.Length; d++ )
            {
                for ( int c = 0; c < CacDong[d].Length; c++ )
                {
                    int k = IndexKyTu(CacDong[d][c]);
                    if (k == -1) continue; // Bỏ qua nếu không phải số hay chữ

                    // [k]: Tìm đúng hàng của kí tự đó
                    // d + 1: Vị trí dòng của kí tự đó 
                    // c + 1: Vị trí cột của kí tự đó 
                    // Ví trí 1 là ghi dòng nên sau khi ghi dòng phải cộng dô để sang vị trí 2 ghi cột
                    // Mỗi kí tự có mỗi Ghi nhớ vị trí riêng vì đây là mảng

                    ViTri[k][GhiNhoViTriDaGhi[k]] = d + 1; GhiNhoViTriDaGhi[k]++;
                    ViTri[k][GhiNhoViTriDaGhi[k]] = c + 1; GhiNhoViTriDaGhi[k]++;
                }
            }

            Console.WriteLine("Vị trí dòng và cột");
            for ( int i = 0; i< 36; i ++ )
            {
                if (ViTri[i].Length == 0) continue;
                else
                {
                    char KyTuDangIn;
                    if (i < 26) KyTuDangIn = (char)('a' + i);
                    else KyTuDangIn = (char)('0' + i - 26);
                    string InRa = KyTuDangIn + ": ";
                    for ( int j = 0; j < ViTri[i].Length; j += 2)
                    {
                        InRa += $"({ViTri[i][j]}, {ViTri[i][j+1]}) ";
                    }
                    Console.WriteLine(InRa);
                }
            }
        }

    }
}
