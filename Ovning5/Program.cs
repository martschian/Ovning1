using Ovning5;
using Ovning5.UserInterface;

var garage = new Garage<Vehicle>(capacity: 10);

garage.ParkVehicle(new Car("blue", "BMW", "M3", "MAJ545", 4));
garage.ParkVehicle(new Car("white", "Lexus", "G4", "abc123", 2));
garage.ParkVehicle(new Motorcycle("black", "Harley-Davidson", "Softtail", "MML103", 4));

var allVehicles = garage.GetAllVehicles();
Console.WriteLine($"Count reported: {garage.Count}");
Console.WriteLine($"Number of vehicles returned: {allVehicles.Count()}");
foreach (var vehicle in allVehicles)
{
    
    Console.WriteLine(vehicle);
}

var vehicleGroups = garage.GroupBy(x => x.GetType().Name);
foreach (var group in vehicleGroups)
{
    Console.WriteLine($"{group.Key}: {group.Count()}");
}

// garage.ParkVehicle(new Car());
garage.ParkVehicle(new Car("brown", "Lancia", "Delta", "IJU009", 2));
garage.ParkVehicle(new Car("brown", "Nissan", "Altima", "OEA232", 2));


allVehicles= garage.GetAllVehicles();
Console.WriteLine($"Count reported: {garage.Count}");
Console.WriteLine($"Number of vehicles returned: {allVehicles.Count()}");
foreach (var vehicle in allVehicles)
{

    Console.WriteLine(vehicle);
}

garage.ParkVehicle(new Car("brown", "Honda", "Civic", "auw223", 4));
garage.ParkVehicle(new Car("brown", "Honda", "Accordion", "aRw193", 4));
garage.ParkVehicle(new Car("brown", "Honda", "Accord", "auw193", 4));
garage.ParkVehicle(new Car("brown", "Mercedes", "CLK", "HHA192", 1));
garage.ParkVehicle(new Car("brown", "Lancia", "Delta", "IJU069", 2));

allVehicles = garage.GetAllVehicles();
Console.WriteLine($"Count reported: {garage.Count}");
Console.WriteLine($"Number of vehicles returned: {allVehicles.Count()}");
foreach (var vehicle in allVehicles)
{

    Console.WriteLine(vehicle);
}
var car = new Car("Silver", "Lamborghini", "Countach", "ABP420", 2);
var (result, reason) = garage.ParkVehicle(car);

Console.WriteLine($"{result}: {reason}");

var res = garage.RetrieveVehicle("AUW223");
Console.WriteLine($"Retrieved: {res}");
Console.WriteLine($"Count reported: {garage.Count}");

(result, reason) = garage.ParkVehicle(car);
Console.WriteLine($"{result}: {reason}");
allVehicles = garage.GetAllVehicles();
Console.WriteLine($"Count reported: {garage.Count}");
Console.WriteLine($"Number of vehicles returned: {allVehicles.Count()}");
foreach (var vehicle in allVehicles)
{
    Console.WriteLine(vehicle);
}


var allBrownVehicles = garage.Where(x => x?.Color == "brown");
Console.WriteLine($"Count reported: {garage.Count}");
Console.WriteLine($"Number of brown vehicles returned: {allBrownVehicles.Count()}");
allBrownVehicles = allBrownVehicles.OfType<Car>().Where(x => x.NumberOfSeats == 1);
foreach (var vehicle in allBrownVehicles)
{
    Console.WriteLine(vehicle);
}
