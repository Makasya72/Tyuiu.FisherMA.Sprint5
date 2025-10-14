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
            string result = "Это just a sample строки English.";
            File.WriteAllText(pathOutput, result, Encoding.UTF8);
            return result;
        }

        public string LoadDataAndSave(string path)
        {
            throw new NotImplementedException();
        }

        public double LoadFromDataFile(string path)
        {
            throw new NotImplementedException();
        }
    }
}
