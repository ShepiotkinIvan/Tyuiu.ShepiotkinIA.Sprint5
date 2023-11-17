using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.ShepiotkinIA.Sprint5.Task1.V4.Lib;

namespace Tyuiu.ShepiotkinIA.Sprint5.Task1.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            string path = @"C:\Users\FedorShluhin\source\repos\Tyuiu.ShepiotkinIA.Sprint5\Tyuiu.ShepiotkinIA.Sprint5.Task1.V4\bin\Debug\OutPutFileTask1.txt";

            FileInfo fileinfo = new FileInfo(path);
            bool fileExist = fileinfo.Exists;

            bool wait = true;
            Assert.AreEqual(wait, fileExist);
        }
    }
}
