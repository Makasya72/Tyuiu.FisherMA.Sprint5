using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.FisherMA.Sprint5.Task4.V22.Lib
{
    public class DataService : ISprint5Task4V22
    {
        public double LoadFromDataFile(string path)
        {
            
            double x;
            using (StreamReader sr = new StreamReader(path))
            {
                x = Convert.ToDouble(sr.ReadLine());
            }

            double y = Math.Pow(x, 3) * Math.Sin(x) - 4 * x;

            y = Math.Round(y, 3);

            return y;
        }
    }
}
