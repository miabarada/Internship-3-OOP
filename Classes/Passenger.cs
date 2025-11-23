using Internship_3_OOP.Enums;
using Internship_3_OOP.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internship_3_OOP.Classes
{
    public class Passenger
    {
        public string email { get; }
        public string password { get; }
        string name { get; }
        string surname { get; }
        DateTime dateOfBirth { get; }
        public List <(Flight, Category)> reservedFlights { get; }

        public Passenger(string email, string password, string name, string surname,  DateTime dateOfBirth, List<(Flight, Category)> reservedFlights)
        {
            this.email = email;
            this.password = password;   
            this.name = name;
            this.surname = surname;
            this.dateOfBirth = dateOfBirth;
            this.reservedFlights = reservedFlights;
        }

        public Passenger(List<Passenger> passengers)
        {
            Console.Write("Unesi ime: ");
            name = InputValidation.ValidPersonNameInput();

            Console.Write("Unesi prezime: ");
            surname = InputValidation.ValidPersonNameInput();

            Console.Write("Unesi datum rođenja: ");
            dateOfBirth = InputValidation.ValidDateInput();

            Console.Write("Unesi email adresu: ");
            email = InputValidation.ValidEmailInput();

            Console.Write("Unesi lozinku: ");
            password = Console.ReadLine();

            reservedFlights = new List<(Flight, Category)>();

            passengers.Add(new Passenger(email, password, name, surname, dateOfBirth, reservedFlights));
        }
    }
}
