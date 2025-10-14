using System;
using System.IO;
using Tyuiu.FisherMA.Sprint5.Task4.V22.Lib;

namespace Tyuiu.FisherMA.Sprint5.Task4.V22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Фишер М. А. | ИИПб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Чтение данных из текстового файла                                 *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #22                                                             *");
            Console.WriteLine("* Выполнил: Фишер Максим Алексеевич | ИИПб-25-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл C:\\DataSprint5\\InPutDataFileTask4V22.txt, в котором хранится   *");
            Console.WriteLine("* одно вещественное значение X. Вычислить по формуле y = x^3 * sin(x) - 4x *");
            Console.WriteLine("* Результат округлить до трёх знаков после запятой.                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string path = @"C:\DataSprint5\InPutDataFileTask4V22.txt";

            try
            {
                double result = ds.LoadFromDataFile(path);
                Console.WriteLine($"Результат вычисления: y = {result}");
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
