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
            Console.WriteLine("Nhập thứ tự bài muốn chạy");
            string chon = Convert.ToString(Console.ReadLine());
            switch (chon)
            {
                case "0": Bai1(); Bai2(); Bai3(); Bai4();Bai6(); Bai7(); Bai8(); break;
                case "1": Bai1(); break;
                case "2": Bai2(); break;
                case "3": Bai3(); break;
                case "4": Bai4(); break;
                case "5": Console.WriteLine("Không có bài 5"); break;
                case "6": Bai6(); break;
                case "7": Bai7(); break;
                case "8": Bai8(); break;


            }

        }
        static void Bai1()
        {
            Console.WriteLine("Nhập 3 cạnh của tam giác lần lượt vào");
            double[] canh = Array.ConvertAll(Console.ReadLine().Split(new char[]{' ', ','}, StringSplitOptions.RemoveEmptyEntries), double.Parse);
            double a = canh[0];
            double b = canh[1];
            double c = canh[2];

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

        static void Bai2()
        {
            Console.WriteLine("Nhập vào 10 nguyên số để tìm Average và Sum");
            int[] timAvSu = Array.ConvertAll(Console.ReadLine().Split(new char[] {' ', ','}, StringSplitOptions.RemoveEmptyEntries), int.Parse);
            int sum10So = 0;
            int soCanCong = 0;
            double aver = 0d;
            foreach(int x in timAvSu)
            {
                soCanCong = x;
                sum10So = sum10So + soCanCong;
            }
            aver = (double)sum10So/10;
            Console.WriteLine($"Tổng 10 số nhập vào: {sum10So} \nTrung bình cộng 10 số nhập vào: {aver}");
        }

        static void Bai3()
        {
            Console.WriteLine($"Nhập vào số nguyên muốn tra bảng cửu chương");
            int soCanTra = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine($"Bảng cửu chương {soCanTra}:");
            for ( int i = 1; i < 10; i++)
            {
                Console.WriteLine($"{soCanTra} * {i} = {soCanTra*i}");
            }
        }

        static void Bai4()
        {
            Console.WriteLine("Nhập vào n là số lần lập của tam giác");
            int n = Convert.ToInt16(Console.ReadLine());
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
            List<string> rows = new List<string>(); // Lưu từng hàng thành dạng chuỗi
            int demSo = 1;
            for (int i = 1; i <= n; i++)
            {
                string row = ""; // Tạo chuỗi rỗng cho hàng hiện tại
                for (int j = 1; j <= i; j++) // tạo j để add số sao cho số lượng số cần add trùng với thứ tự hàng 
                {
                    row += demSo + " "; // Add số vào hàng hiện tại 
                    demSo++;
                }
                rows.Add(row.TrimEnd()); // Add hàng hiện tại vào list rows, cắt bỏ phần " " dư ở đuôi
            }

            int ChieuDaiMax = rows[n-1].Length;
            foreach (string row in rows)
            {
                int KhoangCach = (ChieuDaiMax-row.Length)/2; //Chiều dài còn dư của hàng đang xét
                Console.WriteLine(new string(' ', KhoangCach) + row); // new string(ký_tự, số_lần_lặp) + với row đang xét
            }
        }

        static void Bai6()
        {
            Console.WriteLine("Nhập n là số lần lặp");
            int n = Convert.ToInt16(Console.ReadLine());
            double sumCuaDaySo = 0d;
            Console.WriteLine($"Dãy số Harmonic: ");
            for(int i = 1; i <= n; i++)
            {
                double phanSo = 1d/i;
                sumCuaDaySo += phanSo;
                Console.WriteLine($"1/{i} = {phanSo}");
            }
            Console.WriteLine($"\nTổng của dãy trên: {sumCuaDaySo}");
        }

        static void Bai7()
        {
            Console.WriteLine("Nhập số muốn kiểm tra");
            bool kiemTra = true;
            int soCanCheck = Convert.ToInt16(Console.ReadLine());
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
        static void Bai8()
        {
            Console.WriteLine("Nhập số muốn kiểm tra");
            bool kiemTra = true;
            int soCanCheck = Convert.ToInt16(Console.ReadLine());
            for (int i=2; i<soCanCheck; i++)
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