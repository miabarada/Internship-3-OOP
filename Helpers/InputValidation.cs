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
        public static int validInteger()
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

        public static int validInteger(int bottom, int top)
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

        public static string validNameInput()
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


        public static string[] nameAndSurnameInList(List<CrewMember> list)
        {
            string[] nameAndSurname;

            while (true)
            {
                nameAndSurname = validNameAndSurnameInput();

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

        public static string[] validNameAndSurnameInput()
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

        public static DateTime validDateInput()
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

    }
}
