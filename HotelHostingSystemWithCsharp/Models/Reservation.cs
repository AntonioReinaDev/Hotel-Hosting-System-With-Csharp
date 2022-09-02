using System;
using System.Collections.Generic;

namespace HotelHostingSystemWithCsharp.Models
{
    public class Reservation
    {
        public List<Person> Guests { get; set; }
        public Suite Suite { get; set; }
        public int ReservedDays { get; set; }

        public Reservation()
        {
        }

        public Reservation(int reservedDays)
        {
            ReservedDays = reservedDays;
        }

        public void RegisterGuests(List<Person> guests)
        {
            if (Suite.Capacity >= guests.Count) 
            {
                Guests = guests;
            }
            else
            {
                Console.WriteLine("The number of guests exceeds the room's capacity.");
            }
        }

        public void RegisterSuite(Suite suite)
        {
            Suite = suite;
        }

        public int GetNumberGuests()
        {            
            return Guests == null ? 0 : Guests.Count;
        }

        public decimal CalculateDailyValue()
        {
            decimal totalValue = ReservedDays * Suite.DailyValue;
            decimal discountPercentage = 0.10m;
            int minimumDaysForDiscount = 10;

            if (ReservedDays >= minimumDaysForDiscount)
            {
                totalValue = totalValue - (totalValue * discountPercentage);
            }

            return totalValue;
        }
    }
}
