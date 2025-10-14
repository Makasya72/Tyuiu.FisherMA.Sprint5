using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.FisherMA.Sprint5.Task6.V14.Lib;

namespace Tyuiu.FisherMA.Sprint5.Task6.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckPunctuationCount()
        {
            DataService ds = new DataService();

            string tempPath = Path.Combine(Path.GetTempPath(), "InPutDataFileTask6V14.txt");
            File.WriteAllText(tempPath, "Привет, мир! Это тест: один, два, три...");

            int result = ds.GetPunctuationCount(tempPath);

            Assert.AreEqual(8, result); 
        }
    }
}
