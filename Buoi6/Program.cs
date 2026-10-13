using System;
using System.Security.Cryptography.X509Certificates;
namespace CSLT
{
    class Buoi_6
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
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

    }
}
