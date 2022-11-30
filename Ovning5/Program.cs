using Ovning5;
using Ovning5.UserInterface;

var garage = new Garage<Vehicle>(capacity: 20);
var carGarage = new Garage<Car>(capacity: 5);

carGarage.AddVehicle(new Car("blue", "BMW", "M3", "MAJ545", 4));
carGarage.AddVehicle(new Car("white", "Lexus", "G4", "abc123", 2));
garage.AddVehicle(new Motorcycle("black", "Harley-Davidson", "Softtail", "MML103", 4));

Console.WriteLine($"Count reported: {garage.Count}");
Console.WriteLine($"Free spaces: {garage.Capacity - garage.Count}");
Console.WriteLine($"Number of vehicles returned: {garage.Count()}");
foreach (var vehicle in garage)
{
    Console.WriteLine(vehicle);
}

var vehicleGroups = garage.GroupBy(x => x.GetType().Name);
foreach (var group in vehicleGroups)
{
    Console.WriteLine($"{group.Key}: {group.Count()}");
}

// garage.ParkVehicle(new Car());
garage.AddVehicle(new Car("brown", "Lancia", "Delta", "IJU009", 2));
garage.AddVehicle(new Car("brown", "Nissan", "Altima", "OEA232", 2));


var allVehicles = garage.GetAllVehicles();
Console.WriteLine($"Count reported: {garage.Count}");
Console.WriteLine($"Number of vehicles returned: {allVehicles.Count()}");
foreach (var vehicle in allVehicles)
{

    Console.WriteLine(vehicle);
}

garage.AddVehicle(new Car("brown", "Honda", "Civic", "auw223", 4));
garage.AddVehicle(new Car("brown", "Honda", "Accordion", "aRw193", 4));
garage.AddVehicle(new Car("brown", "Honda", "Accord", "auw193", 4));
garage.AddVehicle(new Car("brown", "Mercedes", "CLK", "HHA192", 1));
garage.AddVehicle(new Car("brown", "Lancia", "Delta", "IJU069", 2));

allVehicles = garage.GetAllVehicles();
Console.WriteLine($"Count reported: {garage.Count}");
Console.WriteLine($"Number of vehicles returned: {allVehicles.Count()}");
foreach (var vehicle in allVehicles)
{

    Console.WriteLine(vehicle);
}
var car = new Car("Silver", "Lamborghini", "Countach", "ABP420", 2);
var (result, reason) = garage.AddVehicle(car);

Console.WriteLine($"{result}: {reason}");

var res = garage.GetVehicle("AUW223");
Console.WriteLine($"Retrieved: {res}");
Console.WriteLine($"Count reported: {garage.Count}");

(result, reason) = garage.AddVehicle(car);
Console.WriteLine($"{result}: {reason}");
allVehicles = garage.GetAllVehicles();
Console.WriteLine($"Count reported: {garage.Count}");
Console.WriteLine($"Number of vehicles returned: {allVehicles.Count()}");
foreach (var vehicle in allVehicles)
{
    Console.WriteLine(vehicle);
}

Console.WriteLine($"{allVehicles.Where(x=>x.RegistrationNumber == "auw193".ToUpper()).FirstOrDefault()}");


var allBrownVehicles = garage.Where(x => x?.Color == "brown");
Console.WriteLine($"Count reported: {garage.Count}");
Console.WriteLine($"Number of brown vehicles returned: {allBrownVehicles.Count()}");
allBrownVehicles = allBrownVehicles.OfType<Car>().Where(x => x.NumberOfSeats == 1);
foreach (var vehicle in allBrownVehicles)
{
    Console.WriteLine(vehicle);
}
