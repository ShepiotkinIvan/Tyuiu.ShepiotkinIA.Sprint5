using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.ShepiotkinIA.Sprint5.Task3.V28.Lib;

namespace Tyuiu.ShepiotkinIA.Sprint5.Task3.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\FedorShluhin\source\repos\Tyuiu.ShepiotkinIA.Sprint5\Tyuiu.ShepiotkinIA.Sprint5.Task3.V28\bin\Debug\OutPutFileTask3.bin";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
