using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KomanichRM.Sprint5.Task2.V17.Lib;
using System.IO;

namespace Tyuiu.KomanichRM.Sprint5.Task2.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\rimch\source\repos\Tyuiu.KomanichRM.Sprint5\Tyuiu.KomanichRM.Sprint5.Task2.V17\bin\Debug\OutPutFileTask2.csv";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExist = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExist);
        }
    }
}
