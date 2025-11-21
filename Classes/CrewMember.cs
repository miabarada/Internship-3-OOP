using Internship_3_OOP.Enums;
using Internship_3_OOP.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internship_3_OOP.Classes
{
    public class CrewMember
    {
        public string name { get; set; }
        public string surname { get; }
        DateTime dateOfBirth { get; }
        Gender gender { get; }
        CrewPosition position { get; }

        public CrewMember (string name, string surname, DateTime dateOfBirth, Gender gender, CrewPosition position)
        {
            this.name = name;
            this.surname = surname;
            this.dateOfBirth = dateOfBirth;
            this.gender = gender;
            this.position = position;
        }

        public CrewMember (List<CrewMember> pilots, List<CrewMember> copilots, List<CrewMember> stuards)
        {
            Console.WriteLine("Unesite podatke o novoj osobi");
            Console.Write("Ime: ");
            name = InputValidation.ValidPersonNameInput();

            Console.Write("Prezime: ");
            surname = InputValidation.ValidPersonNameInput();

            Console.Write("Datum rođenja: ");
            dateOfBirth = InputValidation.ValidDateInput();
            Console.WriteLine();

            Console.WriteLine("Odaberi spol");
            Print.GenderOptions();
            Console.Write("Odabir: ");
            var inputGender = InputValidation.ValidInteger(1, 2);
            Console.WriteLine();

            gender = Gender.MALE;
            if (inputGender == 2)
                gender = Gender.FEMALE;

            Console.WriteLine("Odaberi poziciju");
            Print.PositionOptions();
            Console.Write("Odabir: ");
            var inputPosition = InputValidation.ValidInteger(1, 4);
            Console.WriteLine();

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

        public override string ToString()
        {
            return $"{name} - {surname} - {position} - {gender} - {dateOfBirth:dd.MM.yyyy}";
        }
    }
}
