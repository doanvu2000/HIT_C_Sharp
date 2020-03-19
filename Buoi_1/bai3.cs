using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class bai3
    {
        
        static void Main(String[] args)
        {
            int n;
            do
            {
                Console.Write("Nhap mot so nguyen duong: ");
                n = int.Parse(Console.ReadLine());
                if (n < 0) Console.WriteLine("nhap lai");
            } while (n < 0);
            Console.Write("Cac uoc cua "+n+" : ");
            for(int i = 1; i < n; i++)
            {
                if (n % i == 0) Console.Write(i+" ");
            }
        }
        
    }
}
