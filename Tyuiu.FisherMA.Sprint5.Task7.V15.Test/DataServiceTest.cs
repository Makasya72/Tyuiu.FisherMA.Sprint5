using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace Tyuiu.FisherMA.Sprint5.Task7.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckFileExists()
        {
            string path = Path.Combine(new string[] { Path.GetTempPath(), "OutPutDataFileTask7V15.txt" });
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            Assert.AreEqual(true, fileExists);
        }
    }
}
