using System;
using System.ComponentModel;
using Microsoft.VisualBasic;
namespace CSLT
{
    class Buoi_5
    {
        static void Main(string[] argr)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine(TimSoMax(1,50,25,5,64));
            Console.WriteLine(GiaiThua(3));
            Console.WriteLine(SoNguyenTo(7));
            Console.WriteLine("Dãy số nguyên tố: ");
            InSoNguyenTo(100);
            Console.WriteLine("\n" + SoHoanHao(6));
            Console.WriteLine(Pangram("The quick brown fox jumps over the lazy dog"));
            Console.WriteLine(Pangram("My name is Minh Dan"));
        }

        // Bai 1
        public static int TimSoMax(params int[] TimMax)
        {
            int SoMax = TimMax[0];
            foreach (int i in TimMax)
            {
                if (i > SoMax) { SoMax = i;}
            }
            return SoMax;
        }

        // Bai 2
        public static int GiaiThua(int n)
        {
            int kq = 1;
            for(int i = 1; i <= n; i++)
            {
                kq = kq*i;
            }
            return kq;
        }

        // Bai 3
        public static bool SoNguyenTo(int n)
        {
            if ( n < 2) return false;
            for (int j = 2; j <= Math.Sqrt(n); j++)
            {
                if ( n%j == 0 ) return false;
            }
            return true;
        }

        // Bai 4
        public static void InSoNguyenTo(int n)
        {
            for ( int i = 1; i <= n-1; i++)
            {
                if(SoNguyenTo(i)) Console.Write(i + " ");
            }
        }

        // Bai 5
        public static bool SoHoanHao(int n)
        {
            List<int> Uoc = new List<int>();
            for ( int i = 1; i < n; i++)
            {
                if ( n%i == 0 ) { Uoc.Add(i); }
            }
            int TongCacUoc = 0;
            foreach(int x in Uoc)
            {
                TongCacUoc += x;
            }
            if ( TongCacUoc == n ) return true;
            return false;
        }

        // Bai 6
        public static bool Pangram(string n)
        {
            string s = n.ToLower();
            for (char c = 'a'; c <= 'z'; c++)
            {
                if (!s.Contains(c)) return false;
            }
            return true;
        }
    }
}

