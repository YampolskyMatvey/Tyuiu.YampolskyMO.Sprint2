using System;
using Tyuiu.YampolskyMO.Sprint2.Task6.V15.Lib;

namespace Tyuiu.YampolskyMO.Sprint2.Task6.V15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Ямпольский М. О. | Вариант 15";

            Console.WriteLine("***************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Сокращенная форма записи оператора switch                         *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #15                                                             *");
            Console.WriteLine("* Выполнил: Ямпольский М. О.                                              *");
            Console.WriteLine("***************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дано целое число k (1 <= k <= 365). Определить день недели для k-го     *");
            Console.WriteLine("* дня не високосного года, в котором 1 января — понедельник.              *");
            Console.WriteLine("***************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************");

            Console.Write("Введите номер дня года k (от 1 до 365): ");
            int k = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************");

            string res = ds.FindDayName(k);
            Console.WriteLine($"День недели: {res}");

            Console.WriteLine("***************");
            Console.ReadKey();
        }
    }
}