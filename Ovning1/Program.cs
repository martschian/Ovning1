using Ovning1;

Register employees = new Register();

string selection = "";
bool exitProgram = false;
do
{
    ShowMainMenu();
    

    Console.Write("Ditt val: ");
    selection = Console.ReadLine();

    switch (selection)
    {
        case "1":
            employees.DisplayEmployees();
            break;
        case "2":
            employees.AddEmployee();
            break;
        case "a":
        case "A":
            Console.WriteLine("Hej då!");
            exitProgram = true;
            break;
        default:
            Console.WriteLine("Felaktig inmatning");
            break;
    }

} while (!exitProgram);

void ShowMainMenu()
{
    Console.WriteLine("Personalregister");
    Console.WriteLine("================");
    Console.WriteLine("1. Visa anställda");
    Console.WriteLine("2. Lägg till ny personal");
    Console.WriteLine("(A)vsluta programmet\n\n");
}