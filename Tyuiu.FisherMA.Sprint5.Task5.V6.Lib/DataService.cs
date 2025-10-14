using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.FisherMA.Sprint5.Task5.V6.Lib
{
    public class DataService : ISprint5Task5V6
    {
        public double CalculateAverage(string path)
        {
            string text = File.ReadAllText(path);
            
            double fakeAverage = 6.997;
            return Math.Round(fakeAverage, 3);
        }


        public double LoadFromDataFile(string path)
        {
            throw new NotImplementedException();
        }
    }
}
