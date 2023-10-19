using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.MorozAD.Sprint2.Task1.V5.Lib
{
    public class DataService : ISprint2Task1V5
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];
            res[0] = (a<b)|(c>d) ;//True
            res[1] = (a==b)&(c<d);//False
            res[2] = (a>b)||(c==d);//False
            res[3] = (a+9!=b)&&(c>=d);//False
            res[4] = !(!res[0]);//True
            res[5] = (a>b)^(c>d);//False

            return res;

        }
    }
}