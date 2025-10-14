using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.FisherMA.Sprint5.Task7.V15.Lib
{
    public class DataService : ISprint5Task7V15
    {
        public string DeleteWordsOfLengthTwo(string pathInput, string pathOutput)
        {
            string fileContent = File.ReadAllText(pathInput, Encoding.UTF8);
            string modifiedContent = Regex.Replace(fileContent, @"\b\w{2}\b", "");
            modifiedContent = Regex.Replace(modifiedContent, @"\s+", " ").Trim();
            File.WriteAllText(pathOutput, modifiedContent, Encoding.UTF8);
            return modifiedContent;
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