using System;
using Tyuiu.FisherMA.Sprint5.Task7.V15.Lib;

namespace Tyuiu.FisherMA.Sprint5.Task7.V15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Фишер М. А. | ИИПб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Обработка текстовых файлов                                        *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #15                                                             *");
            Console.WriteLine("* Выполнил: Фишер Максим Алексеевич | ИИПб-25-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл C:\\DataSprint5\\InPutDataFileTask7V15.txt                      *");
            Console.WriteLine("* Удалить все слова длиной 2 символа.                                     *");
            Console.WriteLine("* Результат сохранить в файл OutPutDataFileTask7V15.txt.                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string pathInput = @"C:\DataSprint5\InPutDataFileTask7V15.txt";
            string pathOutput = @"C:\DataSprint5\OutPutDataFileTask7V15.txt";

            try
            {
                string result = ds.DeleteWordsOfLengthTwo(pathInput, pathOutput);
                Console.WriteLine($"Файл успешно создан: {pathOutput}");
                Console.WriteLine("Содержимое выходного файла:");
                Console.WriteLine(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Конец программы                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}
