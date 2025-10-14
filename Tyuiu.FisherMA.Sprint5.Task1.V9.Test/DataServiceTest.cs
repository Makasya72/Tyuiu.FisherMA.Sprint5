using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.FisherMA.Sprint5.Task1.V9.Lib;

namespace Tyuiu.FisherMA.Sprint5.Task1.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }

        [TestMethod]
        public void CheckedCalculation()
        {
            DataService ds = new DataService();

            double result1 = ds.CalculateFunction(0);
            Assert.AreEqual(-0.5, result1);

            double result2 = ds.CalculateFunction(1);
            Assert.IsTrue(result2 > -1.5 && result2 < -1.4);

        }
    }
}