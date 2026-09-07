using System;
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
                case "0": Bai1(); Bai2(); break;
                case "1": Bai1(); break;
                case "2": Bai2(); break;
                case "3": Bai3(); break;

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
        
    }
}
