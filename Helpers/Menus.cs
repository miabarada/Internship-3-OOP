using Internship_3_OOP.Classes;
using Internship_3_OOP.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Plane = Internship_3_OOP.Classes.Plane;

namespace Internship_3_OOP.Helpers
{
    internal class Menus
    {
        public static void FlightCrewMenu(List<FlightCrew> flightCrews, List<CrewMember> pilots, List<CrewMember> copilots, List<CrewMember> stuards)
        {
            while (true)
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

                if (input == 3)
                {
                    CrewMember newCrewMember = new CrewMember(pilots, copilots, stuards);
                    Console.WriteLine("Nova osoba uspješno dodana!");
                    Console.WriteLine();
                }
            }
        }

        public static void PlaneMenu(List<Plane> planes)
        {
            while (true)
            {
                Print.PlaneMenu();

                int input = InputValidation.ValidInteger(0, 4);
                if (input == 0)
                    return;

                if (input == 1)
                {
                    Console.WriteLine("Svi avioni:");
                    foreach (var plane in planes)
                        Console.WriteLine(plane);
                }

                if (input == 2)
                {
                    Plane newPlane = new Plane(planes);
                    Console.WriteLine("Novi avion uspješno dodan!");
                    Console.WriteLine();
                }

                if (input == 3)
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

                    if (searchInput == 2)
                    {
                        Console.WriteLine("Upiši naziv aviona:");
                        foreach (var plane in planes)
                            Console.WriteLine(plane);
                        Console.WriteLine();
                        Console.Write("Odabir: ");

                        string name = InputValidation.NameInList(planes);
                        Console.Write("Traženi avion:");
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
                        Console.WriteLine(flights.Where(flight => flight.id.Equals(id)).First());
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
                        Console.WriteLine(flights.Where(flight => flight.name.Equals(name)).First());
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

        public static void PassengerMenu(List<Passenger> passengers, List<Flight> flights, List<Plane> planes, List<FlightCrew> flightCrews)
        {
            while (true)
            {
                Print.PassengerMenu();
                var input = InputValidation.ValidInteger(0, 2);

                if (input == 0)
                    return;

                if (input == 1)
                {
                    var passenger = new Passenger(passengers);
                    Console.WriteLine("Registracija uspješna!");
                }

                if (input == 2)
                {
                    int index;

                    while (true)
                    {
                        Console.Write("Upiši email adresu: ");
                        var email = InputValidation.ValidEmailInput();
                        var passenger = passengers.Where(pass => pass.email.Equals(email)).FirstOrDefault();

                        Console.Write("Upiši lozinku: ");
                        var password = Console.ReadLine();

                        if (passenger != null && passenger.password.Equals(password))
                        {
                            index = passengers.IndexOf(passenger);
                            break;
                        }


                        Console.WriteLine("Neispravan email ili lozinka!");
                    }

                    Menus.PassengerSubmenu(index, passengers, flights, planes, flightCrews);
                }

            }
        }

        public static void PassengerSubmenu(int index, List<Passenger> passengers, List<Flight> flights, List<Plane> planes, List<FlightCrew> flightCrews)
        {
            while (true)
            {
                Print.PassengerSubmenu();
                var input = InputValidation.ValidInteger(0, 4);

                if (input == 0)
                    return;

                if (input == 1)
                {
                    Console.WriteLine("svi letovi: ");
                    foreach (var flight in passengers.ElementAt(index).reservedFlights)
                        Console.WriteLine(flight);

                }

                if (input == 2)
                {
                    var availableFlights = flights
                                            .Where(flight => flight.departureDate > DateTime.Now)
                                            .ToList();

                    Console.WriteLine("Dostupni letovi: ");
                    foreach (var flight in availableFlights)
                        Console.WriteLine(flight);

                    Console.Write("Odaberi let po id-u: ");
                    var id = InputValidation.idInList(availableFlights);
                    var selectedFlight = availableFlights.Where(flight => flight.id.Equals(id)).First();

                    Console.WriteLine();
                    Console.WriteLine("Upiši kategoriju: ");
                    foreach(var category in selectedFlight.plane.categories)
                        Console.WriteLine(category);

                    Category selectedCategory;
                    Console.WriteLine();
                    Console.Write("Odabir: ");
                    while(true)
                    {
                        var category = Console.ReadLine();
                        if (category.ToUpper().Equals("STANDARD") && selectedFlight.plane.categories.Contains(Category.STANDARD))
                        {
                            selectedCategory = Category.STANDARD;
                            break;
                        }

                        if (category.ToUpper().Equals("BUSINESS") && selectedFlight.plane.categories.Contains(Category.BUSINESS))
                        {
                            selectedCategory = Category.BUSINESS;
                            break;
                        }

                        if (category.ToUpper().Equals("VIP") && selectedFlight.plane.categories.Contains(Category.VIP))
                        {
                            selectedCategory = Category.VIP;
                            break;
                        }

                        Console.Write("Upiši neku od ponuđenih kategorija: ");
                    }

                    passengers.ElementAt(index).reservedFlights.Add((selectedFlight, selectedCategory));                    
                }

                if (input == 3)
                {
                    Print.SearchMenu();
                    var searchInput = InputValidation.ValidInteger(1, 2);

                    if (searchInput == 1)
                    {
                        var flightsOnly = passengers.ElementAt(index).reservedFlights.Select(flight => flight.Item1).ToList();
                        Console.WriteLine("Upiši id leta:");
                        foreach (var flight in flightsOnly)
                            Console.WriteLine(flight);
                        Console.WriteLine();
                        Console.Write("Odabir: ");

                        Guid id = InputValidation.idInList(flightsOnly);
                        Console.Write("Traženi let:");
                        Console.WriteLine(flightsOnly.Where(flight => flight.id.Equals(id)).First());
                    }

                    if (searchInput == 2)
                    {
                        var flightsOnly = passengers.ElementAt(index).reservedFlights.Select(flight => flight.Item1).ToList();
                        Console.WriteLine("Upiši naziv leta:");
                        foreach (var flight in flightsOnly)
                            Console.WriteLine(flight);
                        Console.WriteLine();
                        Console.Write("Odabir: ");

                        string name = InputValidation.NameInList(flightsOnly);
                        Console.Write("Traženi let:");
                        Console.WriteLine(flightsOnly.Where(flight => flight.name.Equals(name)).First());
                    }
                }

                if (input == 4)
                {
                    var flightsOnly = passengers.ElementAt(index).reservedFlights.Select(flight => flight.Item1).ToList();
                    var upcomingFlights = flightsOnly
                                            .Where(flight => flight.departureDate > DateTime.Now)
                                            .ToList();

                    Console.WriteLine("Upiši id leta:");
                    foreach (var flight in upcomingFlights)
                        Console.WriteLine(flight);
                    Console.WriteLine();
                    Console.Write("Odabir: ");

                    Guid id = InputValidation.idInList(upcomingFlights);
                    var selectedFlight = upcomingFlights.Where(flight => flight.id.Equals(id)).First();
                    var newIndex = flightsOnly.IndexOf(selectedFlight);

                    if (DateTime.Now - selectedFlight.departureDate < new TimeSpan(24, 0, 0))
                    {
                        passengers.ElementAt(index).reservedFlights.RemoveAt(newIndex);
                        Console.WriteLine("Let uspješno otkazan!");
                    }
                    else Console.WriteLine("Nije moguće obrisati let koji je unutar sljedeća 24 sata!");
                }
            }
        }
    }
}
