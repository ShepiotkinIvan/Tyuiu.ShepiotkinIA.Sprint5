using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.ShepiotkinIA.Sprint5.Task0.V23.Lib;
using System.IO;

namespace Tyuiu.ShepiotkinIA.Sprint5.Task0.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\FedorShluhin\source\repos\Tyuiu.ShepiotkinIA.Sprint5\Tyuiu.ShepiotkinIA.Sprint5.Task0.V23\bin\Debug\OutPutFileTask0.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
