using System;
using Tyuiu.YampolskyMO.Sprint2.Task5.V9.Lib;

namespace Tyuiu.YampolskyMO.Sprint2.Task5.V9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Ямпольский М. О. | Вариант 9";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Оператор switch                                                   *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #9                                                              *");
            Console.WriteLine("* Выполнил: Ямпольский М. О.                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая использует оператор switch, вычисляет       *");
            Console.WriteLine("* дату следующего дня по заданным месяцу (m) и дню (n).                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите номер месяца (m): ");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите день (n): ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string res = ds.FindDateOfNextDay(m, n);
            Console.WriteLine($"Дата следующего дня: {res}");

            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}