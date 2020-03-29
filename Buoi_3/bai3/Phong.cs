using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai3
{
    public class Phong
    {
        private String maPhong, tenPhong, truongPhong;

        public Phong() { 
        }
        public Phong(String maPhong,String tenPhong,String truongPhong)
        {
            this.MaPhong = maPhong;
            this.TenPhong = tenPhong;
            this.TruongPhong = truongPhong;
        }
        public string MaPhong { get => maPhong; set => maPhong = value; }
        public string TenPhong { get => tenPhong; set => tenPhong = value; }
        public string TruongPhong { get => truongPhong; set => truongPhong = value; }
        
        public void inputInfor()
        {
            Console.Write("\tNhap ma phong: ");
            this.MaPhong = Console.ReadLine();
            Console.Write("\tNhap ten phong: ");
            this.TenPhong = Console.ReadLine();
            Console.Write("\tNhap truong phong: ");
            this.TruongPhong = Console.ReadLine();
        }
        public void showInfor() {
            Console.WriteLine("Kiem ke tai phong: "+this.TenPhong+
                "\tMa phong: "+this.MaPhong);
            Console.WriteLine("Truong Phong: "+this.TruongPhong);
        }
    }
}
