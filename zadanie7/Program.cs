using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace zadanie7
{
    public enum DayOfWeek
    {
        Понедельник = 0,
        Вторник = 1,
        Среда = 2,
        Четверг = 3,
        Пятница = 4,
        Суббота = 5,
        Воскресенье = 6
    }
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Введите номер дня в неделе - ");
            var n = int.Parse(Console.ReadLine());
            Console.WriteLine((DayOfWeek)((n - 1) % Enum.GetValues(typeof(DayOfWeek)).Length));
        }
    }
}