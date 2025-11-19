using Internship_3_OOP.Classes;
using Internship_3_OOP.Enums;
using Internship_3_OOP.Helpers;

namespace Internship_3_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var pilots = Data.CreatePilotList();
            var copilots = Data.CreateCopilotList();
            var stjuards = Data.CreateStuardList();

            var flightCrews = Data.CreateFlightCrewList();

            Print.MainMenu();
            int mainInput = InputValidation.validInteger(0, 4);

            while(mainInput != 0)
            {
                if(mainInput == 1)
                {
                    Print.TravelerMenu();
                }

                if (mainInput == 4)
                    Menus.FlightCrewMenu(flightCrews, pilots, copilots, stjuards);

                mainInput = InputValidation.validInteger(0, 4);
            }
        }
    }
}
