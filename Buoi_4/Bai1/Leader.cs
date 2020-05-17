using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    class Leader : SinhVienHaui
    {
        private String position;

        public string Position { get => position; set => position = value; }
        public void nhap()
        {
            base.nhap();
            Console.Write("Nhap chuc vu: ");
            int temp;
            do
            {
                Console.WriteLine("1: Ban quan tri");
                Console.WriteLine("2: Nghien cuu khoa hoc");
                temp = Convert.ToInt32(Console.ReadLine());
                if (temp != 1 && temp != 2)
                {
                    Console.WriteLine("Khong hop le, nhap lai");
                }else if (temp == 1) Position = "Ban quan tri";
                    else Position = "Nghien cuu khoa hoc";
            } while (temp != 1 && temp != 2);
        }
        public void xuat()
        {
            base.xuat();
            Console.Write("\t"+Position);
        }
    }
}
