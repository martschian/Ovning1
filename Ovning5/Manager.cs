using Ovning5.UserInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning5
{
    internal class Manager
    {
        private readonly IUI ui;
        GarageHandler _garageHandler;
        public Manager(IUI ui, GarageHandler garageHandler)
        {
            _garageHandler = garageHandler;
            this.ui = ui;
        }

        public void MainLoop()
        {
            do
            {
                ShowMainMenu();
                string input = ui.GetInput();

                switch (input.ToLower())
                {
                    case "1":
                        _garageHandler.ListAllVehicles();
                        break;
                    case "2":
                        _garageHandler.ListVehicleTypes();
                        break;
                    case "3":
                        _garageHandler.ParkVehicle();
                        break;
                    case "4":
                        _garageHandler.RetrieveVehicle();
                        break;
                    case "5":
                        _garageHandler.DisplayVehicleInfo();
                        break;
                    case "6":
                        _garageHandler.FindVehiclesByProperty();
                        break;
                    case "7":
                        _garageHandler.PopulateGarage();
                        break;
                    case "q":
                        Environment.Exit(0);
                        break;
                    default:
                        ui.Print($"Ange giltigt val, 1-7. Q för att avsluta");
                        break;

                }

            } while (true);
        }

        public void ShowMainMenu()
        {
            ui.Print($"1. Lista parkerade fordon");
            ui.Print($"2. Lista fordonstyper");
            ui.Print($"3. Parkera fordon");
            ui.Print($"4. Hämta ut fordon");
            ui.Print($"5. Hitta fordon");
            ui.Print($"6. Sök på egenskap");
            ui.Print($"7. Fyll garaget");
            ui.Print($"q. Avsluta");
        }
    }
}
