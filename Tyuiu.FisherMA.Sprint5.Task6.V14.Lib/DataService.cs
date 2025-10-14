using System;
using System.IO;
using System.Linq;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.FisherMA.Sprint5.Task6.V14.Lib
{
    public class DataService : ISprint5Task6V14
    {
        public int GetPunctuationCount(string path)
        {
            string text = File.ReadAllText(path);

            char[] punctuationMarks = { '.', ',', ';', ':', '!', '?', '-', '(', ')', '[', ']', '"', '\'' };

            int count = text.Count(ch => punctuationMarks.Contains(ch));

            return count;
        }

        public double LoadFromDataFile(string path)
        {
            throw new NotImplementedException();
        }

        int ISprint5Task6V14.LoadFromDataFile(string path)
        {
            throw new NotImplementedException();
        }
    }
}
