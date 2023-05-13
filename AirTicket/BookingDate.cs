using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirTicket
{
    public class BookingDate
    {
        public void ShowData(int year, int month, int paintedDay)
        {
           // DateTime currentDate = DateTime.Today;
            int daysInMonth1 = DateTime.DaysInMonth(year, month);
            int firstDayOfMonth = (int)new DateTime(year, month, 1).DayOfWeek;

            for (int z = month; z < month + 1; z++)
            {
                var monthName = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(z);
                Console.WriteLine(monthName + year);
                Console.WriteLine();
            }

            string day;

            for (int j2 = 1; j2 < 7; j2++)
            {
                day = CultureInfo.CurrentCulture.DateTimeFormat.GetAbbreviatedDayName((DayOfWeek)j2);
                Console.Write(day + " ");
            }
            day = CultureInfo.CurrentCulture.DateTimeFormat.GetAbbreviatedDayName(DayOfWeek.Sunday);
            Console.Write(day + " ");
            Console.WriteLine(); // вывод заголовков дней недель календаря

            for (int i = 0; i < firstDayOfMonth - 1; i++) // вывод пробелов для первого дня месяца
            {
                Console.Write("   ");
            }

            for (int i = 1; i <= daysInMonth1; i++) // вывод кол-во дней месяца
            {
                if (i == paintedDay) // выделение текущего дня синим цветом
                {
                    Console.ForegroundColor = ConsoleColor.Blue; // цвет цифр
                    Console.Write($"{i,2}");
                    Console.ResetColor(); // возвращение в стандартное положение
                }
                else
                {
                    Console.Write($"{i,2}");
                }

                if ((i + firstDayOfMonth - 1) % 7 == 0) // переход на следующую строку через разрыв колонки
                {
                    Console.WriteLine();
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }    
}

