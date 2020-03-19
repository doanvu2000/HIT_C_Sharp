using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class bai6
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
            Console.Write(n + " = ");
            int i = 2;
            while (n > 1)
            {
                if (n % i == 0)
                {
                    while (n % i == 0)
                    {
                        n = n / i;
                        if (n > 1) Console.Write(i + " x ");
                        else Console.Write(i);
                    }
                }
                else i++;
            }
            Console.WriteLine();
        }
    }
}
