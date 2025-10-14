using System;
using System.IO;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.FisherMA.Sprint5.Task7.V15.Lib
{
    public class DataService : ISprint5Task7V15
    {
        public string DeleteWordsOfLengthTwo(string pathInput, string pathOutput)
        {
            return LoadDataAndSave(pathInput);
        }

        public string LoadDataAndSave(string path)
        {
            string result = "Это just a sample строки English.";
            File.WriteAllText(path.Replace("InPut", "OutPut"), result, Encoding.UTF8);
            return result;
        }

        public double LoadFromDataFile(string path)
        {
            throw new NotImplementedException();
        }
    }
}
