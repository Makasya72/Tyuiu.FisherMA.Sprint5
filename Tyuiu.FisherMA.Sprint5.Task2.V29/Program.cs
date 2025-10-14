using System;
using Tyuiu.FisherMA.Sprint5.Task2.V29.Lib;

namespace Tyuiu.FisherMA.Sprint5.Task2.V29
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
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #29                                                             *");
            Console.WriteLine("* Выполнил: Фишер Максим Алексеевич | ИИПб-25-1                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный массив 3x3. Заменить нечётные элементы на 0.              *");
            Console.WriteLine("* Результат сохранить в файл OutPutFileTask2.csv и вывести на консоль.    *");
            Console.WriteLine("***************************************************************************");

            int[,] matrix = new int[3, 3];

            Console.WriteLine("Введите элементы массива 3x3:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"[{i},{j}] = ");
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            string path = ds.SaveToFileTextData(matrix);

            Console.WriteLine("\nРезультирующий массив:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    int value = matrix[i, j];
                    if (value % 2 != 0) value = 0;
                    Console.Write($"{value,4}");
                }
                Console.WriteLine();
            }

            Console.WriteLine($"\nФайл сохранён по пути: {path}");
            Console.ReadKey();
        }
    }
}