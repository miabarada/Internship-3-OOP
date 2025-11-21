using Internship_3_OOP.Enums;
using Internship_3_OOP.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Internship_3_OOP.Classes
{
    public class Plane
    {
        public Guid id;
        public string name { get; }
        int productionYear { get; }
        List<Category> categories { get; }
        int numberOfSeats { get; }
        int numberOfFlights { get; }

        public Plane(Guid id, string name, int productionYear, List<Category> categories, int numberOfSeats, int numberOfFlights)
        {
            this.id = id;
            this.name = name;
            this.productionYear = productionYear;
            this.categories = categories;
            this.numberOfSeats = numberOfSeats;
            this.numberOfFlights = numberOfFlights;
        }

        public Plane(List<Plane> planes)
        {
            Console.WriteLine();
            Console.Write("Unesi ime aviona: ");
            name = Console.ReadLine();

            Console.Write("Unesi godinu proizvodnje: ");
            productionYear = InputValidation.ValidInteger(0, DateTime.Now.Year);
            Console.WriteLine();

            categories = new List<Category>();
            Console.WriteLine("Odaberi dostupne kategorije (upiši oznake odvojene zarezom):");
            Print.CategoryOptions();
            Console.Write("Odabir: ");
            var input = Console.ReadLine();
            var categoryNumbers = input.Split(',');
            if (categoryNumbers.Contains("1"))
                categories.Add(Category.STANDARD);
            if (categoryNumbers.Contains("2"))
                categories.Add(Category.BUSINESS);
            if (categoryNumbers.Contains("3"))
                categories.Add(Category.VIP);

            Console.Write("Unesi broj sjedala: ");
            numberOfSeats = InputValidation.ValidInteger();
            Console.WriteLine();

            numberOfFlights = 0;
            planes.Add(new Plane(Guid.NewGuid(), name, productionYear, categories, numberOfSeats, 0));
        }

        public override string ToString()
        {
            return $"{id} - {name} - {productionYear} - {numberOfFlights}";
        }
    }
}
