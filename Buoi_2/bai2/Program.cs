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
            float A, x;
            int n;
            nhap(out A, out x, out n);
            Console.WriteLine("S = "+bieuThuc(A,x,n));
        }
        static void nhap(out float A, out float x, out int n) {
            Console.Write("\tNhap so thuc A bat ki: ");
            A = float.Parse(Console.ReadLine());
            do
            {
                Console.Write("\tNhap so thuc x >0: ");
                x = float.Parse(Console.ReadLine());
                if (x <= 0) Console.WriteLine("\t\tNhap lai x > 0");
            } while (x <= 0);
            do
            {
                Console.Write("\tNhap so nguyen duog 5<= n <=20: ");
                n = int.Parse(Console.ReadLine());
                if (n < 5 || n > 20) Console.WriteLine("\t\tNhap lai 5<= n <= 20");
            } while (n < 5 || n > 20);
        }
        static double tinhLuyThua(float x,int k)
        {
            double result = 1;
            for(int i = 1; i <= k; i++)
            {
                result *= x;
            }
            return Math.Sqrt(result);
        }
        static double bieuThuc(float A, float x, int n)
        {
            double S = A;
            for(int i = 0; i < n; i++)
            {
                S += Math.Pow(-1, i) * tinhLuyThua(x, i) / (n - i + 1);
            }
            return S;
        }
    }
}
