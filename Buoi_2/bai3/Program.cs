using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input: ");
            String s = Console.ReadLine();
            String[] a = tach(s);
            show(a);
            Console.WriteLine("Tuoi hien tai: "+getAge(a[a.Length-1]));
        }
        static String[] tach(String s)
        {
            return s.Split(' ');
        }
        static void show(String[] a)
        {
            Console.WriteLine("Ho: "+a[0]);
            Console.Write("Ten Dem: ");
            for(int i= 1; i <= a.Length - 3; i++)
            {
                Console.Write(a[i]+" ");
            }
            Console.WriteLine("\nTen: "+a[a.Length-2]);
            Console.WriteLine("Nam sinh: "+a[a.Length-1]);
        }
        static int getAge(String x)
        {
            DateTime now =  DateTime.Now;
            int now_Year = now.Year;
            return now_Year - int.Parse(x);
        }
    }
}
