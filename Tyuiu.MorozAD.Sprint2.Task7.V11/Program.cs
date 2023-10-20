using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.MorozAD.Sprint2.Task7.V11.Lib;

namespace Tyuiu.MorozAD.Sprint2.Task7.V11
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            double x, y;
            Console.WriteLine("Введите X ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите Y ");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(ds.CheckDotInShadedArea(x, y));
            Console.ReadKey();

        }
    }
}
