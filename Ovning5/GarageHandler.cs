using Ovning5.UserInterface;

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

        public void Init()
        {
            _ui.ShowMainMenu();
        }
        public void PopulateGarage(int? numberOfVehicles = null)
        {
            numberOfVehicles ??= _garage.Capacity;

            var vehicles = VehicleFactory.GetVehicles((int)numberOfVehicles);

            foreach ( var vehicle in vehicles )
            {
                _garage.AddVehicle(vehicle);
            }
        }

        public void ListAllVehicles()
        {
            foreach (var vehicle in _garage)
            {
                Console.WriteLine(vehicle);
            }
            
        }

    }
}
