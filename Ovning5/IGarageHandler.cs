namespace Ovning5
{
    internal interface IGarageHandler
    {
        void DisplayVehicleInfo();
        void FindVehiclesByProperty();
        void ListAllVehicles();
        void ListVehicleTypes();
        void ParkVehicle();
        void PopulateGarage(int? numberOfVehicles = null);
        IVehicle? RetrieveVehicle();
    }
}