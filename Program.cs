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

            var planes = Data.CreatePlaneList();

            var flights = Data.CreateFlightList(planes, flightCrews);

            while(true)
            {
                Print.MainMenu();
                int mainInput = InputValidation.ValidInteger(0, 4);

                if (mainInput == 0)
                    return;

                if (mainInput == 4)
                    Menus.FlightCrewMenu(flightCrews, pilots, copilots, stjuards);

                if (mainInput == 3)
                    Menus.PlaneMenu(planes);

                if (mainInput == 2)
                    Menus.FlightMenu(flights, planes, flightCrews);
            }
        }
    }
}
