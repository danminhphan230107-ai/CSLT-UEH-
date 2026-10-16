using System;
using System.Security.Cryptography.X509Certificates;
namespace CSLT
{
    class Buoi_6
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int[][] Jagged = JaggedArray();
            for ( int i = 0; i < Jagged.Length; i++ )
            {
                for ( int j = 0; j < Jagged[i].Length; j++ ) Console.Write(Jagged[i][j] + " ");
                Console.WriteLine();
            }

            Console.WriteLine("Random Jagged Array");

            int[][] RandomJagged = RandomJaggedArray();
            for ( int i = 0; i < RandomJagged.Length; i++ )
            {
                for ( int j = 0; j < RandomJagged[i].Length; j++ ) Console.Write(RandomJagged[i][j] + " ");
                Console.WriteLine();
            }
            Console.WriteLine("Số lớn nhất của array là " + TimSoLonNhat(RandomJagged));

            int[][] SortArray = SortJaggedArray(RandomJagged);
            for ( int i = 0; i < SortArray.Length; i++ )
            {
                for ( int j = 0; j < SortArray[i].Length; j++ ) Console.Write(SortArray[i][j] + " ");
                Console.WriteLine();
            }

            Console.WriteLine("Các số nguyên tố của Array ");
            HashSet<int> PrimeNums = TimSoNguyenTo(RandomJagged);
            foreach(int c in PrimeNums) Console.Write(c + " ");
        }

        public static int[][] JaggedArray()
        {
            int[][] numbers =
            {
                new int[] {1,1,1,1,1},
                new int[] {2,2},
                new int[] {3,3,3,3},
                new int[] {4,4}
            };
            return numbers;
        }

        public static int[][] RandomJaggedArray()
        {
            Random rd = new Random();
            int Hang = rd.Next(3,5);
            int[][] numbers = new int[Hang][];
            for ( int i = 0; i < Hang; i++ )
            {
                int Cot = rd.Next(1,5);
                numbers[i] = new int[Cot];
                for ( int j = 0; j < Cot; j++ )
                {
                    numbers[i][j] = rd.Next(1,9);
                }
            }
            return numbers;
        }

        public static int TimSoLonNhat(int[][] arrs)
        {
            int MaxAll = arrs[0][0];
            for ( int i = 0; i < arrs.Length; i++ )
            {
                int MaxRow = arrs[i][0];
                for ( int j = 0; j < arrs[i].Length; j++ )
                {
                    if (arrs[i][j] > MaxRow ) MaxRow = arrs[i][j];
                }
                if (MaxRow > MaxAll) MaxAll = MaxRow;
            }
            return MaxAll;
        }

        public static int[][] SortJaggedArray(int[][] arrs)
        {
            for(int i = 0; i < arrs.Length; i++)
            {
                Array.Sort(arrs[i]);
            }
            return arrs;
        }

        public static HashSet<int> TimSoNguyenTo(int[][] arrs)
        {
            HashSet<int> SoNguyenTo = new HashSet<int>();
            for( int i = 0; i < arrs.Length; i++ )
            {
                for ( int j = 0; j < arrs[i].Length; j++ )
                {
                    if (HamSoNguyenTo(arrs[i][j])) SoNguyenTo.Add(arrs[i][j]);
                }
            }
            return SoNguyenTo;
        }

        public static bool HamSoNguyenTo(int n)
        {
            if ( n < 2) return false;
            for (int j = 2; j <= Math.Sqrt(n); j++)
            {
                if ( n%j == 0 ) return false;
            }
            return true;
        }
    }
}
