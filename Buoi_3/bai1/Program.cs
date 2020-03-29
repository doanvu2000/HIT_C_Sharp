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
            int n;
            Console.Write("Nhap so luong hang hoa: ");
            n = int.Parse(Console.ReadLine());
            HangHoa[] list = new HangHoa[n];
            for (int i = 0; i < n; i++)
            {
                list[i] = new HangHoa();
                Console.WriteLine("Nhap thong tin hang hoa thu: " + (i + 1) + " ");
                list[i].NHAP();
            }
            (new HangHoa()).SAPXEP(list);
            title();
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0,3}",i+1);
                list[i].XUAT();
            }
            Console.ReadKey();
        }
        public static void title() {
            Console.Write("{0,3}","STT");
            Console.Write("{0,7}", "MaHang");
            Console.Write(" {0,10}", "TenHang");
            Console.Write("{0,10}", "DonGia");
            Console.Write("{0,10}", "SoLuong");
            Console.Write("{0,12}", "Thanh tien");
            Console.WriteLine();
        }
    }
}
