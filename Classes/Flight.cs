using Internship_3_OOP.Enums;
using Internship_3_OOP.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Internship_3_OOP.Classes
{
    public class Flight
    {
        public Guid id { get; }
        public string name { get; }
        public DateTime departureDate { get; set; }
        public DateTime arrivalDate { get; set; }
        double distance { get; }
        TimeSpan durationOfTravel { get; }
        Plane plane { get; }
        public FlightCrew flightCrew { get; set; }
        int numberOfPassengers { get; }
        public double occupancy { get; }

        public Flight(Guid id, string name, DateTime departureDate, DateTime arrivalDate, double distance, Plane plane, FlightCrew flightCrew, int numberOfPassengers)
        {
            this.id = id;
            this.name = name;
            this.departureDate = departureDate;
            this.arrivalDate = arrivalDate;
            this.distance = distance;
            durationOfTravel = arrivalDate - departureDate;
            this.plane = plane;
            this.flightCrew = flightCrew;
            this.numberOfPassengers = numberOfPassengers;
            occupancy = (double)numberOfPassengers / plane.numberOfSeats;
        }

        public Flight(List<Flight> flights, List<Plane> planes, List<FlightCrew> flightCrews)
        {
            id = Guid.NewGuid();

            Console.WriteLine();
            Console.Write("Unesite mjesto polaska: ");
            var departure = Console.ReadLine();
            Console.Write("Unesite mjesto dolaska:");
            var arrival = Console.ReadLine();
            name = departure + '-' + arrival;

            Console.Write("Unesite vrijeme polaska: ");
            departureDate = InputValidation.ValidTravelDateInput();
            Console.Write("Unesite vrijeme dolaska: ");
            arrivalDate = InputValidation.ValidTravelDateInput();
            durationOfTravel = arrivalDate - departureDate;
            Console.WriteLine($"Vrijeme trajanja leta je: {durationOfTravel.Hours}h {durationOfTravel.Minutes}min");

            Console.Write("Unesite udaljenost putovanja: ");
            distance = InputValidation.ValidDouble();

            Console.WriteLine();
            Console.WriteLine("Unesi naziv nekog od postojećih aviona:");
            foreach (var plane in planes)
                Console.WriteLine(plane);
            Console.Write("Odabir: ");
            string planeName = InputValidation.NameInList(planes);
            plane = planes.Where(plane => plane.Equals(planeName)).First();

            Console.WriteLine();
            Console.WriteLine("Unesi naziv neke od postojećih posada:");
            foreach (var flightCrew in flightCrews)
                flightCrew.print();
            Console.Write("Odabir: ");
            string flightCrewName = InputValidation.NameInList(flightCrews);
            flightCrew = flightCrews.Where(crew => crew.name.Equals(flightCrewName)).First();

            flights.Add(new Flight(id, name, departureDate, arrivalDate, distance, plane, flightCrew, 0));
        }

        public override string ToString()
        {
            return $"{id} - {name} - {departureDate:dd.MM.yyyy} - {arrivalDate:dd.MM.yyyy} - {distance}  - {durationOfTravel.Hours:D2}:{durationOfTravel.Minutes:D2}";
        }
    }
}
