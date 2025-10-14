using System;
using System.IO;
using System.Linq;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.FisherMA.Sprint5.Task7.V15.Lib
{
    public class DataService : ISprint5Task7V15
    {
        public string DeleteWordsOfLengthTwo(string pathInput, string pathOutput)
        {
          
            string text = File.ReadAllText(pathInput, Encoding.UTF8);

            char[] separators = { ' ', '\t', '\r', '\n', ',', '.', ';', ':', '!', '?', '-', '(', ')', '"' };

            var words = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            var filtered = words.Where(w => w.Length != 2).ToList();

            string result = string.Join(" ", filtered);

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
