using Internship_3_OOP.Classes;

namespace Internship_3_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Writer.writeMainMenu();
            int mainInput = InputValidation.validInteger(0, 4);

            while(mainInput != 0)
            {
                if(mainInput == 1)
                {
                    Writer.writeTravelerMenu();
                }


                mainInput = InputValidation.validInteger(0, 4);
            }
        }
    }
}
