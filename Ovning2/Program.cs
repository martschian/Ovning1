namespace Ovning2
{
    public class Program
    {
        static void Main(string[] args)
        {
            ShowMainMenu();
        }
        /// <summary>
        /// Prints text-based menu to console and handles selection
        /// </summary>
        private static void ShowMainMenu()
        {
            bool showMainMenu = true;

            while (showMainMenu)
            {

                Console.WriteLine("Huvudmeny Bio Lex");
                Console.WriteLine("=================");
                Console.WriteLine();
                Console.WriteLine("Gör val nedan...");
                Console.WriteLine();
                Console.WriteLine("1. Köp en (1) biljett");
                Console.WriteLine("2. Köp flera biljetter");
                Console.WriteLine("3. Kul med ord!");
                Console.WriteLine("4. Mer kul med ord!");
                Console.WriteLine("0. Avsluta program");
                Console.Write("Val: ");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        SelectTicketType();
                        break;
                    case "2":
                        BuyGroupTickets();
                        break;
                    case "3":
                        PrintRepeatDie();
                        break;
                    case "4":
                        PrintThirdWord();
                        break;
                    case "0":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Ej giltigt val.");
                        break;
                }
            }
        }
        /// <summary>
        /// Reads a sentence from readline and prints the third word to the console.
        /// </summary>
        private static void PrintThirdWord()
        {
            Console.WriteLine("Skriv en mening med minst tre ord.");
            Console.Write("Mening: ");
            string? input = Console.ReadLine();
            var words = input?.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            if (words != null)
            {
                if (words.Length < 3)
                    Console.WriteLine("Ange TRE ord!!");
                else
                    Console.WriteLine(words[2]);
            }
        }
        /// <summary>
        /// Reads an arbitrary string from readline and prints it to the console ten times
        /// </summary>
        private static void PrintRepeatDie()
        {
            Console.WriteLine("Skriv in en godtycklig sträng:");
            Console.Write("Sträng: ");
            var input = Console.ReadLine();

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{i + 1}. {input} ");
            }
        }
        /// <summary>
        /// Method for selecting multiple tickets
        /// </summary>
        private static void BuyGroupTickets()
        {
            int totalCost = 0;

            Console.WriteLine("Hur stor är gruppen? (Ange nedan.)");
            Console.Write("Antal deltagare: ");

            bool numberIsValid = int.TryParse(Console.ReadLine(), out int result);

            if (numberIsValid)
            {
                for (int i = 0; i < result; i++)
                {
                    totalCost += SelectTicketType();                    
                }
            }

            Console.WriteLine($"Totalkostnaden för {result} biljetter är {totalCost}");
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns>The ticket price</returns>
        public static int SelectTicketType()
        {
            bool ageIsValid = false;
            int ticketPrice = 0;

            do
            {
                Console.WriteLine("Hur gammal är besökaren? (Ange nedan.)");
                Console.Write("Ålder: ");

                ageIsValid = int.TryParse(Console.ReadLine(), out int age);

                if (ageIsValid)
                {
                    if (age > 100 || age < 5)
                    {
                        Console.WriteLine("Bebisar och hundraåringar går gratis!");
                        ticketPrice = 0;
                    }
                    else if (age < 20)
                    {
                        Console.WriteLine("Ungdomspris: 80kr");
                        ticketPrice = 80;
                    }
                    else if (age > 64)
                    {
                        Console.WriteLine("Pensionärspris: 90kr");
                        ticketPrice = 90;
                    }
                    else
                    {
                        Console.WriteLine("Standardpris: 120kr");
                        ticketPrice = 120;
                    }
                }
            } while (!ageIsValid);
            
            return ticketPrice;
        }
    }
}