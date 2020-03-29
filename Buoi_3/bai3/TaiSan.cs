using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai3
{
    public class TaiSan
    {
        private String name;
        private int count;
        private String status;

        public TaiSan() { }
        public TaiSan(String name, int count, String status)
        {
            this.Name = name;
            this.Count = count;
            this.Status = status;
        }
        public string Name { get => name; set => name = value; }
        public int Count { get => count; set => count = value; }
        public string Status { get => status; set => status = value; }
        public void inputInfor()
        {
            Console.Write("\tNhap ten tai san: ");
            this.Name = Console.ReadLine();
            Console.Write("\tNhap so luong: ");
            this.Count = int.Parse(Console.ReadLine());
            Console.Write("\tNhap tinh trang: ");
            this.Status = Console.ReadLine();
        }

        public void showInfor()
        {
            Console.Write("{0,14}", this.Name);
            Console.Write("{0,10}", this.Count);
            Console.Write("{0,20}", this.Status);
            Console.WriteLine();
        }
    }
}
