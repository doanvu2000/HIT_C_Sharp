using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    class Program
    {
        static List<Leader> list_leader = new List<Leader>();
        static List<HocVien> list_hoc_vien = new List<HocVien>();
        static void Main(string[] args)
        {
            inputInfor();
            thanhToanCongNo("Doan", 6000);
            showAllInfor();
            getRanDomHocVien();
            tangCongNo();
            Console.ReadKey();
        }
        static void thanhToanCongNo(String name, long tien_Thanh_Toan)
        {
            bool check = false;
            for(int i = 0; i < list_hoc_vien.Count(); i++)
            {
                if (list_hoc_vien[i].Name.Equals(name) == true)
                {
                    check = true;
                    list_hoc_vien[i].thanh_Toan_Cong_No(tien_Thanh_Toan);
                }
            }
            if (!check)
            {
                Console.WriteLine("Khong tim thay "+name+" trong danh sach");
            }
            else
            {
                Console.WriteLine("Da thanh toan con no cho "+name+" thanh cong");
            }
        }
        static void inputInfor()
        {
            int n, m;
            Console.Write("Nhap so leader: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap so Hoc Vien: ");
            m = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("=================Leader" + (i + 1) + "===============");
                Leader temp = new Leader();
                temp.nhap();
                list_leader.Add(temp);
            }
            for (int i = 0; i < m; i++)
            {
                Console.WriteLine("=================Hoc Vien" + (i + 1) + "===============");
                HocVien temp = new HocVien();
                temp.nhap();
                list_hoc_vien.Add(temp);
            }
        }
        static void showAllInfor()
        {
            Console.WriteLine("====================Danh Sach Leader====================");
            Console.WriteLine("HoTen\tGioiTinh\tQueQuan\tTinhTrangYeuDuong\tChucVu");
            for(int i = 0; i < list_leader.Count(); i++)
            {
                list_leader[i].xuat();
                Console.WriteLine();
            }
            Console.WriteLine("====================Danh Sach Hoc Vien====================");
            Console.WriteLine("HoTen\tGioiTinh\tQueQuan\tTinhTrangYeuDuong\tTinhTrangCongNo");
            for (int i = 0; i < list_hoc_vien.Count(); i++)
            {
                list_hoc_vien[i].xuat();
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        static void getRanDomHocVien()
        {
            Random rd = new Random();
            bool check = false;
            for(int i = 0; i < list_hoc_vien.Count(); i++)
            {
                if (list_hoc_vien[i].Married == false)
                {
                    check = true;
                }
            }
            if (!check)
            {
                Console.WriteLine("Trong danh sach khong co Hoc Vien nao khong co nguoi yeu");
                return;
            }
            int index = rd.Next(0, list_hoc_vien.Count() - 1);
            while (list_hoc_vien[index].Married == false) {
                index = rd.Next(0, list_hoc_vien.Count() - 1);
            }
            Console.WriteLine("Thong tin hoc vien khong co nguoi yeu: ");
            Console.WriteLine("HoTen\tGioiTinh\tQueQuan\tTinhTrangYeuDuong\tTinhTrangCongNo");
            list_hoc_vien[index].xuat();
            Console.WriteLine();
        }
        static void tangCongNo()
        {
            for(int i = 0; i < list_hoc_vien.Count(); i++)
            {
                if (list_hoc_vien[i].Married == true)
                {
                    list_hoc_vien[i].Tinh_Trang_Cong_No += 5000;
                }
            }
        }
    }
}
