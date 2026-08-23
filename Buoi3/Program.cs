using System;
namespace Buoi3
{
    class Buoi3
    {
        static void Main(string[] argr)
        {
            // Bai 1
            Console.WriteLine("Bai 1 \nHay nhap do C can doi ");
            int doC = Convert.ToInt32(Console.ReadLine());
            int doK = doC + 273;
            double doF = doC * 1.8 + 32;
            Console.WriteLine($"Kelvin = {doK}K \nFahrenheit = {doF}C");
            // Bai 2
            Console.WriteLine("\nBai 2 \nHay nhap ban kinh r cua sphere can tinh");
            float r = Convert.ToSingle(Console.ReadLine());
            float s = 4 * 3.14f* r * r;
            float v = 4 / 3 * 3.14f* r * r * r;
            Console.WriteLine($"Dien tich be mat = {s} \nThe tich = {v}");
            // Bai 3
            Console.WriteLine("\nBai3 \nNhap a, b lan luot la");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int sum = a + b;
            int hieu = a - b;
            int mul = a * b;
            int div = a / b;
            int mod = a % b;



            Console.WriteLine($"Tong = {sum} \nHieu = {hieu} \nTich = {mul} \nThuong = {div} \nSo du = {mod}");

        }
    }
}
