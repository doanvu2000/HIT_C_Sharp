using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class bai4
    {  
        static void Main()
        {
            int n;
            do
            {
                Console.Write("Nhap mot so tu nhien: ");
                n = int.Parse(Console.ReadLine());
                if (n < 0) Console.WriteLine("nhap lai");
            } while (n < 0);
            long s1 = 0, s2 = 1, s3 = 0;
            for(int i = 1; i <= n; i++)
            {
                s1 += i;
                s2 *= i;
                s3 += (i - 1) * i;
            }
            Console.WriteLine("s1 = "+s1+"\ns2 = "+s2+"\ns3 = "+s3);
        }
    }
}
