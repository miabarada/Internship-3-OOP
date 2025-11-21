using Internship_3_OOP.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internship_3_OOP.Classes
{
    public class FlightCrew
    {
        string name { get; }
        CrewMember pilot { get; }
        CrewMember copilot { get; }
        CrewMember stuard1 { get; }
        CrewMember stuard2 { get; }

        public FlightCrew(string name, CrewMember pilot, CrewMember copilot, CrewMember stuard1, CrewMember stuard2)
        {
            this.name = name;
            this.pilot = pilot;
            this.copilot = copilot;
            this.stuard1 = stuard1;
            this.stuard2 = stuard2;
        }

        public FlightCrew(List<CrewMember> pilots, List<CrewMember> copilots, List<CrewMember> stuards)
        {
            Console.Write("Unesi ime posade: ");
            var newName = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Odaberite nekog od ponuđenih pilota: ");
            Print.PrintList(pilots);
            Console.Write("Odabir: ");
            var nameAndSurname = InputValidation.NameAndSurnameInList(pilots);
            var selectedPilot = pilots.Where(p => p.name.ToUpper().Equals(nameAndSurname[0].ToUpper()) && p.surname.ToUpper().Equals(nameAndSurname[1].ToUpper())).FirstOrDefault();
            pilots.Remove(selectedPilot);
            Console.WriteLine();

            Console.WriteLine("Odaberite nekog od ponuđenih kopilota: ");
            Print.PrintList(copilots);
            Console.Write("Odabir: ");
            nameAndSurname = InputValidation.NameAndSurnameInList(copilots);
            var selectedCopilot = copilots.Where(p => p.name.ToUpper().Equals(nameAndSurname[0].ToUpper()) && p.surname.ToUpper().Equals(nameAndSurname[1].ToUpper())).FirstOrDefault();
            copilots.Remove(selectedCopilot);
            Console.WriteLine();

            Console.WriteLine("Odaberite nekog od ponuđenih stjuarda/stjuardesa: ");
            Print.PrintList(stuards);
            Console.Write("Odabir: ");
            nameAndSurname = InputValidation.NameAndSurnameInList(stuards);
            var selectedStuard = stuards.Where(p => p.name.ToUpper().Equals(nameAndSurname[0].ToUpper()) && p.surname.ToUpper().Equals(nameAndSurname[1].ToUpper())).FirstOrDefault();
            stuards.Remove(selectedStuard);
            Console.WriteLine();

            Console.WriteLine("Odaberite drugog stjuarda/stjuardesu: ");
            Print.PrintList(stuards);
            Console.Write("Odabir: ");
            nameAndSurname = InputValidation.NameAndSurnameInList(stuards);
            var selectedStuard2 = stuards.Where(p => p.name.ToUpper().Equals(nameAndSurname[0].ToUpper()) && p.surname.ToUpper().Equals(nameAndSurname[1].ToUpper())).FirstOrDefault();
            stuards.Remove(selectedStuard2);
            Console.WriteLine();

            name = newName;
            pilot = selectedPilot;
            copilot = selectedCopilot;
            stuard1 = selectedStuard;
            stuard2 = selectedStuard2;
        }

        public void print()
        {
            Console.WriteLine("{0} - pilot, kopilot i 2 stjuarda/stjuardese", name);
            Console.WriteLine(pilot);
            Console.WriteLine(copilot);
            Console.WriteLine(stuard1);
            Console.WriteLine(stuard2);
            Console.WriteLine();
        }
    }
}
