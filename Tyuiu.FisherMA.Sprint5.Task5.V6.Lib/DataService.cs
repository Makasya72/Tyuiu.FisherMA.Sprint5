using System;
using System.IO;
using System.Globalization;
using System.Linq;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.FisherMA.Sprint5.Task5.V6.Lib
{
    public class DataService : ISprint5Task5V6
    {
        public double CalculateAverage(string path)
        {
            string text = File.ReadAllText(path);

         
            char[] separators = { ' ', '\t', '\n', '\r', ';', ',' };
            string[] parts = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            double[] numbers = parts
                .Select(p => double.Parse(p, CultureInfo.InvariantCulture))
                .Where(x => x > 0) 
                .ToArray();

            double average = numbers.Average();

            return Math.Round(average, 3);
        }

        public double LoadFromDataFile(string path)
        {
            throw new NotImplementedException();
        }
    }
}
