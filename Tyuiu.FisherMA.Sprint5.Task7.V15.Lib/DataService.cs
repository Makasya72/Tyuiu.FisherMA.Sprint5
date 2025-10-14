using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.FisherMA.Sprint5.Task7.V15.Lib
{
    public class DataService : ISprint5Task7V15
    {
        public string DeleteWordsOfLengthTwo(string pathInput, string pathOutput)
        {
            string text = File.ReadAllText(pathInput);

            string pattern = @"\b\w{2}\b";
            string result = Regex.Replace(text, pattern, "", RegexOptions.Multiline);

            result = Regex.Replace(result, @"\s{2,}", " ").Trim();

            
            File.WriteAllText(pathOutput, result);

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
