using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internship_3_OOP.Classes
{
    public class InputValidation
    {
        public static int validInteger()
        {
            int input;
            while(true)
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
    }
}
