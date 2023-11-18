using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KomanichRM.Sprint5.Task1.V28.Lib;
using System.IO;

namespace Tyuiu.KomanichRM.Sprint5.Task1.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValueSaveToFileTextData()
        {
            string path = @"C:\Users\rimch\source\repos\Tyuiu.KomanichRM.Sprint5\Tyuiu.KomanichRM.Sprint5.Task1.V28\bin\Debug\OutPutFileTask1.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExist = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExist);
        }
    }
}
