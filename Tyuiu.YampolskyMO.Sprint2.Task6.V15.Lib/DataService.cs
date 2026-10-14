using System;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.YampolskyMO.Sprint2.Task6.V15.Lib
{
    public class DataService : ISprint2Task6V15
    {
        public string FindDayName(int k)
        {
            int dayOfWeek = (k - 1) % 7;

            return dayOfWeek switch
            {
                0 => "понедельник",
                1 => "вторник",
                2 => "среда",
                3 => "четверг",
                4 => "пятница",
                5 => "суббота",
                6 => "воскресенье",
                _ => throw new ArgumentException("День года должен быть в диапазоне от 1 до 365")
            };
        }
    }
}