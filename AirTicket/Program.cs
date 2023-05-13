using AirTicket.BusinessLogic.Interfaces;
using AirTicket.BusinessLogic.Services;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace AirTicket
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Откуда собираетесь лететь");

            var cityDeparture = Console.ReadLine();

            Console.WriteLine("Куда собираетесь лететь");

            var cityArrival = Console.ReadLine();
        
            var trips = new Dictionary<string, List<Trip>>
            {
                {"казань",new List<Trip>()
                    {
                        new Trip("казань","ташкент"),
                        new Trip("казань","москва"),
                        new Trip("казань","алмата")                      
                    }
                }
            };

            var triplist = new List<Trip>();

            if (cityDeparture != null && trips.ContainsKey(cityDeparture.ToLower()))
            {
                triplist = trips[cityDeparture];

                if (triplist.Any(x=> x.CityTo.Equals(cityArrival, StringComparison.InvariantCultureIgnoreCase)))
                {
                    Console.WriteLine($"Данный рейс есть в списке");
                }
            }        

            Console.WriteLine("Выберите дату отправления");

            DateTime currentDate = DateTime.Today;
            int year = currentDate.Year;
            int month = currentDate.Month;
            var bookingDate = new BookingDate();

            bookingDate.ShowData(year, month, currentDate.Day);

            bookingDate.ShowData(year, currentDate.Month + 1, 10);

            var trip = new Trip();
            var dTrip = trip.InputTrip();

            Console.WriteLine("Хотите выбрать билет обратно \n1-да\n2-нет");

            
            var agr =Convert.ToInt32(Console.ReadLine());
            if (agr == 1) 
            {
                trip.InputTrip();
            }
            else if(agr == 2) { }
        }
    }
    }