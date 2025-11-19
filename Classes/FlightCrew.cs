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
