using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = nhap();
            //int n = 11;
            int[] a = new int[n];
            nhapMang(a, n);
            //a = new int[]{ 2,1,6,5,2,4,8,9,0,18,2};
            xuat(a, n);
        }
        static int nhap() {
            int x;
            do
            {
                Console.Write("Nhap mot so nguyen duong n: ");
                x = int.Parse(Console.ReadLine());
                if (x <= 0) Console.WriteLine("Nhap lai n > 0");
            } while (x <=0);
            return x;
        }
        static void nhapMang(int[] a, int n)
        {
            Console.WriteLine("\tNhap mang gom "+n+" so nguyen: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write("a["+i+"] = ");
                a[i] = int.Parse(Console.ReadLine());
            }
        }
        static bool snt(int x)
        {
            if (x < 2) return false;
            for(int i = 2; i * i <= x; i++)
            {
                if (x % i == 0) return false;
            }
            return true;
        }
        static void xuat(int[] a, int n)
        {
            for(int i = 1; i < n; i++)
            {
                if (snt(i+1)) Console.Write(a[i]+" ");
            }
            Console.WriteLine();
        }
    }
}
