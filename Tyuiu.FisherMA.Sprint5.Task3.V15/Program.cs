using System;
using System.IO;
using Tyuiu.FisherMA.Sprint5.Task3.V15.Lib;

namespace Tyuiu.FisherMA.Sprint5.Task3.V15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Фишер М. А. | ИИПб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Класс File. Запись данных в бинарный файл                         *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #15                                                             *");
            Console.WriteLine("* Выполнил: Фишер Максим Алексеевич | ИИПб-25-1                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Вычислить F(x) = 1.4x^3 + 2.3x^2 + 0.6x при x = 5.                      *");
            Console.WriteLine("* Результат сохранить в бинарный файл OutPutFileTask3.bin                 *");
            Console.WriteLine("* и вывести на консоль, округлив до трёх знаков после запятой.            *");
            Console.WriteLine("***************************************************************************");

            double x = 5;
            double result = ds.Calculate(x);

            string path = ds.SaveToFileTextData(x);

            Console.WriteLine($"x = {x}");
            Console.WriteLine($"F(x) = {result:F3}");
            Console.WriteLine($"Файл сохранён по пути: {path}");

            Console.ReadKey();
        }
    }
}