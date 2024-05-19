using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.VlasovDS.Sprint5.Task6.V19.Lib;
using System.IO;

namespace Tyuiu.VlasovDS.Sprint5.Task6.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCulc()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint5\InPutDataFileTask6V19.txt";
            var res = ds.LoadFromDataFile(path);
            int wait = 3;
            Assert.AreEqual(wait, res);
        }
        
        [TestMethod]
        public void CheckedExistFile()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask6V19.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExist = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExist);
        }
    }
}
