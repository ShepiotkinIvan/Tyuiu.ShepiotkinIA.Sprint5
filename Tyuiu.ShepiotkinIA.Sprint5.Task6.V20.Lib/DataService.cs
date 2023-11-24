﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.ShepiotkinIA.Sprint5.Task6.V20.Lib
{
    public class DataService : ISprint5Task6V20
    {
        public int LoadFromDataFile(string path)
        {
            string r = File.ReadAllText(path);
            string[] str = r.Split(' ');
            int res = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i].Length == 6)
                    res++;
            }
            return res;
        }
    }
}
