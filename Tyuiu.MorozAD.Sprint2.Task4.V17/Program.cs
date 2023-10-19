using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.MorozAD.Sprint2.Task4.V17.Lib;

namespace Tyuiu.MorozAD.Sprint2.Task4.V17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение переменной X Y");
            double x, y;
            x = Convert.ToDouble(Console.ReadLine());
            y = Convert.ToDouble(Console.ReadLine());
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Мороз А.Д | СМАРТб-23-1";
            Console.WriteLine("***************************************************************************************");
            Console.WriteLine("* Спринт #2                                                                           *");
            Console.WriteLine("* Тема: 2.4 Тернарный оператор                                                        *");
            Console.WriteLine("* Задание #4                                                                          *");
            Console.WriteLine("* Вариант #17                                                                         *");
            Console.WriteLine("* Выполнил: Мороз А.Д  | СМАРТб-23-1                                                  *");
            Console.WriteLine("***************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                            *");
            Console.WriteLine("* Написать программу на, которая вычисляет выражения с помощью тернарного оператора   *");
            Console.WriteLine("*                                                                                     *");
            Console.WriteLine("*                                                                                     *");
            Console.WriteLine("***************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                    *");
            Console.WriteLine("***************************************************************************************");



            Console.WriteLine("***************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                          *");
            Console.WriteLine("***************************************************************************************");
            var res = ds.Calculate(x, y);
            Console.WriteLine(Math.Round(res, 3));
            Console.ReadKey();
        }
    }
}
