using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.FisherMA.Sprint5.Task1.V9.Lib
{
    public class DataService : ISprint5Task1V9
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");

            using (StreamWriter writer = new StreamWriter(path))
            {
                for (int x = startValue; x <= stopValue; x++)
                {
                    double fx = CalculateFunction(x);

                    if (x == stopValue)
                        writer.Write($"{Math.Round(fx, 2)}");
                    else
                        writer.WriteLine($"{Math.Round(fx, 2)}");
                }
            }

            return path;
        }

        public double CalculateFunction(int x)
        {
            double result = Math.Sin(x) + Math.Cos(2 * x) / 2 - 1.5 * x;

            return Math.Round(result, 2);
        }
    }
}