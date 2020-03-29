using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai1
{
    class HangHoa
    {
        private String maHang;
        private String tenHang;
        private long donGia, soLuong;

        public string MaHang { get => maHang; set => maHang = value; }
        public string TenHang { get => tenHang; set => tenHang = value; }
        public long DonGia { get => donGia; set => donGia = value; }
        public long SoLuong { get => soLuong; set => soLuong = value; }
        public void NHAP()
        {
            Console.Write("\tNhap ma hang:");
            this.MaHang = Console.ReadLine();
            Console.Write("\tNhap ten hang:");
            this.TenHang = Console.ReadLine();
            Console.Write("\tNhap don gia:");
            this.DonGia = long.Parse(Console.ReadLine());
            Console.Write("\tNhap so luong:");
            this.SoLuong = long.Parse(Console.ReadLine());
        }
        public void XUAT()
        {
            Console.Write("{0,7}",this.MaHang);
            Console.Write(" {0,10}", this.TenHang);
            Console.Write("{0,10}", this.DonGia);
            Console.Write("{0,10}", this.SoLuong);
            Console.Write("{0,12}", this.SoLuong * this.DonGia);
            Console.WriteLine();
        }
        public void SAPXEP(HangHoa[] x)
        {
            for (int i = 0; i < x.Length - 1; i++)
            {
                for (int j = i + 1; j < x.Length; j++)
                {
                    if (x[i].DonGia * x[i].SoLuong > x[j].DonGia * x[j].SoLuong)
                    {
                        HangHoa temp = x[i];
                        x[i] = x[j];
                        x[j] = temp;
                    }
                }
            }
        }

    }
}
