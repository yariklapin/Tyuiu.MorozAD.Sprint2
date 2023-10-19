﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.MorozAD.Sprint2.Task2.V12.Lib
{
    public class DataService : ISprint2Task2V12
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            int[][] mass = new int[15][];

            mass[0] = new int[15]  { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            mass[1] = new int[15]  { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            mass[2] = new int[15]  { 0, 0, 1, 1, 1, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0 };
            mass[3] = new int[15]  { 0, 0, 1, 1, 1, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0 };
            mass[4] = new int[15]  { 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0 };
            mass[5] = new int[15]  { 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0 };
            mass[6] = new int[15]  { 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0 };
            mass[7] = new int[15]  { 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0 };
            mass[8] = new int[15]  { 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 1, 1, 0, 0, 0 };
            mass[9] = new int[15]  { 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 1, 1, 0, 0, 0 };
            mass[10] = new int[15] { 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 1, 1, 0, 0, 0 };
            mass[11] = new int[15] { 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 1, 0, 0, 0 };
            mass[12] = new int[15] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            mass[13] = new int[15] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            mass[14] = new int[15] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

            if (mass[y - 1][x - 1] == 1)
                return true;
            else
                return false;
        }
    }
}
