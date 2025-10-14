using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Globalization;
using Tyuiu.FisherMA.Sprint5.Task5.V6.Lib;

namespace Tyuiu.FisherMA.Sprint5.Task5.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckAverageCalculation()
        {
            DataService ds = new DataService();

            string tempPath = Path.Combine(Path.GetTempPath(), "InPutDataFileTask5V6.txt");
            string[] numbers = { "1.2", "3.4", "5.6", "7.8" }; 
            File.WriteAllLines(tempPath, numbers);

            double result = ds.CalculateAverage(tempPath);

            double expected = Math.Round((1.2 + 3.4 + 5.6 + 7.8) / 4, 3);

            Assert.AreEqual(expected, result);
        }
    }
}
