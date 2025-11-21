using Internship_3_OOP.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internship_3_OOP.Helpers
{
    public class InputValidation
    {
        public static int ValidInteger()
        {
            int input;
            while (true)
            {
                int.TryParse(Console.ReadLine(), out input);
                if (input > 0)
                    break;

                Console.Write("Unesi broj veći od 0: ");
            }
            return input;
        }

        public static int ValidInteger(int bottom, int top)
        {
            int input;
            while (true)
            {
                int.TryParse(Console.ReadLine(), out input);
                if (input >= bottom && input <= top)
                    break;

                Console.Write("Unesi broj {0} - {1}: ", bottom, top);
            }
            return input;
        }

        public static string ValidPersonNameInput()
        {
            string name;

            while (true)
            {
                name = Console.ReadLine();

                if (name.All(char.IsLetter))
                    break;

                Console.Write("Unesi ime/prezime koje sadrži samo slova: ");
            }
            return name;
        }


        public static string[] NameAndSurnameInList(List<CrewMember> list)
        {
            string[] nameAndSurname;

            while (true)
            {
                nameAndSurname = ValidNameAndSurnameInput();

                var nameAndSurnameInList = list.Where(person =>
                    person.name.ToUpper().Equals(nameAndSurname[0].ToUpper()) &&
                    person.surname.ToUpper().Equals(nameAndSurname[1].ToUpper())
                ).ToList();

                if (nameAndSurnameInList.Count != 0)
                    break;

                Console.Write("Unesi postojećeg člana posade: ");
            }

            return nameAndSurname;
        }

            public static string NameInList(List<Plane> planes)
            {
            string name;

            while (true)
            {
                name = Console.ReadLine();

                var nameInList = planes.Where(plane => plane.name.Equals(name)).ToList();

                if (nameInList.Count != 0)
                    break;

                Console.Write("Unesi postojeće ime: ");
            }

            return name;
        }

        public static string[] ValidNameAndSurnameInput()
        {
            string[] nameAndSurname;

            while (true)
            {
                var input = Console.ReadLine();
                nameAndSurname = input.Split(" ");

                if (nameAndSurname.Length == 2)
                    break;

                Console.Write("Unesi ime i prezime u formatu 'Ime prezime': ");
            }

            return nameAndSurname;
        }

        public static DateTime ValidDateInput()
        {
            DateTime dateInput;
            while (true)
            {
                string input = Console.ReadLine();

                if (DateTime.TryParse(input, out dateInput) && dateInput <= DateTime.Now)
                    break;

                Console.Write("Neispravan unos, unesi datum do {0} u formatu YYYY-MM-DD: ", DateTime.Now.ToShortDateString());
            }
            return dateInput;
        }

        public static Guid ValidId()
        {
            Guid result;

            while (true)
            {
                string input = Console.ReadLine();

                if (Guid.TryParse(input, out result))
                    return result;

                Console.Write("Unesi valjani GUID: ");
            }
        }


        public static Guid idInList(List<Plane> planes)
        {
            Guid newId;
            while (true)
            {
                newId = ValidId();
                var idInList = planes.Where(plane => plane.id == newId).ToList();
                if (idInList.Count != 0)
                    break;

                Console.Write("Unesi postojeći id: ");
            }
            return newId;
        }
    }
}
