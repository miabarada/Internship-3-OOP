using Internship_3_OOP.Enums;
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

        public override string ToString()
        {
            return $"{name} - {surname} - {position} - {gender} - {dateOfBirth:dd.MM.yyyy}";
        }
    }
}
