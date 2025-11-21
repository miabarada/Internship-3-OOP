using Internship_3_OOP.Classes;
using Internship_3_OOP.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                        Console.Write("Odabir: ");

                        Console.WriteLine();
                        Guid id = InputValidation.idInList(planes);
                        Console.Write("Traženi avion:");
                        Console.WriteLine(planes.Where(plane => plane.id == id).First());
                    }

                    if(searchInput == 2)
                    {
                        Console.WriteLine("Upiši id aviona:");
                        foreach (var plane in planes)
                            Console.WriteLine(plane);
                        Console.Write("Odabir: ");

                        Console.WriteLine();
                        string name = InputValidation.NameInList(planes);
                        Console.WriteLine("Traženi avion:");
                        Console.WriteLine(planes.Where(plane => plane.name == name).First());
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
                        Console.Write("Odabir: ");

                        Console.WriteLine();
                        Guid id = InputValidation.idInList(planes);
                        planes.RemoveAll(plane => plane.id == id);
                    }

                    if (deleteInput == 2)
                    {
                        Console.WriteLine("Upiši id aviona:");
                        foreach (var plane in planes)
                            Console.WriteLine(plane);
                        Console.Write("Odabir: ");

                        Console.WriteLine();
                        string name = InputValidation.NameInList(planes);
                        Console.Write("Traženi avion:");
                        planes.RemoveAll(plane => plane.name == name);
                    }
                }
            }         
            
        }
    }
}
