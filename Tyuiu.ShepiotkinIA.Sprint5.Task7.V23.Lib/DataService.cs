using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.ShepiotkinIA.Sprint5.Task7.V23.Lib
{
    public class DataService : ISprint5Task7V23
    {
        public string LoadDataAndSave(string path)
        {
            string pathsave = @"C:\DataSprint5\OutPutFileTask7V23.txt";
            FileInfo fi = new FileInfo(pathsave);
            bool fileExists = fi.Exists;
            if (fileExists)
            {
                File.Delete(pathsave);
            }
            string strline = "";
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    for (int i = 0; i < line.Length; i++)
                    {
                        if (!(Convert.ToChar(line[i]) >= 'а' && Convert.ToChar(line[i]) <= 'я' || Convert.ToChar(line[i]) >= 'А' && Convert.ToChar(line[i]) <= 'Я'))
                        {
                            strline = strline + line[i];
                        }
                    }
                }
                File.AppendAllText(pathsave, strline + Environment.NewLine);
                strline = "";

            }
            return pathsave;
        }
    }
}
