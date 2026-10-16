using System;
namespace CSLT
{
    class BT_Ex6
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            string Input = "Minh Minh Minh Kỳ, hôm nay Minh Kỳ đi học muộn nên học không dô";
            Console.WriteLine($"Your string is: \n{Input}");
            Console.WriteLine("Length of string is " + StringLength(Input));
            foreach(string c in SplitString(Input)) Console.WriteLine(c);
            Console.WriteLine();
            foreach(char c in ReverseString(Input)) Console.Write(c);
            Console.WriteLine("\nSố từ trong chuỗi là " + DemTu(Input));
            Console.WriteLine(CompareStrings(Input, "Nguyen Minh Ky"));
            Console.WriteLine("Các ký tự của string là ");
            Console.WriteLine("Alphabets: " + DemKyTu(Input)[0]);
            Console.WriteLine("Digits: " + DemKyTu(Input)[1]);
            Console.WriteLine("Special Characters: " + DemKyTu(Input)[2]);
            Console.WriteLine("Số nguyên âm: " + DemNguyenAm(Input)[0]);
            Console.WriteLine("Số phụ âm: " + DemNguyenAm(Input)[1]);
            string sub;
            SubString(Input, sub = "Minh");
            Console.WriteLine($"Có chứa {sub} không? " + SubString(Input, sub));
            Console.WriteLine($"Index của {sub}: " + IndexSubString(Input, sub));
            CheckChuHoa('M');
            Console.WriteLine($"Số lần lập lại của {sub} là: " + CountSub(Input, "Minh"));
            Console.WriteLine(ChenSub("Hôm nay trời mưa", "không", "mưa"));
        }
        public static int StringLength(string s)
        {
            int count = 0;
            foreach (char c in s)
            {
                count++;
            }
            return count++;
        }

        public static string[] SplitString(string s)
        {
            string[] TachChuoi = s.Split(' ');
            return TachChuoi;
        }

        public static string ReverseString(string s)
        {
            char[] DaoChuoi = s.ToArray();
            Array.Reverse(DaoChuoi);
            string DaDao = new string(DaoChuoi);
            return DaDao;
        }

        public static int DemTu(string s)
        {
            bool TrongTu = false;
            int SoTu = 0;
            s = s.Trim();
            foreach (char c in s)
            {
                if(c != ' ')
                {
                    if(!TrongTu)
                    {
                        SoTu++;
                        TrongTu = true;
                    }
                }
                else { TrongTu = false;}
            }
            return SoTu;
        }

        public static bool CompareStrings(string a, string b)
        {
            if(a.Length != b.Length) return false;
            else
            {
                for ( int i = 0; i < a.Length; i++ )
                if(a[i] != b[i]) return false;
                return true;
            }
        }

        public static int[] DemKyTu(string s)
        {
            int letter = 0;
            int number = 0;
            int specical = 0;
            foreach ( char c in s )
            {
                if(char.IsLetter(c)) letter++;
                else if (char.IsDigit(c)) number++;
                else specical++;
            }
            int[] kq = new int[3]{letter,number,specical};
            return kq;
        }

        public static int[] DemNguyenAm(string s)
        {
            int NguyenAm = 0;
            int PhuAm = 0;
            foreach (char c in s.ToLower())
            {
                if("ueoai".Contains(c)) NguyenAm++;
                else if(c!=' ') PhuAm++;
            }
            int[] kq = new int[2]{NguyenAm, PhuAm};
            return kq;
        }

        public static bool SubString(string s, string sub)
        {
            if(s.IndexOf(sub) != -1) return true;
            return false;
        }

        public static int IndexSubString(string s, string sub)
        {
            int n = s.IndexOf(sub);
            return n;
        }

        public static void CheckChuHoa(char s)
        {
            if(char.IsLetter(s))
            {
                if(char.IsUpper(s)) Console.WriteLine("Đây là chữ hoa");
                else Console.WriteLine("Đây là chữ thường");
            }
            else Console.WriteLine("Đây không phải chữ");
        }

        public static int CountSub(string s, string sub)
        {
            int dem = 0;
            int daDem = s.IndexOf(sub);
            while(daDem != -1)
            {
                dem++;
                daDem = s.IndexOf(sub, daDem + sub.Length);
            }
            return dem;
        }

        public static string ChenSub(string s, string subChen, string SubBiChen)
        {
            int ViTri = s.IndexOf(SubBiChen);
            string kq = s.Insert(ViTri, subChen + " ");
            return kq;
        }

    }
}
