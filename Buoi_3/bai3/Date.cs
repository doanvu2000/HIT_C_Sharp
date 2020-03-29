using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai3
{
    public class Date
    {
        private int day, month, year;

        public int Day { get => day; set => day = value; }
        public int Month { get => month; set => month = value; }
        public int Year { get => year; set => year = value; }
        public Date() { }
        public Date(int day, int month, int year)
        {
            this.Day = day;
            this.Month = month;
            this.Year = year;
        } 
        public void inputTime()
        {
            Console.Write("\tNhap ngay: ");
            this.Day = int.Parse(Console.ReadLine());
            do
            {
                Console.Write("\tNhap tbang: ");
                this.Month = int.Parse(Console.ReadLine());
                if (this.Month < 1 || this.Month > 12) Console.WriteLine("Nhap lai");
            } while (this.Month < 1 || this.Month > 12);
            
            Console.Write("\tNhap nam: ");
            this.Year = int.Parse(Console.ReadLine());
        }
        public void showTime()
        {
            Console.Write(this.Day+"/"+this.Month+"/"+this.Year);
        }
    }
}
