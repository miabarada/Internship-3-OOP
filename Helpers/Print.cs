using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internship_3_OOP.Helpers
{
    public class Print
    {
        public static void MainMenu()
        {
            Console.Clear();
            Console.WriteLine("1 - Putnici");
            Console.WriteLine("2 - Letovi");
            Console.WriteLine("3 - Avioni");
            Console.WriteLine("4 - Posada");
            Console.WriteLine("0 - Izlaz iz aplikacije");
            Console.WriteLine();
            Console.Write("Odabir: ");
        }

        public static void PassengerMenu()
        {
            Console.WriteLine();
            Console.WriteLine("1 - Registracija");
            Console.WriteLine("2 - Prijava");
            Console.WriteLine("0 - Povratak na prethodni izbornik");
            Console.WriteLine();
            Console.Write("Odabir: ");
        }

        public static void PassengerSubmenu()
        {
            Console.WriteLine();
            Console.WriteLine("1 - Prikaz svih letova");
            Console.WriteLine("2 - Odabir leta");
            Console.WriteLine("3 - Pretraživanje letova");
            Console.WriteLine("4 - Otkazivanje leta");
            Console.WriteLine("0 - Povratak na prethodni izbornik");
            Console.WriteLine();
            Console.Write("Odabir: ");
        }

        public static void RegisteredTravelerMenu()
        {
            Console.WriteLine();
            Console.WriteLine("\t1 - Prikaz svih letova");
            Console.WriteLine("\t2 - Odabir letova");
            Console.WriteLine("\t3 - Pretraživanje letova");
            Console.WriteLine("\t4 - Otkazivanje letova");
            Console.WriteLine("\t0 - Povratak na glavni izbornik");
            Console.WriteLine();
            Console.Write("Odabir: ");
        }

        public static void FlightCrewMenu()
        {
            Console.WriteLine();
            Console.WriteLine("1 - Prikaz svih posada");
            Console.WriteLine("2 - Kreiranje nove posade");
            Console.WriteLine("3 - Dodavanje osobe");
            Console.WriteLine("0 - Povratak na prethodni izbornik");
            Console.WriteLine();
            Console.Write("Odabir: ");
        }

        public static void PositionOptions()
        {
            Console.WriteLine("1 - pilot");
            Console.WriteLine("2 - kopilot");
            Console.WriteLine("3 - stjuard");
            Console.WriteLine("4 - stjuardesa");
        }

        public static void GenderOptions()
        {
            Console.WriteLine("1 - muški");
            Console.WriteLine("2 - ženski");
        }

        public static void CategoryOptions()
        {
            Console.WriteLine("1 - standard");
            Console.WriteLine("2 - business");
            Console.WriteLine("3 - VIP");
        }

        public static void PlaneMenu()
        {
            Console.WriteLine();
            Console.WriteLine("1 - Prikaz svih aviona");
            Console.WriteLine("2 - Dodavanje novog aviona");
            Console.WriteLine("3 - Pretraživanje aviona");
            Console.WriteLine("4 - Brisanje aviona");
            Console.WriteLine("0 - Povratak na prethodni izbornik");
            Console.WriteLine();
            Console.Write("Odabir: ");
        }

        public static void FlightMenu()
        {
            Console.WriteLine();
            Console.WriteLine("1 - Prikaz svih letova");
            Console.WriteLine("2 - Dodavanje novog leta");
            Console.WriteLine("3 - Pretraživanje letova");
            Console.WriteLine("4 - Uređivanje leta");
            Console.WriteLine("5 - Brisanje leta");
            Console.WriteLine("0 - Povratak na prethodni izbornik");
            Console.WriteLine();
            Console.Write("Odabir: ");
        }

        public static void SearchMenu()
        {
            Console.WriteLine("Pretraži po:");
            Console.WriteLine("\t1 - id-u");
            Console.WriteLine("\t2 - nazivu");
            Console.Write("Odabir: ");
        }

        public static void PrintList<U>(List<U> list)
        {
            foreach (U element in list)
                Console.WriteLine(element);

        }
    }
}
