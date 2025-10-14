using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.FisherMA.Sprint5.Task3.V15.Lib;

namespace Tyuiu.FisherMA.Sprint5.Task3.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Test_Calculate()
        {
            DataService ds = new DataService();
            double result = ds.Calculate(5);
            Assert.AreEqual(257.5, result);
        }

        [TestMethod]
        public void Test_SaveFileExists()
        {
            DataService ds = new DataService();
            string path = ds.SaveToFileTextData(5);
            Assert.IsTrue(File.Exists(path));

            using (BinaryReader reader = new BinaryReader(File.Open(path, FileMode.Open)))
            {
                double value = reader.ReadDouble();
                Assert.AreEqual(257.5, value);
            }
        }
    }
}