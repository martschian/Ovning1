using Ovning5;
using Ovning5.UserInterface;

var garage = new Garage<IVehicle>(capacity: 20);
var ui = new ConsoleUI();
var garageHandler = new GarageHandler(ui, garage);
var manager = new Manager(ui, garageHandler);
manager.MainLoop();