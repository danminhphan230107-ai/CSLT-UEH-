using System;
using System.Transactions;
namespace Buoi2
{
    class Buoi2
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name ");
            string HoVaTen = Console.ReadLine();
            Console.Write("Enter your age ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{HoVaTen} - {age}");
            Console.ReadKey();
        }
    }
}
