string selection = "";
bool exitProgram = false;
do
{
    Console.WriteLine("Personalregister");
    Console.WriteLine("================");
    Console.WriteLine("1. Visa anställda");
    Console.WriteLine("2. Lägg till ny personal");
    Console.WriteLine("(A)vsluta programmet\n\n");

    Console.Write("Ditt val: ");
    selection = Console.ReadLine();

    switch (selection)
    {
        case "1":
            Console.WriteLine("TO-DO: Add employee");
            break;
        case "2":
            Console.WriteLine("TO-DO: Display employees");
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