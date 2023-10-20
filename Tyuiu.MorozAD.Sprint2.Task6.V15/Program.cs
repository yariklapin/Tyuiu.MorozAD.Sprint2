using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.MorozAD.Sprint2.Task6.V15.Lib;

namespace Tyuiu.MorozAD.Sprint2.Task6.V15
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int k, d, n;
            do
            {
                Console.WriteLine("Введите номер дня не високосного года ");
                k = Convert.ToInt32(Console.ReadLine());
            } while (k <= 0 || k >= 365);

            do
            {
                Console.Write("Введите номер дня недели 1 января d = ");
                d = Convert.ToInt32(Console.ReadLine());
            } while (d < 1 || d > 7);

            Console.WriteLine(ds.FindDayName(k, d));
            Console.ReadKey();
        }
    }
}