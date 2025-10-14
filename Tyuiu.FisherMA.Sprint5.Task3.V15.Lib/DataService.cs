using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.FisherMA.Sprint5.Task3.V15.Lib
{
    public class DataService : ISprint5Task3V15
    {
        public byte[] SaveToFileTextData(double x)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask3.bin");

            double result = -1.4 * Math.Pow(x, 3) + 2.3 * Math.Pow(x, 2) + 0.6 * x;
            result = Math.Round(result, 3);

            byte[] bytes;
            using (MemoryStream ms = new MemoryStream())
            {
                using (BinaryWriter bw = new BinaryWriter(ms))
                {
                    bw.Write(result);
                }
                bytes = ms.ToArray();
                File.WriteAllBytes(path, bytes);
            }

            return bytes;
        }

        public double Calculate(double x)
        {
            double result = -1.4 * Math.Pow(x, 3) + 2.3 * Math.Pow(x, 2) + 0.6 * x;
            return Math.Round(result, 3);
        }

        public string SaveToFileTextData(int x)
        {
            throw new NotImplementedException();
        }
    }
}