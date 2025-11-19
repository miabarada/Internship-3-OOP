using Internship_3_OOP.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internship_3_OOP.Classes
{
    internal class CrewMember
    {
        string name { get; }
        string surname { get; }
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

        public void print()
        {
            Console.WriteLine("{0} - {1} - {2} - {3} - {4}", name, surname, position, gender, dateOfBirth);
        }
    }
}
