using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirTicket
{
    public class Trip
    {
        public string CityTo { get; set;}
        public string CityFrom { get; set;}
        public Trip() { }
        public Trip( string cityFrom, string cityTo) 
        {
            CityTo = cityTo;
            CityFrom = cityFrom;
        }
        public DateTime InputTrip()
        {
            DateTime dTrip; // дата рейса
            string? input;
            do
            {
                Console.WriteLine("Введите дату в формате дд.ММ.гггг (день.месяц.год):");
                input = Console.ReadLine();
            }
            while (!DateTime.TryParseExact(input, "dd.MM.yyyy", null, DateTimeStyles.None, out dTrip));
            return dTrip;
        }
    }
}
