using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internship_3_OOP.Classes
{
    public class Writer
    {
        public static void writeMainMenu()
        {
            Console.WriteLine("1 - Putnici");
            Console.WriteLine("2 - Letovi");
            Console.WriteLine("3 - Avioni");
            Console.WriteLine("4 - Posada");
            Console.WriteLine("0 - Izlaz iz aplikacije");
            Console.WriteLine();
            Console.Write("Odabir: ");
        }

        public static void writeTravelerMenu()
        {
            Console.WriteLine("1 - Registracija");
            Console.WriteLine("2 - Prijava");
        }

        public static void writeRegisteredTravelerMenu()
        {
            Console.WriteLine("\t1 - Prikaz svih letova");
            Console.WriteLine("\t2 - Odabir letova");
            Console.WriteLine("\t3 - Pretraživanje letova");
            Console.WriteLine("\t4 - Otkazivanje letova");
            Console.WriteLine("\t5 - Povratak na glavni izbornik");
            Console.WriteLine();
            Console.Write("Odabir: ");
        }

    }
}
