using Ovning5;
using Ovning5.UserInterface;

Garage<IVehicle> garage = new Garage<IVehicle>(capacity: 20);
IUI ui = new ConsoleUI();
IGarageHandler garageHandler = new GarageHandler(ui, garage);
Manager manager = new Manager(ui, garageHandler);
manager.MainLoop();