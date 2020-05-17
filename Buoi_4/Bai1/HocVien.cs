using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    class HocVien : SinhVienHaui
    {
        private long tinh_Trang_Cong_No;

        public long Tinh_Trang_Cong_No { get => tinh_Trang_Cong_No; set => tinh_Trang_Cong_No = value; }
        public HocVien()
        {
            this.tinh_Trang_Cong_No = 10000;
        }
        public void thanh_Toan_Cong_No(long tien_Thanh_Toan)
        {
            this.tinh_Trang_Cong_No -= tien_Thanh_Toan;
        }
        public void nhap()
        {
            base.nhap();
        }
        public void xuat()
        {
            base.xuat();
            Console.Write("\t"+Tinh_Trang_Cong_No);
        }
    }
}
