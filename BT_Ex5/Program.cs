using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;
using System.Text;
namespace CSLT
{
    class BT_Ex5
    {
        static int Tinh_Tong(int a, int b)
        {
            return a + b;
        } 

        static bool Kiem_tra_chan_le(int n)
        {
            if (n%2 == 0)
            {
                return true;
            }
            return false;
        }

        static int Tim_Max(int a, int b, int c)
        {
            int So_Max = 0;
            if (So_Max < a)
            {
                So_Max = a;
            }
            else if (So_Max < b)
            {
                So_Max = b;
            }
            else if (So_Max < c)
            {
                So_Max = c;
            }
            return So_Max;
        }

        static long Giai_Thua(int n)
        {
            long Giai_Thua = 1;
            for(int i = 1; i <= n; i++)
            {
                Giai_Thua *=i;
            }
            return Giai_Thua;
        }

        static string DaoNguocChuoi(string chuoi)
        {
            char[] DayChuoi = chuoi.ToCharArray();
            Array.Reverse(DayChuoi);
            return new string(DayChuoi);
        }

        static bool KiemTraNguyenTo(int n)
        {
            bool kiemTra = true;
            for(int i = 1; i < Math.Sqrt(n); i++)
            {
                if (n%i == 0)
                {
                    kiemTra = false;
                    break;
                }
            }
            return kiemTra;
        }

        static void Fibo(int n)
        {
            // int[] Foboni = new int[n];
            // for(int i = 0; i < n; i++)
            // {
            //     if(i<2) {Foboni[i] = 1;}
            //     else
            //     {
            //     Foboni[i] = Foboni[i-1] + Foboni[i-2];
            //     }

            // }
            // foreach(int x in Foboni)
            // {
            //     Console.Write($"{x} ");
            // }
            int a = 0;
            int b = 1;
            for(int i = 0; i <= n; i++)
            {
                Console.Write(a + " ");
                int Sum = a + b;
                b = a;
                a = Sum;
            }
        }

        static int DemSoNguyenAm(string s)
        {
            int Dem = 0;
            string NguyenAm = "aàáảãạăằắẳẵặâầấẩẫậeèéẻẽẹêềếểễệiìíỉĩịoòóỏõọôồốổỗộơờớởỡợuùúủũụưừứửữự" +
                          "AÀÁẢÃẠĂẰẮẲẴẶÂẦẤẨẪẬEÈÉẺẼẸÊỀẾỂỄỆIÌÍỈĨỊOÒÓỎÕỌÔỒỐỔỖỘƠỜỚỞỠỢUÙÚỦŨỤƯỪỨỬỮỰ";
            foreach (char c in s)
            if(NguyenAm.Contains(c))
                {
                    Dem+=1;
                }
            return Dem;
        }
        static double Tinh_Luy_Thua(int x, int y)
        {
            double Math_Pow = 1d;
            for (int i = 0; i < y; i++)
            {
                Math_Pow*=x;
            }
            return Math_Pow;
        }

        static double TinhTrungBinh(int[] avr)
        {
            int sumAver = 0;
            foreach(int x in avr)
            {
                sumAver+=x;
            }
            double Aver = sumAver/avr.Length;
            return Aver;
        }
        static bool DoiXung(string s)
        {
            bool KiemTra = false;
            s = s.ToLower();
            char[] BanDau = s.ToCharArray();
            char[] NguocLai = (char[])BanDau.Clone();
            Array.Reverse(NguocLai);
            if (BanDau.SequenceEqual(NguocLai))
            {
                KiemTra = true;
            }
         return KiemTra;
        }

        static double CelToFar(int c)
        {
            double Far = c*1.8 + 32;
            return Far;
        }
        static int Tim_Min(int[] arr)
        {
            int soMin = arr[0];
            foreach(int x in arr)
            {
                if (soMin > x)
                {
                    soMin = x;
                }
            }
            return soMin;
        }
        static int TinhTongChuSo(int n)
        {
            int tong = 0;
            while (n%10!=0)
            {
                tong += n%10;
                n /=10;
            }
            return tong;
        }
        static void SapXepMang(int[] a)
        {
            for(int i = 0; i < a.Length - 1; i++)
            {
                for(int j = 0; j < a.Length - i - 1; j++)
                {
                    if(a[j]>a[j+1])
                    {
                        int tam = a[j];
                        a[j] = a[j+1];
                        a[j+1] = tam;
                    }
                }
            }
            Console.WriteLine(string.Join(" ",a));
        }
        static string XoaTrungLap(string a)
        {
            string kq = "";
            foreach( char c in a)
            {
                if(!kq.Contains(c))
                {
                    kq += c;
                }
            }
            return kq;
        }

        static string XoaTrungLap_2(string a)
        {
            HashSet<char> Dagap = new HashSet<char>();
            StringBuilder kq = new StringBuilder(); //StringBuilder co the duoc sua truc tiep
            foreach(char c in a)
            {
                if(Dagap.Add(c)) // Tra ve true neu la ky tu moi
                {
                    kq.Append(c);
                }
            }
            return kq.ToString();
        }

        static int UocChungLN(int a, int b)
        {
            while(b!=0)
            {
                int soDu = a%b;
                a = b;
                b = soDu;
            }
            return a;
        }

        static string DecToBin(int n)
        {
            string ChuaDao = "";
            while(n > 0)
            {
                int x = n%2;
                ChuaDao += x.ToString();
                n/=2;
            }
            char[] Dao = ChuaDao.ToArray();
            Array.Reverse(Dao);
            return new string(Dao);
        }

        static bool CheckNamNhuan(int n)
        {
            bool KiemTra = false;
            if(n%4==0 && n%100!=0 || n%400==0)
            {
                return KiemTra = true;
            }
            return KiemTra;
        }

        static int DemTu(string s)
        {
            int dem = 0;
            bool dangTrongTu = false;
            foreach(char c in s)
            {
                if(!char.IsWhiteSpace(c))
                {
                    if(!dangTrongTu)
                    {
                        dem++;
                        dangTrongTu = true;
                    }
                }
                else {dangTrongTu = false;}
            }
            return dem;
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Fibo(9);
            Console.WriteLine("\n"+DemSoNguyenAm("Phan Minh Ddan"));
            Console.WriteLine(Tinh_Luy_Thua(3,3));
            Console.WriteLine(TinhTrungBinh([1,2,3,4,5,65,20]));
            Console.WriteLine(DoiXung("QuocAnh"));
            Console.WriteLine(CelToFar(100));
            Console.WriteLine(Tim_Min([23,10,4,5,7,9,55,34,2]));
            Console.WriteLine(TinhTongChuSo(1234));
            SapXepMang([1,4,3,2]);
            Console.WriteLine(XoaTrungLap("programming"));
            Console.WriteLine(XoaTrungLap_2("programming"));
            Console.WriteLine(UocChungLN(18,42));
            Console.WriteLine(DecToBin(10));
            Console.WriteLine(CheckNamNhuan(2023));
            Console.WriteLine(DemTu("Xin Chao Toi Ten La Minh Dan Ne"));
        }

    }
}