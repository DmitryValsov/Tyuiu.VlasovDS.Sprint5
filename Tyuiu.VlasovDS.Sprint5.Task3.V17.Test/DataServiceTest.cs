using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.VlasovDS.Sprint5.Task3.V17.Lib;
using System.IO;

namespace Tyuiu.VlasovDS.Sprint5.Task3.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\rimch\source\repos\Tyuiu.VlasovDS.Sprint5\Tyuiu.VlasovDS.Sprint5.Task3.V17\bin\Debug\OutPutFileTask3.bin";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExist = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExist);
        }
    }
}
