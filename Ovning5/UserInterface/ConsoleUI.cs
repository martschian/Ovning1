namespace Ovning5.UserInterface
{
    internal class ConsoleUI : IUI
    {
        public void ShowMainMenu()
        {
            Console.WriteLine($"1. Lista parkerade fordon");
            Console.WriteLine($"2. Lista fordonstyper");
            Console.WriteLine($"3. Parkera fordon");
            Console.WriteLine($"4. Hämta ut fordon");
            Console.WriteLine($"5. Hitta fordon");
            Console.WriteLine($"6. Sök på egenskap");
            Console.WriteLine($"7. Fyll garaget");
        }

        public ConsoleKey GetKey()
        {
            return Console.ReadKey(true).Key;
        }
    }
}
