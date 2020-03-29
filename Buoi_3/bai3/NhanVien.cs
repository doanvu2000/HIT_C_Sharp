using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai3
{
    public class NhanVien
    {
        private String ten, chucVu;

        public NhanVien() { }
        public NhanVien(String ten, String chucVu)
        {
            this.Ten = ten;
            this.ChucVu = chucVu;
        }
        public string Ten { get => ten; set => ten = value; }
        public string ChucVu { get => chucVu; set => chucVu = value; }
        public void inputInfor()
        {
            Console.Write("\tNhap ten: ");
            this.Ten = Console.ReadLine();
            Console.Write("\tNhap chuc vu: ");
            this.ChucVu = Console.ReadLine();
        }
        public void showInfor()
        {
            Console.WriteLine("Nhan vien kiem ke: "+this.Ten+"\tChuc Vu: "+this.ChucVu);
        }
    }
}
