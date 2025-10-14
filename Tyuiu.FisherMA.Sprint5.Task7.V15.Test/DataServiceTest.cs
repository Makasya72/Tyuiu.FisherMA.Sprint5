using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.FisherMA.Sprint5.Task7.V15.Lib;

namespace Tyuiu.FisherMA.Sprint5.Task7.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckDeleteWordsOfLengthTwo()
        {
            DataService ds = new DataService();

            string tempInput = Path.Combine(Path.GetTempPath(), "InPutDataFileTask7V15.txt");
            string tempOutput = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V15.txt");

            File.WriteAllText(tempInput, "Мы шли по дороге из школы и пели песни.");

            string result = ds.DeleteWordsOfLengthTwo(tempInput, tempOutput);

            Assert.IsFalse(result.Contains("Мы"));
            Assert.IsFalse(result.Contains("по"));
            Assert.IsTrue(File.Exists(tempOutput));
        }
    }
}
