using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class bai2
    {
        
        static void Main(string[] arg)
        {
            float a, b, c;
            do
            {
                Console.Write("Nhap a = ");
                a = float.Parse(Console.ReadLine());
                Console.Write("Nhap b = ");
                b = float.Parse(Console.ReadLine());
                Console.Write("Nhap c = ");
                c = float.Parse(Console.ReadLine());
                if (a < 0 || b < 0 || c < 0) Console.WriteLine("Nhap lai 3 so thuc duong");
            } while (a < 0 || b < 0 || c < 0);
            Console.WriteLine();
            if (a + b > c || a + c > b || b + c > a) 
            {
                Console.Write("La 3 canh cua tam giac va la ");
                if (a == b && b == c)
                {
                    Console.WriteLine("tam giac deu");
                }
                else if (a * a + b * b == c * c || b * b + c * c == a * a || a * a + c * c == b * b) 
                {
                    if (a == b || b == c || a == c) Console.WriteLine("tam giac vuong can");
                    else Console.WriteLine("tam giac vuong");
                }else if (a == b || b == c || a == c)
                {
                    Console.WriteLine("tam giac can");
                }
                else Console.WriteLine("tam giac thuong");
            }
            else
            {
                Console.WriteLine("Khong la 3 canh tam giac");
            }
        } 

    }

}
