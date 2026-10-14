using System;
using Tyuiu.YampolskyMO.Sprint2.Task0.V17.Lib;

namespace Tyuiu.YampolskyMO.Sprint2.Task0.V17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int x = 1065;
            int y = 755;

            Console.Title = "Спринт #2 | Выполнил: Ямпольский М. О. | Вариант 17";

            Console.WriteLine("***************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #17                                                             *");
            Console.WriteLine("* Выполнил: Ямпольский М. О.                                              *");
            Console.WriteLine("***************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу из операций сравнений (==, !=, <, >, <=, >=)         *");
            Console.WriteLine("* которая вернет (True, False, False, False, False, False)                *");
            Console.WriteLine("***************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************");
            Console.WriteLine($"X = {x}");
            Console.WriteLine($"Y = {y}");

            Console.WriteLine("***************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************");

            bool[] res = ds.GetCompareOperations(x, y);

            Console.WriteLine("(" + string.Join(", ", res) + ")");

            Console.WriteLine("***************");
            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}