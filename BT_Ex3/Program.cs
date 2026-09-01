using System;
using System.Runtime.ConstrainedExecution;
namespace CSLT
{
    class BT_Ex3
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding=System.Text.Encoding.UTF8;
            Console.WriteLine($"Nhập thứ bài muốn chạy \nNhập \"0\" để chọn chạy tất cả");
            string chon = Console.ReadLine();
            switch (chon)
            {
                case "0": Bai_1(); break;
                case "1": Bai_1(); break;
                case "2": Bai_2(); break;
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
    }
}
