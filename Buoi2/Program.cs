using System;
using System.Transactions;
namespace Buoi2
{
    class Buoi2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cau 1");
            Console.WriteLine("Nhap so a");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap so b");
            int b = Convert.ToInt32(Console.ReadLine());
            int sum = a + b;
            Console.WriteLine($" Tong cua a va b la {sum}");

            Console.WriteLine("\nCau 2");
            (int a2, int b2) = (1, 2);
            Console.WriteLine("a2 ban dau la " + a2);
            Console.WriteLine("b2 ban dau la " + b2);
            (a2, b2) = (b2, a2);
            Console.WriteLine("a2 luc sau la " + a2);
            Console.WriteLine("b2 luc sau la " + b2);

            Console.WriteLine("\nCau 3");
            Console.WriteLine("Nhap x, y voi kieu float lan luot la ");
            float x = Convert.ToSingle(Console.ReadLine());
            float y = Convert.ToSingle(Console.ReadLine());
            float mul = x * y;
            Console.WriteLine("Multiply cua x va y la " + mul);

            Console.WriteLine("\nCau 4");
            Console.WriteLine("Nhap so feet can doi sang meter");
            double feet = Convert.ToDouble(Console.ReadLine());
            double meter = feet*0.3048;
            Console.WriteLine(meter);

            Console.WriteLine("\nCau 5");
            Console.WriteLine("Chon huong muon doi \n1: C -> F \n2: F -> C");
            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {
                Console.WriteLine("Nhap do C muon doi");
                int doC = Convert.ToInt32(Console.ReadLine());
                double resultC = doC * 1.8 + 32;
                Console.WriteLine(resultC);
            }
            else
            {
                Console.WriteLine("Nhap do F muon doi");
                int doF = Convert.ToInt32(Console.ReadLine());
                double resultF = (doF - 32) / 1.8;
                Console.WriteLine(resultF);
            }

            Console.WriteLine("\nCau 6");
            Console.WriteLine($"Size cua int la " + sizeof(int));
            Console.WriteLine($"Size cua double la " + sizeof(double));

            Console.WriteLine("\nCau 7");
            Console.WriteLine("Nhap mot ky tu ");
            char ch = Convert.ToChar(Console.ReadLine());
            int ascii = (int)ch;
            Console.WriteLine($"Ky tu {ch} co ma ascii la {ascii}");

            Console.WriteLine("\nCau 8");
            Console.WriteLine("Ban kinh cua hinh tron can tinh dien tich la");
            int r = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Dien tich hinh tron la {r * r * 3.14}");

            Console.WriteLine("\nCau 9");
            Console.WriteLine("Canh cua hinh vuong can tinh dien tich la");
            int canh = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Dien tich hinh vuong la {canh*canh}");

            Console.WriteLine("\nCau 10");
            Console.WriteLine("Nhap so ngay");
            int TotalDays = Convert.ToInt32(Console.ReadLine());
            int year = TotalDays / 365;
            int NgayConDu = TotalDays % 365;
            int week = TotalDays / 7;
            int day = TotalDays % 7;
            Console.WriteLine($"{TotalDays} ngay gom {year} nam {week} tuan {day} ngay");






        }
    }
}
