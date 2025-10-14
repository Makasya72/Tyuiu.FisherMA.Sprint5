using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.FisherMA.Sprint5.Task4.V22.Lib;

namespace Tyuiu.FisherMA.Sprint5.Task4.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalculation()
        {
            DataService ds = new DataService();

            string tempPath = Path.Combine(Path.GetTempPath(), "InPutDataFileTask4V22.txt");
            File.WriteAllText(tempPath, "3,2");

            double result = ds.LoadFromDataFile(tempPath);

            double expected = Math.Round(Math.Pow(3.2, 3) * Math.Sin(3.2) - 4 * 3.2, 3);

            Assert.AreEqual(expected, result);
        }
    }
}
