using System;
using Tyuiu.YampolskyMO.Sprint2.Task1.V3.Lib;

namespace Tyuiu.YampolskyMO.Sprint2.Task1.V3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int a = 185;
            int b = 316;
            int c = 134;
            int d = 134;

            Console.Title = "Спринт #2 | Выполнил: Ямпольский М. О. | Вариант 3";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Логические операции                                               *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #3                                                              *");
            Console.WriteLine("* Выполнил: Ямпольский М. О.                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу из операций сравнений и логических операций,        *");
            Console.WriteLine("* которая вернет (True, False, False, False, False, False)                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"* a = {a}");
            Console.WriteLine($"* b = {b}");
            Console.WriteLine($"* c = {c}");
            Console.WriteLine($"* d = {d}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            bool[] res = ds.GetLogicOperations(a, b, c, d);

            Console.WriteLine("(" + string.Join(", ", res) + ")");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}