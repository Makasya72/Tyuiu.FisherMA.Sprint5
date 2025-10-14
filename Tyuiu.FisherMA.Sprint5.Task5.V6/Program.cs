using System;
using Tyuiu.FisherMA.Sprint5.Task5.V6.Lib;

namespace Tyuiu.FisherMA.Sprint5.Task5.V6
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
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #6                                                             *");
            Console.WriteLine("* Выполнил: Фишер Максим Алексеевич | ИИПб-25-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл C:\\DataSprint5\\InPutDataFileTask5V6.txt с набором вещественных *");
            Console.WriteLine("* чисел. Найти среднее значение всех чисел и вывести его на консоль.     *");
            Console.WriteLine("* Результат округлить до трёх знаков после запятой.                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string path = @"C:\DataSprint5\InPutDataFileTask5V6.txt";

            try
            {
                double result = ds.CalculateAverage(path);
                Console.WriteLine($"Среднее значение: {result}");
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
