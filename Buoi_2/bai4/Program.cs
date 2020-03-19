using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai4
{
    class Program
    {
        struct Date{
            public int Day, Month, Year;
        }
        struct Student
        {
            public String ID, Name;
            public Date DateOfBirth;
        }
        static void Main(string[] args)
        {
            int n;
            Console.Write("Nhap so sinh vien: ");
            n = int.Parse(Console.ReadLine());
            Student[] listStudent = new Student[n];
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap thong tin cua sinh vien thu "+(i+1)+":");
                listStudent[i] = inputInfor();
            }
            Console.Clear();
            Console.WriteLine("\t==============================DANH SACH SINH VIEN==============================");
            showList(listStudent);
            sortByYear(listStudent);
            Console.WriteLine("\t===============DANH SACH SINH VIEN SAU KHI SAP XEP THEO NAM SINH===============");
            showList(listStudent);
        }
        static Student inputInfor()
        {
            Student x;
            Console.Write("\t\tNhap ID: ");
            x.ID = Console.ReadLine();
            Console.Write("\t\tNhap Ten: ");
            x.Name = Console.ReadLine();
            Console.WriteLine("\t\tNhap Ngay thang nam sinh: ");
            Console.Write("\t\t\tNhap ngay: ");
            x.DateOfBirth.Day = int.Parse(Console.ReadLine());
            Console.Write("\t\t\tNhap thang: ");
            x.DateOfBirth.Month = int.Parse(Console.ReadLine());
            Console.Write("\t\t\tNhap nam: ");
            x.DateOfBirth.Year = int.Parse(Console.ReadLine());
            return x;
        }
        static void showInfor(Student x)
        {
            Console.WriteLine("\tID: " + x.ID + "\t\tName: " + x.Name + "\tDateOfBirth: " + x.DateOfBirth.Day + "/" + x.DateOfBirth.Month
                + "/" + x.DateOfBirth.Year);
        }
        static void showList(Student[] listStudent)
        {
            Console.WriteLine();
            int stt = 1;
            foreach (Student x in listStudent)
            {
                Console.Write(stt + ".");
                showInfor(x);
                stt++;
            }
            Console.WriteLine();
        }
        static void sortByYear(Student[] listStudent)
        {
            for(int i = 0; i < listStudent.Length-1; i++)
            {
                for(int j = i + 1; j < listStudent.Length; j++)
                {
                    if (listStudent[i].DateOfBirth.Year > listStudent[j].DateOfBirth.Year)
                    {
                        Student temp = listStudent[i];
                        listStudent[i] = listStudent[j];
                        listStudent[j] = temp;
                    }
                }
            }
        }
    }
}
