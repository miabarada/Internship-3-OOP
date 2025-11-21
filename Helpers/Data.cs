using Internship_3_OOP.Classes;
using Internship_3_OOP.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internship_3_OOP.Helpers
{
    public class Data
    {
        public static List<CrewMember> CreatePilotList()
        {
            return new List<CrewMember>()
            {
                new CrewMember("Jadre", "Barada", new DateTime(1967, 7, 21), Gender.MALE, CrewPosition.PILOT),
                new CrewMember("Ante", "Antic", new DateTime(1985, 4, 12), Gender.MALE, CrewPosition.PILOT),
                new CrewMember("Marko", "Maric", new DateTime(1979, 9, 3), Gender.MALE, CrewPosition.PILOT),
                new CrewMember("Dario", "Horvat", new DateTime(1981, 1, 18), Gender.MALE, CrewPosition.PILOT),
                new CrewMember("Ivan", "Kovač", new DateTime(1975, 10, 28), Gender.MALE, CrewPosition.PILOT),
            }; 
        }

        public static List<CrewMember> CreateCopilotList()
        {
            return new List<CrewMember>()
            {
               new CrewMember("Luka", "simic", new DateTime(1992, 2, 7), Gender.MALE, CrewPosition.KOPILOT),
               new CrewMember("Nikola", "Krpan", new DateTime(1994, 6, 30), Gender.MALE, CrewPosition.KOPILOT),
               new CrewMember("Tomislav", "Grgic", new DateTime(1991, 12, 15), Gender.MALE, CrewPosition.KOPILOT),
               new CrewMember("Tea", "Majstorovic", new DateTime(1996, 3, 22), Gender.FEMALE, CrewPosition.KOPILOT),
               new CrewMember("Petar", "Bozic", new DateTime(1989, 11, 4), Gender.MALE, CrewPosition.KOPILOT),
            };
        }

        public static List<CrewMember> CreateStuardList()
        {
            return new List<CrewMember>()
            {
                new CrewMember("Ana", "Barisic", new DateTime(1998, 7, 10), Gender.FEMALE, CrewPosition.STJUARDESA),
                new CrewMember("Marina", "Novak", new DateTime(1997, 5, 18), Gender.FEMALE, CrewPosition.STJUARDESA),
                new CrewMember("Ena", "Lovric", new DateTime(2000, 9, 1), Gender.FEMALE, CrewPosition.STJUARDESA),
                new CrewMember("Karlo", "Banic", new DateTime(1995, 8, 26), Gender.MALE, CrewPosition.STJUARD),
                new CrewMember("Lucija", "Juric", new DateTime(1999, 12, 5), Gender.FEMALE, CrewPosition.STJUARDESA)
            };
        }

        public static List<FlightCrew> CreateFlightCrewList()
        {
            return new List<FlightCrew>()
            {
                new FlightCrew(
                    "Crew A",
                    new CrewMember("Jadre", "Barada", new DateTime(1967, 7, 21), Gender.MALE, CrewPosition.PILOT),
                    new CrewMember("Luka", "Simic", new DateTime(1992, 2, 7), Gender.MALE, CrewPosition.KOPILOT),
                    new CrewMember("Ana", "Barisic", new DateTime(1998, 7, 10), Gender.FEMALE, CrewPosition.STJUARDESA),
                    new CrewMember("Marina", "Novak", new DateTime(1997, 5, 18), Gender.FEMALE, CrewPosition.STJUARDESA)
                    ),

                new FlightCrew(
                    "Crew B",
                    new CrewMember("Ante", "Antic", new DateTime(1985, 4, 12), Gender.MALE, CrewPosition.PILOT),
                    new CrewMember("Nikola", "Krpan", new DateTime(1994, 6, 30), Gender.MALE, CrewPosition.KOPILOT),
                    new CrewMember("Ena", "Lovric", new DateTime(2000, 9, 1), Gender.FEMALE, CrewPosition.STJUARDESA),
                    new CrewMember("Karlo", "Banic", new DateTime(1995, 8, 26), Gender.MALE, CrewPosition.STJUARD)
                    ),

                new FlightCrew(
                    "Crew C",
                    new CrewMember("Marko", "Maric", new DateTime(1979, 9, 3), Gender.MALE, CrewPosition.PILOT),
                    new CrewMember("Tomislav", "Grgic", new DateTime(1991, 12, 15), Gender.MALE, CrewPosition.KOPILOT),
                     new CrewMember("Lucija", "Juric", new DateTime(1999, 12, 5), Gender.FEMALE, CrewPosition.STJUARD),
                    new CrewMember("Ana", "Barisic", new DateTime(1998, 7, 10), Gender.FEMALE, CrewPosition.STJUARDESA)
                    ),

                new FlightCrew(
                    "Crew D",
                    new CrewMember("Dario", "Horvat", new DateTime(1981, 1, 18), Gender.MALE, CrewPosition.PILOT),
                    new CrewMember("Tea", "Majstorovic", new DateTime(1996, 3, 22), Gender.FEMALE, CrewPosition.KOPILOT),
                    new CrewMember("Marina", "Novak", new DateTime(1997, 5, 18), Gender.FEMALE, CrewPosition.STJUARDESA),
                    new CrewMember("Karlo", "Banic", new DateTime(1995, 8, 26), Gender.MALE, CrewPosition.STJUARD)
                    ),

                new FlightCrew(
                    "Crew E",
                    new CrewMember("Ivan", "Kovac", new DateTime(1975, 10, 28), Gender.MALE, CrewPosition.PILOT),
                    new CrewMember("Petar", "Bozic", new DateTime(1989, 11, 4), Gender.MALE, CrewPosition.KOPILOT),
                    new CrewMember("Lucija", "Juric", new DateTime(1999, 12, 5), Gender.FEMALE, CrewPosition.STJUARDESA),
                    new CrewMember("Ena", "Lovric", new DateTime(2000, 9, 1), Gender.FEMALE, CrewPosition.STJUARDESA)
                    )
            };
        }

        public static List<Plane> CreatePlaneList()
        {
            return new List<Plane>
            {
                new Plane(Guid.NewGuid(), "Boeing 747", 2000, new List<Category>{Category.STANDARD, Category.BUSINESS}, 200, 112),
                new Plane(Guid.NewGuid(), "Airbus A380", 2005, new List<Category>{ Category.STANDARD, Category.BUSINESS, Category.VIP}, 300, 150),
                new Plane(Guid.NewGuid(), "Boeing 737 MAX", 2017, new List<Category>{ Category.STANDARD}, 180, 90),
                new Plane(Guid.NewGuid(), "Embraer E195", 2013, new List<Category>{ Category.STANDARD, Category.BUSINESS}, 120, 60),
                new Plane(Guid.NewGuid(), "Airbus A320neo", 2016, new List<Category>{ Category.STANDARD}, 160, 80)
            };
        }
    }
}
