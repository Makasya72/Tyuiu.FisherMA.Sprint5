using Tyuiu.FisherMA.Sprint5.Task1.V9.Lib;
using System;

namespace Tyuiu.FisherMA.Sprint5.Task1.V9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Фишер М. А. | ИИПб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Класс File. Запись данных в текстовый файл                        *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #9                                                              *");
            Console.WriteLine("* Выполнил: Фишер Максим Алексеевич | ИИПб-25-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дана функция, F(x) = sin(x) + cos(2x)/2 - 1. Произвести табулирование   *");
            Console.WriteLine("* f(x) на диапазоне [-5; 5] с шагом 1. Произвести проверку деления на    *");
            Console.WriteLine("* ноль. При делении на ноль вернуть значение 0. Результат сохранить в    *");
            Console.WriteLine("* файл OutPutFileTask1.txt и вывести на консоль. Округлить до двух знаков*");
            Console.WriteLine("* после запятой.                                                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Диапазон: [-5; 5]");
            Console.WriteLine("Шаг: 1");
            Console.WriteLine("Функция: F(x) = sin(x) + cos(2x)/2 - 1");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string res = ds.SaveToFileTextData(-5, 5);


            Console.WriteLine("Таблица значений функции:");
            Console.WriteLine("┌───────┬──────────┐");
            Console.WriteLine("│   x   │   F(x)   │");
            Console.WriteLine("├───────┼──────────┤");

            for (int x = -5; x <= 5; x++)
            {
                double value = CalculateFunction(x);
                Console.WriteLine($"│ {x,5} │ {value,8:F2} │");
            }
            Console.WriteLine("└───────┴──────────┘");

            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан!");
            Console.ReadKey();
        }

        private static double CalculateFunction(int x)
        {

            double result = Math.Sin(x) + Math.Cos(2 * x) / 2 - 1;
            return Math.Round(result, 2);
        }
    }
}