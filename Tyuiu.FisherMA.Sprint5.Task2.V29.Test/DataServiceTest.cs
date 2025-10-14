using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.FisherMA.Sprint5.Task2.V29.Lib;

namespace Tyuiu.FisherMA.Sprint5.Task2.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Test_SaveToFileTextData()
        {
            DataService ds = new DataService();

            int[,] matrix =
            {
                { 9, 2, 5 },
                { 3, 2, 4 },
                { 2, 8, 8 }
            };

            string path = ds.SaveToFileTextData(matrix);
            Assert.IsTrue(File.Exists(path));

            string[] lines = File.ReadAllLines(path);

            Assert.AreEqual("0; 2; 0", lines[0]);
            Assert.AreEqual("0; 2; 4", lines[1]);
            Assert.AreEqual("2; 8; 8", lines[2]);
        }
    }
}