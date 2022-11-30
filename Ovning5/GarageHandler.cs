using Ovning5.UserInterface;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace Ovning5
{
    internal class GarageHandler : IGarageHandler
    {
        private readonly IUI _ui;
        private readonly Garage<IVehicle> _garage;

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

        public void ListVehicleTypes()
        {
            var vehicleGroups = _garage.GroupBy(x => x.GetType().Name);
            foreach (var group in vehicleGroups)
            {
                _ui.Print($"{group.Key}: {group.Count()}");
            }
        }

        public void ParkVehicle()
        {
            var vehicle = VehicleFactory.GetVehicles();
            var (_, reason) = _garage.AddVehicle(vehicle.First());

            _ui.Print(reason);
        }

        public IVehicle? RetrieveVehicle()
        {
            if (_garage.Count == 0)
            {
                _ui.Print($"Det finns inga parkerade fordon");
                return default;
            }
            _ui.Print("Ange registrationsnummer: ");
            var registrationNumber = _ui.GetInput().ToUpper();
            var (result, vehicle) = _garage.GetVehicle(registrationNumber);
            if (result)
                _ui.Print($"{vehicle} har hämtats");
            else
                _ui.Print($"Fordonet med registrationsnummer {registrationNumber} hittades ej");
            return vehicle;
        }

        public void DisplayVehicleInfo()
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

        public void FindVehiclesByProperty()
        {
            if (_garage.Count == 0)
            {
                _ui.Print($"Det finns inga parkerade fordon");
                return;
            }

            //var typeGroups = _garage.GroupBy(x => x.GetType().Name);
            IEnumerable<IVehicle> vehicles = _garage;

            //var color = String.Empty;
            //var type = String.Empty;
            do
            {
                _ui.Print($"\nAntal fordon: {vehicles.Count()}");
                _ui.Print($"1. Välj färg");
                _ui.Print($"2. Välj fordonstyp");
                _ui.Print($"3. Visa fordon");
                _ui.Print($"0. Gå till huvudmenyn");
                var input = _ui.GetInput();

                switch (input)
                {
                    case "1":
                        vehicles = SelectColor(vehicles);
                        //vehicles = vehicles.Where(x => x.Color == color);
                        break;
                    case "2":
                        vehicles = SelectType(vehicles);
                        //vehicles = vehicles.Where(x => x.GetType().Name == type);
                        break;
                    case "3":
                        ShowSelectedVehicles(vehicles);
                        break;
                    case "0":

                        return;
                    default:
                        break;
                }
            } while (true);
        }

        private IEnumerable<IVehicle> SelectType(IEnumerable<IVehicle> vehicles)
        {
            var typeGroups = vehicles.GroupBy(x => x.GetType().Name);
            string[] types = new string[typeGroups.Count()];
            int result;
            var i = 1;
            foreach (var typeGroup in typeGroups)
            {
                types[i - 1] = typeGroup.Key;
                _ui.Print($"{i}. {typeGroup.Key}");
                i++;
            }

            while (true)
            {
                _ui.Print($"Ditt val: ");
                if (int.TryParse(_ui.GetInput(), out result) && (result >= 1 && result <= types.Length))
                    return vehicles.Where(v => v.GetType().Name == types[result-1]);
                else
                    _ui.Print($"Ange giltigt val (1-{types.Length}");
            }
        }

        private IEnumerable<IVehicle> SelectColor(IEnumerable<IVehicle> vehicles)
        {
            var colorGroups = vehicles.GroupBy(x => x.Color);
            string[] colors = new string[colorGroups.Count()];
            int result;
            var i = 1;
            foreach (var colorGroup in colorGroups)
            {
                colors[i - 1] = colorGroup.Key;
                _ui.Print($"{i}. {colorGroup.Key}");
                i++;
            }

            while (true)
            {
                _ui.Print($"Ditt val: ");
                if (int.TryParse(_ui.GetInput(), out result) && (result >= 1 && result <= colors.Length))
                    return vehicles.Where(v => v.Color == colors[result - 1]);
                else
                    _ui.Print($"Ange giltigt val (1-{colors.Length}");
            }
        }
        private void ShowSelectedVehicles(IEnumerable<IVehicle> vehicles)
        {
            foreach (var vehicle in vehicles)
            {
                _ui.Print(vehicle.ToString());
            };
        }
    }
}
