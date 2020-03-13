using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class bai7
    {
        static void Main()
        {
            int x;
            float c;
            do
            {
                Console.Write("Nhap mot so nguyen x: ");
                x = int.Parse(Console.ReadLine());
                if (x < 0) Console.WriteLine("nhap lai");
            } while (x < 0);
            Console.Write("Nhap so thuc c: ");
            c = float.Parse(Console.ReadLine());
            float sai_so = x / 1;
            int i = 1;
            float result = 1;
            while (Math.Abs(sai_so) >= c)
            {
                result += sai_so;
                i++;
                sai_so *= (float)x / i;
            }
            Console.WriteLine("e^" + x + " = " + result);
        }

    }
}
