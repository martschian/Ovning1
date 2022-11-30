using Ovning5.UserInterface;
using System.Text.RegularExpressions;

namespace Ovning5
{
    internal class GarageHandler
    {
        private readonly IUI _ui;
        private Garage<IVehicle> _garage;

        public GarageHandler(IUI ui, Garage<IVehicle> garage)
        {
            _ui = ui;
            _garage = garage;
        }


        public void PopulateGarage(int? numberOfVehicles = null)
        {
            numberOfVehicles ??= _garage.Capacity;

            var vehicles = VehicleFactory.GetVehicles((int)numberOfVehicles);

            foreach (var vehicle in vehicles)
            {
                _garage.AddVehicle(vehicle);
            }
        }

        public void ListAllVehicles()
        {
            if (_garage.Count == 0)
            {
                _ui.Print($"Det finns inga parkerade fordon");
                return;
            }                
            
            foreach (var vehicle in _garage)
            {
                _ui.Print(vehicle.ToString());
            }

        }

        internal void ListVehicleTypes()
        {
            var vehicleGroups = _garage.GroupBy(x => x.GetType().Name);
            foreach (var group in vehicleGroups)
            {
                _ui.Print($"{group.Key}: {group.Count()}");
            }
        }

        internal void ParkVehicle()
        {
            var vehicle = VehicleFactory.GetVehicles();
            var (_, reason) = _garage.AddVehicle(vehicle.First());

            _ui.Print(reason);
        }

        internal void RetrieveVehicle()
        {
            if (_garage.Count == 0)
            {
                _ui.Print($"Det finns inga parkerade fordon");
                return;
            }
            _ui.Print("Ange registrationsnummer: ");
            var registrationNumber = _ui.GetInput().ToUpper();
            var (result, vehicle) = _garage.GetVehicle(registrationNumber);
            if (result)
                _ui.Print($"{vehicle} har hämtats");
            else
                _ui.Print($"Fordonet med registrationsnummer {registrationNumber} hittades ej");
        }

        internal void DisplayVehicleInfo()
        {
            if (_garage.Count == 0)
            {
                _ui.Print($"Det finns inga parkerade fordon");
                return;
            }
            _ui.Print("Ange registrationsnummer: ");
            var registrationNumber = _ui.GetInput().ToUpper();
            var (result, index) = _garage.FindVehicle(registrationNumber);
            if (result)
                _ui.Print($"Fordonet med registrationsnummer {registrationNumber} står på parkeringplats {index}");
            else
                _ui.Print($"Fordonet med registrationsnummer {registrationNumber} hittades ej");
        }

        internal void FindVehiclesByProperty()
        {
            if (_garage.Count == 0)
            {
                _ui.Print($"Det finns inga parkerade fordon");
                return;
            }
            
            var typeGroups = _garage.GroupBy(x => x.GetType().Name);

            var color = String.Empty;
            var type = String.Empty;
            
            _ui.Print($"1. Välj färg");
            _ui.Print($"2. Välj fordonstyp");
            _ui.Print($"3. Visa fordon");
            var input = _ui.GetInput();

            switch (input)
            {
                case "1":
                    SelectColor();
                    break;
                case "2":
                    foreach (var typeGroup in typeGroups)
                    {
                        _ui.Print($"{typeGroup.Key}");
                    }
                    break;
                default:
                    break;
            }

        }

        private string SelectColor()
        {
            var colorGroups = _garage.GroupBy(x => x.Color);
            string[] colors  = new string[colorGroups.Count()];
            var i = 1;
            foreach (var colorGroup in colorGroups)
            {
                colors[i-1] = colorGroup.Key;   
                _ui.Print($"{i} {colorGroup.Key}");
                i++;
            }
            return colors[int.Parse(_ui.GetInput())-1];

            
        }
    }
}
