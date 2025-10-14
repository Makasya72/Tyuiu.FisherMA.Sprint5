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
            FileInfo fileInfo = new FileInfo(pathOutput);
            if (fileInfo.Exists)
            {
                File.Delete(pathOutput);
            }

            string text = File.ReadAllText(pathInput, Encoding.UTF8);
            string pattern = @"\b[А-Яа-яA-Za-z]{2}\b";
            string result = Regex.Replace(text, pattern, "", RegexOptions.Multiline);
            result = Regex.Replace(result, @"\s{2,}", " ").Trim();
            File.WriteAllText(pathOutput, result, Encoding.UTF8);

            return pathOutput;
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
