using System;
using System.ComponentModel;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography.X509Certificates;
namespace CSLT
{
    class Buoi4
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding=System.Text.Encoding.UTF8;
            Bai1(3,4,4);
            Bai2(1,2,3,4,5,6,10,11,12,13,14,15);
            Bai3(9);
            Bai4(5);
            Bai6(5);
            Bai7(6);
            Bai8(7);

        }
        static void Bai1(double a, double b, double c)
        {
            if(a + b > c && a + c > b && b + c > a)
            {
                if(a==b && b==c )
                {
                    Console.WriteLine($"Từ 3 cạnh a = {a}, b = {b}, c = {c}, tạo thành 1 tam giác đều");                    
                }
                else if (a==b || b==c || a==c)
                {
                    Console.WriteLine($"Từ 3 cạnh a = {a}, b = {b}, c = {c}, tạo thành 1 tam giác cân");  
                }
                else
                {
                    Console.WriteLine($"Từ 3 cạnh a = {a}, b = {b}, c = {c}, tạo thành 1 tam giác");
                }
            }
            else
            {
                Console.WriteLine($"Từ 3 cạnh a = {a}, b = {b}, c = {c}, không tạo thành tam giác"); 
            }
        }

        static void Bai2(params int[] nums)
        {
            int sum10So = 0;
            int soCanCong = 0;
            double aver = 0d;
            foreach(int x in nums)
            {
                soCanCong = x;
                sum10So = sum10So + soCanCong;
            }
            aver = (double)sum10So/10;
            Console.WriteLine($"Tổng 10 số nhập vào: {sum10So} \nTrung bình cộng 10 số nhập vào: {aver}");
        }

        static void Bai3(int soCanTra)
        {
            Console.WriteLine($"Bảng cửu chương {soCanTra}:");
            for ( int i = 1; i < 10; i++)
            {
                Console.WriteLine($"{soCanTra} * {i} = {soCanTra*i}");
            }
        }

        static void Bai4(int n)
        {
            Console.WriteLine($"Số lần lập của tam giác: {n}");
            List<int> soDienVao = new List<int>();
            Console.WriteLine("Kiểu pattern 1");
            for (int i = 1; i <= n; i++)
            {
                soDienVao.Add(i);
                for (int a=0; a <=i-1; a++)
                {
                Console.Write(soDienVao[a]);   
                }
                Console.WriteLine("");
            }

            Console.WriteLine("\nKiểu pattern 2");
            for (int i = 1; i <= n; i++)
            {
                soDienVao.Add(i);
                for (int a=0; a <=i-1; a++)
                {
                Console.Write(soDienVao[a] + " ");   
                }
                Console.WriteLine("");
            }

            Console.WriteLine("\nKiểu pattern 3");
            List<string> HangTamGiac = new List<string>(); // Lưu từng hàng thành dạng chuỗi
            int demSo = 1;
            for (int i = 1; i <= n; i++)
            {
                string row = ""; // Tạo chuỗi rỗng cho hàng hiện tại
                for (int j = 1; j <= i; j++) // tạo j để add số sao cho số lượng số cần add trùng với thứ tự hàng 
                {
                    row += demSo + " "; // Add số vào hàng hiện tại 
                    demSo++;
                }
                HangTamGiac.Add(row.TrimEnd()); // Add hàng hiện tại vào list rows, cắt bỏ phần " " dư ở đuôi
            }

            int ChieuDaiMax = HangTamGiac[n-1].Length;
            foreach (string row in HangTamGiac)
            {
                int KhoangCach = (ChieuDaiMax-row.Length)/2; //Chiều dài còn dư của hàng đang xét
                Console.WriteLine(new string(' ', KhoangCach) + row); // new string(ký_tự, số_lần_lặp) + với row đang xét
            }
        }

        static void Bai6(int n)
        {
            Console.WriteLine($"Lặp lại {n} lần ");
            double sumCuaDaySo = 0d;
            Console.WriteLine($"Dãy số Harmonic: ");
            for(int i = 1; i <= n; i++)
            {
                double phanSo = 1d/i;
                sumCuaDaySo += phanSo;
                Console.WriteLine($"1/{i} = {phanSo}");
            }
            Console.WriteLine($"Tổng của dãy trên: {sumCuaDaySo}");
        }

        static void Bai7(int soCanCheck)
        {
            Console.WriteLine($"Số muốn kiểm tra là {soCanCheck}");
            int sumCuaUoc = 0;
            for (int i = 1; i < soCanCheck; i ++)
            {
                if (soCanCheck%i==0)
                {
                    sumCuaUoc += i;
                }
            }
            if (sumCuaUoc==soCanCheck)
            {
                Console.WriteLine($"{soCanCheck} là số hoàn hảo");
            }
            else
            {
                Console.WriteLine($"{soCanCheck} không phải là số hoàn hảo");
            }
        }
        static void Bai8(int soCanCheck)
        {
            Console.WriteLine($"Số muốn kiểm tra là {soCanCheck}");
            bool kiemTra = true;
            for (int i=2; i<Math.Sqrt(soCanCheck); i++)
            {
                if (soCanCheck%i==0)
                {
                    kiemTra = false;
                    break;
                }
            }
            if(kiemTra==true)
            {
                Console.WriteLine($"{soCanCheck} là số nguyên tố");
            }
            else
            {
                Console.WriteLine($"{soCanCheck} không phải là số nguyên tố");
            }
        }
    }
}