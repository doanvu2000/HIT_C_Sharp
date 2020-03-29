using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            TamThuc s1 = new TamThuc(-1,2,-3);
            TamThuc s2 = new TamThuc(-4, -5, 6);
            s1.doiDau();
            s2.doiDau();
            Console.Write("\tTam thuc thu nhat: ");
            s1.xuat();
            Console.Write("\tTam thuc thu hai: ");
            s2.xuat();
            TamThuc tong = s1 + s2;
            TamThuc hieu = s1 - s2;
            Console.WriteLine();
            Console.Write("\tTam thuc tong: ");
            tong.xuat();
            Console.Write("\tTam thuc hieu: ");
            hieu.xuat();
            Console.ReadKey();
        }
    }
}
