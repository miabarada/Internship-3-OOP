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

                var input = InputValidation.validInteger(0, 4);
                if (input == 4)
                    break;

                if (input == 1)
                    foreach (var flightCrew in flightCrews)
                        flightCrew.print();

                if (input == 2)
                {
                    Console.Write("Unesi ime posade: ");
                    var name = Console.ReadLine();
                    Console.WriteLine();

                    Console.WriteLine("Odaberite nekog od ponuđenih pilota: ");
                    Print.printList(pilots);
                    Console.Write("Odabir: ");
                    var nameAndSurname = InputValidation.nameAndSurnameInList(pilots);
                    var selectedPilot = pilots.Where(p => p.name.ToUpper().Equals(nameAndSurname[0].ToUpper()) && p.surname.ToUpper().Equals(nameAndSurname[1].ToUpper())).FirstOrDefault();
                    pilots.Remove(selectedPilot);
                    Console.WriteLine();

                    Console.WriteLine("Odaberite nekog od ponuđenih kopilota: ");
                    Print.printList(copilots);
                    Console.Write("Odabir: ");
                    nameAndSurname = InputValidation.nameAndSurnameInList(copilots);
                    var selectedCopilot = copilots.Where(p => p.name.ToUpper().Equals(nameAndSurname[0].ToUpper()) && p.surname.ToUpper().Equals(nameAndSurname[1].ToUpper())).FirstOrDefault();
                    copilots.Remove(selectedCopilot);
                    Console.WriteLine();

                    Console.WriteLine("Odaberite nekog od ponuđenih stjuarda/stjuardesa: ");
                    Print.printList(stuards);
                    Console.Write("Odabir: ");
                    nameAndSurname = InputValidation.nameAndSurnameInList(stuards);
                    var selectedStuard = stuards.Where(p => p.name.ToUpper().Equals(nameAndSurname[0].ToUpper()) && p.surname.ToUpper().Equals(nameAndSurname[1].ToUpper())).FirstOrDefault();
                    stuards.Remove(selectedStuard);
                    Console.WriteLine();

                    Console.WriteLine("Odaberite drugog stjuarda/stjuardesu: ");
                    Print.printList(stuards);
                    Console.Write("Odabir: ");
                    nameAndSurname = InputValidation.nameAndSurnameInList(stuards);
                    var selectedStuard2 = stuards.Where(p => p.name.ToUpper().Equals(nameAndSurname[0].ToUpper()) && p.surname.ToUpper().Equals(nameAndSurname[1].ToUpper())).FirstOrDefault();
                    stuards.Remove(selectedStuard2);
                    Console.WriteLine();

                    flightCrews.Add(new FlightCrew(name, selectedPilot, selectedCopilot, selectedStuard, selectedStuard2));
                }

                if(input == 3)
                {
                    Console.WriteLine("Unesite podatke o novoj osobi");
                    Console.Write("Ime: ");
                    var name = InputValidation.validNameInput();

                    Console.Write("Prezime: ");
                    var surname = InputValidation.validNameInput();
                                        
                    Console.Write("Datum rođenja: ");
                    var dateOfBirth = InputValidation.validDateInput();
                    Console.WriteLine();

                    Console.WriteLine("Odaberi spol");
                    Print.Gender();
                    Console.Write("Odabir: ");
                    var inputGender = InputValidation.validInteger(1, 2);
                    Console.WriteLine();

                    Gender gender = Gender.MALE;
                    if (inputGender == 2)
                        gender = Gender.FEMALE;

                    Console.WriteLine("Odaberi poziciju");
                    Print.Positions();
                    Console.Write("Odabir: ");
                    var inputPosition = InputValidation.validInteger(1, 4);
                    Console.WriteLine();

                    CrewPosition position;
                    if (inputPosition == 1)
                    {
                        position = CrewPosition.PILOT;
                        pilots.Add(new CrewMember(name, surname, dateOfBirth, gender, position));
                    }                        
                    if (inputPosition == 2)
                    {
                        position = CrewPosition.KOPILOT;
                        copilots.Add(new CrewMember(name, surname, dateOfBirth, gender, position));
                    }
                    if (inputPosition == 3)
                    {
                        position = CrewPosition.STJUARD;
                        stuards.Add(new CrewMember(name, surname, dateOfBirth, gender, position));
                    }
                    if (inputPosition == 4)
                    {
                        position = CrewPosition.STJUARDESA;
                        stuards.Add(new CrewMember(name, surname, dateOfBirth, gender, position));
                    }
                }
            }
        }
    }
}
