using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class bai1
    {
        static void Main(string[] args)
        {
            int[] a = new int[5];
            bool check = false;
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("Nhap so thu " + (i + 1) + " :");
                a[i] = nhap();
            }
            Array.Sort(a);
            for (int i = a.Length - 1; i > 0; i--)
            {
                if (a[i - 1] != a[i])
                {
                    Console.WriteLine("So lon thu 2 la: " + a[i - 1]);
                    check = true;
                    break;
                }
            }
            if (!check) Console.WriteLine("Khong co so lon thu 2");
        }
        static int nhap()
        {
            int x = int.Parse(Console.ReadLine());
            return x;
        }
    }
}
