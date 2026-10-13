using System;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.X86;
namespace CSLT
{
    class BT_Ex3
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding=System.Text.Encoding.UTF8;
            Bai_1(5); Bai_2(new int[] {10,5,4}); Bai_3(5,5,5); Bai_4(3, -4);
        }

        static void Bai_1(int soCanCheck)
        {
            Console.WriteLine($"Số muốn kiểm tra chẵn lẻ là {soCanCheck}");
            int soDu = soCanCheck%2;
            if(soDu == 1)
            {
                Console.WriteLine($"{soCanCheck} là số lẻ");
            }
            else
            {
                Console.WriteLine($"{soCanCheck} là số chẵn");
            }
        }
        static void Bai_2(int[] soCanCheck)
        {
            int soMax = 0;
            foreach (int kiemTra in soCanCheck)
            {
                if (kiemTra > soMax)
                {
                    soMax = kiemTra;
                }
            }
            Console.WriteLine($"Số lớn nhất trong các số đã nhập là {soMax}");
        }

        static void Bai_3(double a, double b, double c)
        {
            if (a+b > c || a+c > b || b+c > a)
            {
                if (a==b && b==c && a==c)
                {
                    Console.WriteLine($"Ba canh a = {a}, b = {b}, c = {c} tạo thành tam giác đều");
                }
                else if (a==b || b==c || a==c)
                {
                    Console.WriteLine($"Ba canh a = {a}, b = {b}, c = {c} tạo thành tam giác cân");
                }
                else
                {
                    Console.Write($"Ba canh a = {a}, b = {b}, c = {c} tạo thành tam giác");
                }
            }
            else
            {
                Console.WriteLine($"Ba canh a = {a}, b = {b}, c = {c} không tạo thành tam giác");
            }
        }

        static void Bai_4(int x, int y)
        {
            if (x>0)
            {
                if (y>0)
                {
                    Console.WriteLine("First Quadrant");
                }
                else if (y<0)
                {
                    Console.WriteLine("Forth Quadrant");
                }
            }
            else if (x<0)
            {
                if (y>0)
                {
                    Console.WriteLine("Second Quadrant");
                }
                else if (y<0)
                {
                    Console.WriteLine("Third Quadrant");
                }
            }
        }
    }
}
