using Internship_3_OOP.Classes;
using Internship_3_OOP.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Plane = Internship_3_OOP.Classes.Plane;

namespace Internship_3_OOP.Helpers
{
    internal class Menus
    {
        public static void FlightCrewMenu(List<FlightCrew> flightCrews, List<CrewMember> pilots, List<CrewMember> copilots, List<CrewMember> stuards)
        {             
            while(true)
            {
                Print.FlightCrewMenu();

                var input = InputValidation.ValidInteger(0, 3);
                if (input == 0)
                    return;

                if (input == 1)
                    foreach (var flightCrew in flightCrews)
                        flightCrew.print();

                if (input == 2)
                {
                    FlightCrew newFlightCrew = new FlightCrew(pilots, copilots, stuards);
                    flightCrews.Add(newFlightCrew);
                    Console.WriteLine("Nova posada uspješno dodana!");
                    Console.WriteLine();
                }

                if(input == 3)
                {
                    CrewMember newCrewMember = new CrewMember(pilots, copilots, stuards);
                    Console.WriteLine("Nova osoba uspješno dodana!");
                    Console.WriteLine();
                }
            }
        }

        public static void PlaneMenu(List<Plane> planes)
        {
            while(true)
            {
                Print.PlaneMenu();

                int input = InputValidation.ValidInteger(0, 4);
                if (input == 0)
                    return;

                if(input == 1)
                {
                    Console.WriteLine("Svi avioni:");
                    foreach(var plane in planes)
                        Console.WriteLine(plane);
                } 

                if(input == 2)
                {
                    Plane newPlane = new Plane(planes);
                    Console.WriteLine("Novi avion uspješno dodan!");
                    Console.WriteLine();
                }

                if(input == 3)
                {
                    Print.SearchMenu();
                    var searchInput = InputValidation.ValidInteger(1, 2);

                    if (searchInput == 1)
                    {
                        Console.WriteLine("Upiši id aviona:");
                        foreach (var plane in planes)
                            Console.WriteLine(plane);
                        Console.WriteLine();
                        Console.Write("Odabir: ");

                        Guid id = InputValidation.idInList(planes);
                        Console.Write("Traženi avion:");
                        Console.WriteLine(planes.Where(plane => plane.id.Equals(id)).First());
                    }

                    if(searchInput == 2)
                    {
                        Console.WriteLine("Upiši naziv aviona:");
                        foreach (var plane in planes)
                            Console.WriteLine(plane);
                        Console.WriteLine();
                        Console.Write("Odabir: ");

                        string name = InputValidation.NameInList(planes);
                        Console.WriteLine("Traženi avion:");
                        Console.WriteLine(planes.Where(plane => plane.name.Equals(name)).First());
                    }
                }

                if (input == 4)
                {
                    Print.SearchMenu();
                    var deleteInput = InputValidation.ValidInteger(1, 2);

                    if (deleteInput == 1)
                    {
                        Console.WriteLine("Upiši id aviona:");
                        foreach (var plane in planes)
                            Console.WriteLine(plane);
                        Console.WriteLine();
                        Console.Write("Odabir: ");

                        Guid id = InputValidation.idInList(planes);
                        planes.RemoveAll(plane => plane.id.Equals(id));
                        Console.WriteLine("Let uspješno izbrisan!");
                    }

                    if (deleteInput == 2)
                    {
                        Console.WriteLine("Upiši naziv aviona:");
                        foreach (var plane in planes)
                            Console.WriteLine(plane);
                        Console.WriteLine();
                        Console.Write("Odabir: ");

                        string name = InputValidation.NameInList(planes);
                        planes.RemoveAll(plane => plane.name.Equals(name));
                        Console.WriteLine("Let uspješno izbrisan!");
                    }
                }
            }         
            
        }

        public static void FlightMenu(List<Flight> flights, List<Plane> planes, List<FlightCrew> flightCrews)
        {
            while (true)
            {
                Print.FlightMenu();
                var input = InputValidation.ValidInteger(0, 5);

                if (input == 0)
                    return;

                if (input == 1)
                {
                    Console.WriteLine("Svi letovi:");
                    foreach (var flight in flights)
                        Console.WriteLine(flight);
                }

                if (input == 2)
                {
                    Flight newFlight = new Flight(flights, planes, flightCrews);
                    Console.WriteLine("Novi let uspješno dodan!");
                    Console.WriteLine();
                }

                if (input == 3)
                {
                    Print.SearchMenu();
                    var searchInput = InputValidation.ValidInteger(1, 2);

                    if (searchInput == 1)
                    {
                        Console.WriteLine("Upiši id leta:");
                        foreach (var flight in flights)
                            Console.WriteLine(flight);
                        Console.WriteLine();
                        Console.Write("Odabir: ");

                        Guid id = InputValidation.idInList(flights);
                        Console.Write("Traženi let:");
                        Console.WriteLine(flights.Where(flight => flight.Equals(id)).First());
                    }

                    if (searchInput == 2)
                    {
                        Console.WriteLine("Upiši naziv leta:");
                        foreach (var flight in flights)
                            Console.WriteLine(flight);
                        Console.WriteLine();
                        Console.Write("Odabir: ");

                        string name = InputValidation.NameInList(flights);
                        Console.WriteLine("Traženi let:");
                        Console.WriteLine(flights.Where(flight => flight.Equals(name)).First());
                    }
                }

                if (input == 4)
                {
                    Console.WriteLine("Upiši id leta:");
                    foreach (var flight in flights)
                        Console.WriteLine(flight);
                    Console.WriteLine();
                    Console.Write("Odabir: ");

                    Guid id = InputValidation.idInList(flights);
                    Console.Write("Unesi novo vrijeme polaska: ");
                    var newDepartureDate = InputValidation.ValidTravelDateInput();
                    Console.Write("Unesi novo vrijeme dolaska: ");
                    var newArrivalDate = InputValidation.ValidTravelDateInput();

                    Console.WriteLine();
                    Console.WriteLine("Unesi naziv neke od postojećih posada:");
                    foreach (var flightCrew in flightCrews)
                        flightCrew.print();
                    Console.Write("Odabir: ");
                    string flightCrewName = InputValidation.NameInList(flightCrews);
                    var newFlightCrew = flightCrews.Where(crew => crew.name.Equals(flightCrewName)).First();

                    flights.Where(flight => flight.id.Equals(id)).First().departureDate = newDepartureDate;
                    flights.Where(flight => flight.id.Equals(id)).First().arrivalDate = newArrivalDate;
                    flights.Where(flight => flight.id.Equals(id)).First().flightCrew = newFlightCrew;

                    Console.WriteLine("Let uspješno uređen!");
                }

                if (input == 5)
                {
                    Console.WriteLine("Upiši id leta:");
                    foreach (var flight in flights)
                        Console.WriteLine(flight);
                    Console.WriteLine();
                    Console.Write("Odabir: ");

                    Guid id = InputValidation.idInList(flights);
                    var flightToDelete = flights.Where(flight => flight.id.Equals(id)).First();

                    if (DateTime.Now - flightToDelete.departureDate >= new TimeSpan(24, 0, 0) && flightToDelete.occupancy < 0.5)
                    {
                        flights.Remove(flightToDelete);
                        Console.WriteLine("Let uspješno izbrisan!");
                    }
                    else Console.WriteLine("Nije moguće izbrisati let!");

                }
            }
        }
    }
}
