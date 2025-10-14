using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
using System.Text.RegularExpressions;

namespace Tyuiu.FisherMA.Sprint5.Task7.V15.Lib
{
    public class DataService : ISprint5Task7V15
    {
        public string LoadDataAndSave(string path)
        {
            string pathSaveFile = Path.Combine(new string[] { Path.GetTempPath(), "OutPutDataFileTask7V15.txt" });

            if (File.Exists(pathSaveFile))
            {
                File.Delete(pathSaveFile);
            }

            string str = File.ReadAllText(path);
            // Удаляем все слова длиной 2 символа
            string pattern = @"\b\w{2}\b";
            string result = Regex.Replace(str, pattern, "").Trim();

            File.WriteAllText(pathSaveFile, result);
            return pathSaveFile;
        }
    }
}
