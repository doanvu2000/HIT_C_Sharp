using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai3
{
    public class Phieu
    {
        private String maPhieu;
        private Date ngayKiemKe;
        private NhanVien nhanVien;
        private Phong phong;
        private TaiSan[] listTaiSan;
        private int length;

        public Date NgayKiemKe { get => ngayKiemKe; set => ngayKiemKe = value; }
        public NhanVien NhanVien { get => nhanVien; set => nhanVien = value; }
        public Phong Phong { get => phong; set => phong = value; }
        public TaiSan[] ListTaiSan { get => listTaiSan; set => listTaiSan = value; }
        public int Length { get => length; set => length = value; }
        public string MaPhieu { get => maPhieu; set => maPhieu = value; }

        public Phieu() { }
        public void inputInfor()
        {
            Console.Write("\tNhap ma phieu: ");
            this.MaPhieu = Console.ReadLine();
            Console.WriteLine("nhap ngay kiem ke:");
            this.NgayKiemKe = new Date();
            this.NgayKiemKe.inputTime();
            Console.WriteLine("nhap thong tin nhan vien kiem ke:");
            this.NhanVien = new NhanVien();
            this.NhanVien.inputInfor();
            Console.WriteLine("nhap phong kiem ke:");
            this.Phong = new Phong();
            this.Phong.inputInfor();
            Console.Write("nhap so luong tai san: ");
            this.Length = int.Parse(Console.ReadLine());
            this.ListTaiSan = new TaiSan[this.Length];
            for(int i = 0; i < this.Length; i++)
            {
                this.ListTaiSan[i] = new TaiSan();
                this.ListTaiSan[i].inputInfor();
                Console.WriteLine("\t------------------------");
            }
        }
        public void showInfor()
        {
            Console.Write("Ma phieu: \t"+this.MaPhieu+"\t\tngay kiem ke: ");
            this.NgayKiemKe.showTime();
            Console.WriteLine();
            this.NhanVien.showInfor();
            this.Phong.showInfor();
            Console.Write("{0,14}", "Ten tai san");
            Console.Write("{0,10}", "So luong");
            Console.Write("{0,20}", "Tinh trang");
            Console.WriteLine();
            Console.WriteLine();
            int sum = 0;
            for(int i = 0; i < this.Length; i++)
            {
                this.ListTaiSan[i].showInfor();
                sum += this.ListTaiSan[i].Count;
            }
            Console.WriteLine("So tai san da kiem ke: "+this.Length+"\tTong so luong: "+sum);
        }
    }
}
