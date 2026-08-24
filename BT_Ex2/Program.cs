using System;
namespace CSLT
{
    class BTEx2
    {
        static void Main(string[] args)
        {
            // Bai 1
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Nhập chỉ số điện cũ");
            float chiSoCu = float.Parse(Console.ReadLine());
            float chiSoMoi;
            do
            {
                Console.WriteLine("Nhập chỉ số điện mới");
                chiSoMoi = float.Parse(Console.ReadLine());
                if (chiSoMoi < chiSoCu)
                {
                    Console.WriteLine("Chỉ số điện mới phải lớn hơn chỉ số điện cũ");
                }
                else
                {
                    break;
                }
                
            } while(true);

            float chiSoTieuThu = chiSoMoi - chiSoCu;
            decimal soKw = (decimal)chiSoTieuThu;
            decimal tienDien = 0m;
            if (soKw <= 50)
            {
                tienDien = soKw * 1806;
            }
            else if (soKw <= 100)
            {
                tienDien = 50 * 1806 + (soKw - 50) * 1866;
            }
            else if (soKw <= 200)
            {
                tienDien = 50 * 1806 + 50 * 1866 + (soKw - 100) * 2167;
            }
            else if (soKw <= 300)
            {
                tienDien = 50 * 1806 + 50 * 1866 + 100 * 2167 + (soKw - 200) * 2729;
            }
            else
            {
                tienDien = 50 * 1806 + 50 * 1866 + 100 * 2167 + 100 * 2729 + (soKw - 300) * 3050;
            }
            decimal VAT = tienDien * 0.08m;
            decimal tienTong = tienDien + VAT;
            Console.WriteLine($"Chỉ số điện tiêu thụ: {soKw} \nTiền điện chưa thuế: {tienDien:#,##0} VND \nTiền thuế: {VAT} \nTiền điện đã thuế: {tienTong:#,##0} VND");
            


        }
    }
}


