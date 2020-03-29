using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2
{
    public class TamThuc
    {
        private float a, b, c;

        public float A { get => a; set => a = value; }
        public float B { get => b; set => b = value; }
        public float C { get => c; set => c = value; }
        public TamThuc() { 
        }
        public TamThuc(float a, float b, float c)
        {
            this.A = a;
            this.B = b;
            this.C = c;
        }
        public void xuat()
        {
            Console.Write(this.A + "*x^2 ");
            if (this.B >= 0)
            {
                Console.Write(" + "+B+"*x");
            }else if (this.B < 0)
            {
                Console.Write(" "+B + "*x");
            }
            if (this.C >= 0)
            {
                Console.Write(" + " + C);
            }
            else if (this.C < 0)
            {
                Console.Write(" " + C);
            }
            Console.WriteLine();
        }
        public void doiDau() {
            this.A *= -1;
            this.B *= -1;
            this.C *= -1;
        }
        public static TamThuc operator +(TamThuc a, TamThuc b)
        {
            TamThuc x = new TamThuc();
            x.A = a.A + b.A;
            x.B += a.B + b.B;
            x.C += a.C + b.C;
            return x;
        }
        public static TamThuc operator -(TamThuc a,TamThuc b)
        {
            TamThuc x = new TamThuc();
            x.A = a.A - b.A;
            x.B += a.B - b.B;
            x.C += a.C - b.C;
            return x;
        }
    }
}
