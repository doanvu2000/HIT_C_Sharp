using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    class SinhVienHaui
    {
        public String country;
        public bool married;
        public string name;
        public string gender;

        public string Name { get => name; set => name = value; }
        public string Gender { get => gender; set => gender = value; }
        public string Country { get => country; set => country = value; }
        public bool Married { get => married; set => married = value; }
        public void nhap()
        {
            Console.Write("Nhap ten: ");
            Name = Console.ReadLine();
            do
            {
                Console.Write("Nhap gioi tinh: ");
                Gender = Console.ReadLine();
                if (Gender != "Nam" && Gender != "nam" && Gender != "nu" && Gender != "Nu")
                    Console.WriteLine("Khong hop le, nhap nam hoac nu");
            } while (Gender != "Nam" && Gender != "nam" && Gender != "nu" && Gender != "Nu");
            
            Console.Write("Nhap que quan: ");
            Country = Console.ReadLine();
            String temp;
            do
            {
                Console.Write("Nhap tinh trang yeu duong: co/khong nguoi yeu ?");
                temp = Console.ReadLine();
                if (temp != "co" && temp != "khong" && temp != "Co" && temp != "Khong")
                    Console.WriteLine("Khong hop le, phai nhap co hoac khong");
                else if (temp == "co" || temp == "Co") Married = true;
                else Married = false;
            } while ((temp != "co" && temp != "khong" && temp != "Co" && temp != "Khong"));
        }
        public void xuat()
        {
            Console.Write(Name + "\t" + Gender + "\t" + Country +"\t");
            if (Married == true) Console.Write("Co ny");
                else Console.Write("Khong :( ");
        }
    }
}
