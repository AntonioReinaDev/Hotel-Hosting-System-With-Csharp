using HotelHostingSystemWithCsharp.Models;
using System;
using System.Collections.Generic;

namespace HotelHostingSystemWithCsharp
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            List<Person> guests = new List<Person>();

            Person Antonio = new Person(name: "Antonio", lastName: "Reina");
            Person Rebeca = new Person(name: "Rebeca", lastName: "Bellini");

            guests.Add(Antonio);
            guests.Add(Rebeca);

            Suite suite = new Suite(suiteType: "Premium", capacity: 2, dailyValue: 30);

            Reservation reserva = new Reservation(reservedDays: 10);
            reserva.RegisterSuite(suite);
            reserva.RegisterGuests(guests);

            Console.WriteLine($"Guests: {reserva.GetNumberGuests()}");
            Console.WriteLine($"Daily Value: {reserva.CalculateDailyValue()}");
        }
    }
}
