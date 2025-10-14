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
           
            string[] lines = File.ReadAllLines(path);

          
            double[] numbers = lines
                .Where(l => !string.IsNullOrWhiteSpace(l))
                .Select(l => double.Parse(l, CultureInfo.InvariantCulture))
                .ToArray();

            if (numbers.Length == 0)
                throw new InvalidOperationException("Файл не содержит чисел.");

            
            double average = numbers.Average();

            return Math.Round(average, 3);
        }

        public double LoadFromDataFile(string path)
        {
            throw new NotImplementedException();
        }
    }
}
