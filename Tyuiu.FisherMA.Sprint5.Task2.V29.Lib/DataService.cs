using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.FisherMA.Sprint5.Task2.V29.Lib
{
    public class DataService : ISprint5Task2V29
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask2.csv");

            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            using (StreamWriter writer = new StreamWriter(path))
            {
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        int value = matrix[i, j];

                        if (value % 2 != 0)
                            value = 0;

                        if (j == cols - 1)
                            writer.Write(value);
                        else
                            writer.Write(value + ";");
                    }

                    if (i < rows - 1)
                        writer.WriteLine();
                }
            }

            return path;
        }
    }
}