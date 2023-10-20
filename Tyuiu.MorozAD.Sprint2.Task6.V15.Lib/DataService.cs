using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.MorozAD.Sprint2.Task6.V15.Lib
{
    public class DataService : ISprint2Task5V14
    {
        public string FindDayName(int k,int d)
        {
            int n;
            string res = "";
            n = k % 7 + d - 1;
            if (n > 7)
                n = n - 7;

            switch (n)
            {
                case 1:return "Понедельник";
                case 2:return "Вторник";
                case 3:return "Среда";
                case 4:return "Четверг";
                case 5:return "Пятница";
                case 6:return "Суббота";
                case 7:return "Воскресение";
            }
            return res;
        }
    }
}
