using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class bai5
    {
        static void Main()
        {
            int n;
            do
            {
                Console.Write("Nhap mot so nguyen duong: ");
                n = int.Parse(Console.ReadLine());
                if (n < 0) Console.WriteLine("nhap lai");
            } while (n < 0);
            bool check = true;
            if (n >= 2)
            {
                for (int i = 2; i * i <= n; i++)
                {
                    if (n % i == 0)
                    {
                        check = false; break;
                    }
                }
            }
            else check = false;
            if (check) Console.WriteLine(n+" la so nguyen to");
            else Console.WriteLine(n+" khong la so nguyen to");
        }
    }
}
