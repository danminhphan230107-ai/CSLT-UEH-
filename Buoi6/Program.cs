using System;
using System.Security.Cryptography.X509Certificates;
namespace CSLT
{
    class Buoi_6
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            SingleArraySimple();
            SingleArrayAlgorithms();
            MultiDimensionalArray(3,4);
        }
        
        public static void SingleArraySimple()
        {
            Random rd = new Random();
            int[] arr = new int[10];
            for ( int i = 0; i < 10; i++)
            {
                arr[i] = rd.Next(1,101);
            }
            Console.WriteLine("Dãy ban đầu là");
            foreach (int x in arr) {Console.Write(x + " ");}
            Console.WriteLine("\nTrung bình của Array = " + TinhTrungBinh(arr));
            Console.WriteLine("Số cần kiểm tra có trong mảng: " + soCanCheck(arr, 50));
            Console.WriteLine("Index của số cần tìm là " + TimIndex(arr, 56));
            XoaViTri(arr, arr[rd.Next(1,11)]);
            Console.WriteLine("\nSố bé nhất là " + TimSoBe(arr));
            Console.WriteLine("Số lớn nhât là " + TimSoLon(arr));
            ReverseArray(arr);
            Console.WriteLine("\n" + Duplicated(arr));
            RemoveDuplicate(arr);
        }

        public static double TinhTrungBinh(int[] arr)
        {
            int tong = 0;
            foreach( int x in arr )
            {
                tong += x;
            }
            return (double)tong/arr.Length;
        }

        public static bool soCanCheck(int[] arr, int soCanCheck)
        {
            foreach ( int SoCheck in arr )
            {
                if ( SoCheck == soCanCheck ) return true;
            }
            return false;
        }

        public static int TimIndex(int[] arr, int SoCanTim)
        {
            for( int i = 0; i < arr.Length; i++ )
            {
                if ( arr[i] == SoCanTim) return i;
            }
            return -1; 
        }

        public static void XoaViTri(int[] arr, int SoCanXoa)
        {
            int[] kq = new int[arr.Length-1];
            int demSo = 0;
            for( int i = 0; i < arr.Length; i++ )
            {
                if ( SoCanXoa != arr[i] ) {kq[demSo] = arr[i]; demSo++;}
            }
            foreach( int x in kq ) { Console.Write(x + " "); }
        }

        public static int TimSoLon(int[] arr)
        {
            int soMax = arr[0];
            for ( int i = 0; i < arr.Length; i++ )
            {
                if (soMax < arr[i]) soMax = arr[i];
            } 
            return soMax;
        }

        public static int TimSoBe(int[] arr)
        {
            int soMin = arr[0];
            for ( int i = 0; i < arr.Length; i++ )
            {
                if (soMin > arr[i]) soMin = arr[i];
            } 
            return soMin;
        }

        public static void ReverseArray(int[] arr)
        {
            int[] kq = new int[arr.Length];
            int demSo = 0;
            for( int i = arr.Length-1; i >= 0; i-- )
            {
                kq[demSo] = arr[i]; demSo++;
            }
            foreach ( int x in kq ) Console.Write(x + " ");
        }

        public static string Duplicated(int[] arr)
        {
            for ( int i = 0; i < arr.Length; i++ )
            {
                for ( int j = i+1; j < arr.Length; j++ )
                {
                    if ( arr[i] == arr[j] ) return "Trùng " + arr[i];
                }
            }
            return "Không trùng";
        }

        public static void RemoveDuplicate(int[] arr)
        {
            bool soBiTrung = false;
            int indexSoBiTrung = -1;
            for ( int i = 0; i < arr.Length; i++ )
            {
                for ( int j = i+1; j < arr.Length; j++ )
                {
                    if ( arr[i] == arr[j] )
                    {
                        soBiTrung = true;
                        indexSoBiTrung = j;
                        break;
                    }
                }
            }
            if(soBiTrung)
            {
                int[] DayMoiKhongTrung = new int[arr.Length-1];
                for (int i = 0; i < indexSoBiTrung; i++)
                {
                    DayMoiKhongTrung[i] = arr[i];
                }
                for (int i = indexSoBiTrung; i < arr.Length-1; i++)
                {
                    DayMoiKhongTrung[i] = arr[indexSoBiTrung+1]; indexSoBiTrung++;
                }
                Console.WriteLine("Dãy mới không còn trùng nữa ");
                foreach(int x in DayMoiKhongTrung) Console.Write(x + " ");
            }
            else {Console.WriteLine("Dãy không bị trùng");}
        }

        public static void SingleArrayAlgorithms()
        {
            Random rd = new Random();
            int[] arr = new int[10];
            for ( int i = 0; i < 10; i++)
            {
                arr[i] = rd.Next(1,101);
            }
            Console.WriteLine("Dãy ban đầu là");
            foreach (int x in arr) {Console.Write(x + " ");}
            BubbleSort(arr);
            Console.WriteLine("\n"+TimKiem("Ông già sẽ cho xe SH", "già"));

        }

        public static void BubbleSort(int[] arr)
        {
            for ( int i = 0; i < arr.Length; i++ )
            {
                for ( int j = i + 1; j < arr.Length; j ++ )
                {
                    if(arr[i]>arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            Console.WriteLine("\nDãy đã xếp là");
            foreach (int x in arr) Console.Write(x + " ");            
        }

        public static bool TimKiem(string Nhap, string CanTim)
        {
            string[] DaTach = Nhap.Split(' ');
            foreach ( string c in DaTach )
            { if (c.Contains(CanTim)) return true; }
            return false;
        }

        public static void MultiDimensionalArray(int n, int m)
        {
            Random rd = new Random();
            int [,] MaTran2Chieu = new int[n,m];
            for ( int i = 0; i < n; i++ )
            {
                for ( int j = 0; j < m; j++ )
                {
                    MaTran2Chieu[i,j] = rd.Next(1,101);
                }
            }
            InMaTran(MaTran2Chieu);
            InTheoCot(MaTran2Chieu);
            InTheoHang(MaTran2Chieu);
            Console.WriteLine(TimMax(MaTran2Chieu));
            Console.WriteLine(MinTheoCot(MaTran2Chieu));
            Console.WriteLine(MinTheoHang(MaTran2Chieu));
            DaoMaTran(MaTran2Chieu);
        }

        public static void InMaTran(int[,] arrs)
        {
            for ( int i = 0; i < arrs.GetLength(0); i++ )
            {
                for ( int j = 0; j < arrs.GetLength(1); j++ )
                {
                    Console.Write(arrs[i,j] + " ");
                }
                Console.WriteLine("");
            }
        }

        public static void InTheoCot(int[,] arrs)
        {
            Console.WriteLine($"Hãy nhập thứ tự cột của ma trận");
            int n = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine($"Cột thứ {n} của ma trận là ");
            for ( int i = 0; i < arrs.GetLength(0); i++ )
            {
                Console.WriteLine(arrs[i,n-1]);
            }
        }

        public static void InTheoHang(int[,] arrs)
        {
            Console.WriteLine($"Hãy nhập thứ tự hàng của ma trận");
            int n = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine($"Hàng thứ {n} của ma trận là ");
            for ( int i = 0; i < arrs.GetLength(1); i++ )
            {
                Console.Write(arrs[n-1,i] + " ");
            }
        }

        public static int TimMax(int[,] arrs)
        {
            int SoMax = arrs[0,0];
            foreach (int x in arrs)
            {
                if (SoMax < x) SoMax = x;
            }
            return SoMax;
        }

        public static int MinTheoCot(int[,] arrs)
        {
            Console.WriteLine($"Hãy nhập thứ tự cột của ma trận");
            int n = Convert.ToInt16(Console.ReadLine());
            int soMin = arrs[n-1,0];
            Console.WriteLine($"Số nhỏ nhất của cột thứ {n} là ");
            for ( int i = 0; i < arrs.GetLength(0); i++ )
            {
                if (soMin > arrs[i,n-1]) soMin = arrs[i,n-1];
            }
            return soMin;
        }

        public static int MinTheoHang(int[,] arrs)
        {
            Console.WriteLine($"Hãy nhập thứ tự hàng của ma trận");
            int n = Convert.ToInt16(Console.ReadLine());
            int soMin = arrs[0,n-1];
            Console.WriteLine($"Số nhỏ nhất của hàng thứ {n} là ");
            for ( int i = 0; i < arrs.GetLength(0); i++ )
            {
                if (soMin > arrs[n-1,i]) soMin = arrs[n-1,i];
            }
            return soMin;
        }

        public static void DaoMaTran(int[,] arrs)
        {
            int n = arrs.GetLength(0); /// Lấy hàng
            int m = arrs.GetLength(1); /// Lấy cột
            int[,] kq = new int[m,n];
            for ( int i = 0; i < n; i++ )
            {
                for ( int j = 0; j < m; j++ )
                {
                    kq[j,i] = arrs[i,j];
                }
            }

            for ( int i = 0; i < kq.GetLength(0); i++ )
            {
                for ( int j = 0; j < kq.GetLength(1); j++ )
                {
                    Console.Write(kq[i,j] + " ");
                }
                Console.WriteLine("");
            }
        }

    }
}
