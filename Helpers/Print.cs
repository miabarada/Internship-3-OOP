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
            Console.WriteLine("1 - Putnici");
            Console.WriteLine("2 - Letovi");
            Console.WriteLine("3 - Avioni");
            Console.WriteLine("4 - Posada");
            Console.WriteLine("0 - Izlaz iz aplikacije");
            Console.WriteLine();
            Console.Write("Odabir: ");
        }

        public static void TravelerMenu()
        {
            Console.WriteLine("1 - Registracija");
            Console.WriteLine("2 - Prijava");
        }

        public static void RegisteredTravelerMenu()
        {
            Console.WriteLine("\t1 - Prikaz svih letova");
            Console.WriteLine("\t2 - Odabir letova");
            Console.WriteLine("\t3 - Pretraživanje letova");
            Console.WriteLine("\t4 - Otkazivanje letova");
            Console.WriteLine("\t5 - Povratak na glavni izbornik");
            Console.WriteLine();
            Console.Write("Odabir: ");
        }

        public static void FlightCrewMenu()
        {
            Console.WriteLine("1 - Prikaz svih posada");
            Console.WriteLine("2 - Kreiranje nove posade");
            Console.WriteLine("3 - Dodavanje osobe");
            Console.WriteLine("4 - Povratak na prethodni izbornik");
            Console.WriteLine();
            Console.Write("Odabir: ");
        }

        public static void Positions()
        {
            Console.WriteLine("1 - pilot");
            Console.WriteLine("2 - kopilot");
            Console.WriteLine("3 - stjuard");
            Console.WriteLine("4 - stjuardesa");
        }

        public static void Gender()
        {
            Console.WriteLine("1 - muški");
            Console.WriteLine("2 - ženski");
        }

        public static void printList<U>(List<U> list)
        {
            foreach (U element in list)
                Console.WriteLine(element);

        }
    }
}
