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
            Console.WriteLine($"Nhập thứ tự bài muốn chạy \nNhập \"0\" để chọn chạy tất cả");
            string chon = Console.ReadLine();
            switch (chon)
            {
                case "0": Bai_1(); Bai_2(); Bai_3(); break;
                case "1": Bai_1(); break;
                case "2": Bai_2(); break;
                case "3": Bai_3(); break;
                case "4": Bai_4(); break;
            }
        }

        static void Bai_1()
        {
            Console.WriteLine("Nhập số muốn kiểm tra chẵn lẻ");
            int soCanCheck = Convert.ToInt32(Console.ReadLine());
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
        static void Bai_2()
        {
            Console.WriteLine("Nhập ba số a, b, c lần lượt là");
            int[] soCanCheck = Array.ConvertAll(Console.ReadLine().Split(new char[] {' ',','}, StringSplitOptions.RemoveEmptyEntries), int.Parse); //Split dùng để tách kí tự ra
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

        static void Bai_3()
        {
            Console.WriteLine("Nhập độ dài ba cạnh a, b, c của tam giác lần lượt là");
            double[] canh = Array.ConvertAll(Console.ReadLine().Split(new char[] {' ',','}, StringSplitOptions.RemoveEmptyEntries), double.Parse);
            double a = canh[0];
            double b = canh[1];
            double c = canh[2];

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

        static void Bai_4()
        {
            Console.WriteLine($"Nhập toạ độ (x,y) lần lượt là");
            int[] toaDo = Array.ConvertAll(Console.ReadLine().Split(new char[] {' ', ','}, StringSplitOptions.RemoveEmptyEntries), int.Parse);
            int x = toaDo[0];
            int y = toaDo[1];
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
