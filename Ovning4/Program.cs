using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace SkalProj_Datastrukturer_Minne
{
    /*
     * Q: Hur fungerar stacken och heapen?
     * A: Stacken är en stapel kan man säga, där du bara kommer åt det som ligger högst upp. Heapen 
     * 
     * Q: Vad är Value Types resp. Reference Types och vad skiljer dem åt?
     * A: Reference Types ligger alltid på stacken, medan Value Types ligger på stacken. (De kan även 
     *    ligga på heapen om de är deklarerade i en Value Type, t ex ett fält av typen int i en Class)
     *    En Value Type håller sitt värde direkt, medan en Reference Type håller en reference till 
     *    platsen i heapen där värdet ligger.
     * 
     * 
     * Q: Följande metoder genererar olika svar, varför?
     * A: ReturnValue() deklarerar x resp y av typen int, vilket är en värdetyp. När y sätts till x kopieras värdet, så när 
     *    y sätts till 4 på nästa rad, är det bara y som påverkas. Till skillnad från ReturnValue2, som använder sig av typen 
     *    MyInt, vilket är en referenstyp, vilket innebär att när y sätts till x, ändras referensen till att peka på samma 
     *    instans som x pekar på och då följer det att när y.MyValue sätts till 4 blir även värdet av x.MyValue 4 då det är 
     *    samma instans av MyInt.
     */


    class Program
    {
        /// <summary>
        /// The main method, vill handle the menues for the program
        /// </summary>
        /// <param name="args"></param>
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("Please navigate through the menu by inputting the number \n(1, 2, 3 ,4, 0) of your choice"
                    + "\n1. Examine a List"
                    + "\n2. Examine a Queue"
                    + "\n3. Examine a Stack"
                    + "\n4. CheckParanthesis"
                    + "\n5. Recursion"
                    + "\n6. Iteration"
                    + "\n0. Exit the application");
                char input = ' '; //Creates the character input to be used with the switch-case below.
                try
                {
                    input = Console.ReadLine()![0]; //Tries to set input to the first char in an input line
                }
                catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
                {
                    Console.Clear();
                    Console.WriteLine("Please enter some input!");
                }
                switch (input)
                {
                    case '1':
                        ExamineList();
                        break;
                    case '2':
                        ExamineQueue();
                        break;
                    case '3':
                        ExamineStack();
                        break;
                    case '4':
                        CheckParanthesis();
                        break;
                    case '5':
                        Recursion();
                        break;
                    case '6':
                        Iteration();
                        break;
                    /*
                     * Extend the menu to include the recursive 
                     * and iterative exercises.
                     */
                    case '0':
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please enter some valid input (0, 1, 2, 3, 4)");
                        break;
                }
            }
        }

        /*
            IterativeOdd(3)
            result = 1;
            i = 0
            for-loop
            0 < 3 ->
                result = result + 2 // 3
                i = 1 
            1 < 3 ->
                result = result + 2 // 5
                i = 2
            2 < 3 ->
                result = result + 2 // 7
                i = 3 
            
            result == 7

            Hoppsan, verkar som vi har en bugg här. Vi får ut det n+1:e udda talet.
            For-loopen borde initialiserats med i = 1
        */
        private static void Iteration()
        {
            Console.WriteLine($"\nITERATION");
            Console.WriteLine($"Det första jämna talet: {IterativeEven(1)}");
            Console.WriteLine($"Det andra jämna talet: {IterativeEven(2)}");
            Console.WriteLine($"Det tredje jämna talet: {IterativeEven(3)}");
            Console.WriteLine($"Det tionde jämna talet: {IterativeEven(10)}");
            Console.WriteLine($"F(1): {IterativeFibbonaci(1)}");
            Console.WriteLine($"F(9): {IterativeFibbonaci(9)}");
            Console.WriteLine($"F(18): {IterativeFibbonaci(18)}");

        }

        /*
           RecursiveOdd(5)
           5 != 1 ->
           (RecursiveOdd(4) + 2)
           4 != 1 ->
           ((RecursiveOdd(3) + 2) + 2)
           3 != 1 ->
           (((RecursiveOdd(2) + 2) + 2) + 2)
           2 != 1 ->
           ((((RecursiveOdd(1) + 2) + 2) + 2) + 2)
           1 == 1 ->
           1 + 2 + 2 + 2 + 2
           return 9
        */

        private static void Recursion()
        {
            Console.WriteLine($"\nREKURSION");
            Console.WriteLine($"Det första jämna talet: {RecursiveEven(1)}");
            Console.WriteLine($"Det andra jämna talet: {RecursiveEven(2)}");
            Console.WriteLine($"Det tredje jämna talet: {RecursiveEven(3)}");
            Console.WriteLine($"Det tionde jämna talet: {RecursiveEven(10)}");
            Console.WriteLine($"F(1): {RecursiveFibbonaci(1)}");
            Console.WriteLine($"F(9): {RecursiveFibbonaci(9)}");
            Console.WriteLine($"F(18): {RecursiveFibbonaci(18)}");
        }

        /// <summary>
        /// Examines the datastructure List
        /// </summary>
        static void ExamineList()
        {
            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch statement with cases '+' and '-'
             * '+': Add the rest of the input to the list (The user could write +Adam and "Adam" would be added to the list)
             * '-': Remove the rest of the input from the list (The user could write -Adam and "Adam" would be removed from the list)
             * In both cases, look at the count and capacity of the list
             * As a default case, tell them to use only + or -
             * Below you can see some inspirational code to begin working.
            */


            /***********************************************
             * 
             *           SVAR PÅ FRÅGOR ÖVNING 4.1
             *           
             ***********************************************
             * 2. Listans kapacitet ökar när du lägger till ett nytt element till en full lista (Count == Capacity)
             * 3. Kapaciteten fördubblas (4->8->16 osv)
             * 4. Därför att utöka kapaciteten är en dyr operation. En ny array måste allokeras och alla element
             *    från den gamla arrayen kopieras till den nya.
             * 5. Nej. (Det är möjligt att minska listans kapacitet genom att anropa TrimExcess())
             * 6. När du vet exakt antal element du kommer att hantera.
             */

            List<string> theList = new List<string>();
            string input;
            char nav;
            string value;
            do
            {
                Console.WriteLine("+<sträng> för att lägga till strängen i listan. -<sträng> för att ta bort. q för att gå till huvudmenyn.");
                Console.WriteLine($"Listan håller fn. {theList.Count} element med en kapacitet av {theList.Capacity}");
                input = Console.ReadLine()!;
                nav = input[0];
                value = input.Substring(1);
                switch (nav)
                {
                    case '+':
                        theList.Add(value);
                        break;
                    case '-':
                        theList.Remove(value);
                        break;
                    case 'q':
                        return;
                    default:
                        Console.WriteLine("Använd endast \"+\" eller \"-\"");
                        break;
                }

            } while (true);
        }

        /// <summary>
        /// Examines the datastructure Queue
        /// </summary>
        static void ExamineQueue()
        {
            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch with cases to enqueue items or dequeue items
             * Make sure to look at the queue after Enqueueing and Dequeueing to see how it behaves
            */

            Queue<String> myQueue = new();
            string input;
            char nav;
            string value;
            do
            {
                Console.WriteLine("+<sträng> för att lägga strängen på stacken. - för att ta bort. q för att gå till huvudmenyn.");
                Console.Write("Val: ");
                input = Console.ReadLine()!;
                nav = input[0];
                value = input.Substring(1);

                switch (nav)
                {
                    case '+':
                        myQueue.Enqueue(value);
                        break;
                    case '-':
                        bool success = myQueue.TryDequeue(out string result);
                        if (success)
                            Console.WriteLine($"Tog bort {result} från kön."); ;
                        break;
                    case 'q':
                        return;
                    default:
                        Console.WriteLine("Använd endast \"+\" eller \"-\"");
                        break;
                }

                Console.WriteLine($"Kön håller fn. {myQueue.Count} element: ");
                foreach (string item in myQueue)
                {
                    Console.Write($"{item}  ");
                }
                Console.WriteLine();
            } while (true);
        }

        /// <summary>
        /// Examines the datastructure Stack
        /// </summary>
        static void ExamineStack()
        {
            /*
             * Loop this method until the user inputs something to exit to main menue.
             * Create a switch with cases to push or pop items
             * Make sure to look at the stack after pushing and and poping to see how it behaves
            */

            //  Övning 3.1
            //  Att använda sig av en stack för att hantera en kö
            //  är ej lämpligt efter som den sista personen blir 
            //  den första hanteras. 


            Stack<String> myStack = new();
            string input;
            char nav;
            string value;
            do
            {
                Console.Clear();
                Console.WriteLine($"Stacken inhåller fn. {myStack.Count} element: ");
                foreach (string item in myStack)
                {
                    Console.Write($"{item}  ");
                }
                Console.WriteLine("\n+<sträng> för att lägga strängen på stacken. " +
                    "\n- för att ta bort. " +
                    "\n* för att vända på strängen. " +
                    "\nq för att gå till huvudmenyn.\n");
                Console.Write("Val: ");
                input = Console.ReadLine()!;
                nav = input[0];
                value = input.Substring(1);

                switch (nav)
                {
                    case '+':
                        myStack.Push(value);
                        break;
                    case '-':
                        bool success = myStack.TryPop(out string result);
                        if (success)
                            Console.WriteLine($"Tog bort {result} från stacken."); ;
                        break;
                    case '*':
                        ReverseText(value);
                        break;
                    case 'q':
                        return;
                    default:
                        Console.WriteLine("Använd endast \"+\" eller \"-\"");
                        break;
                }
            } while (true);
        }

        /// <summary>
        /// Reverses a string using a Stack
        /// </summary>
        /// <param name="input">The string to be reversed</param>
        private static void ReverseText(string input)
        {
            var theString = new StringBuilder(input);
            var myStack = new Stack<char>();

            Console.WriteLine($"Strängen är \"{input}\"");
            foreach (Char character in input)
            {
                myStack.Push(character);
            }

            for (int i = 0; i < input.Length; i++)
            {
                theString[i] = myStack.Pop();
            }

            Console.WriteLine($"Den omvända strängen: {theString}");
            Console.WriteLine("Tryck på en tangent för gå till föregående meny.");
            Console.ReadKey();
        }

        static void CheckParanthesis()
        {
            /*
             * Use this method to check if the paranthesis in a string is Correct or incorrect.
             * Example of correct: (()), {}, [({})],  List<int> list = new List<int>() { 1, 2, 3, 4 };
             * Example of incorrect: (()]), [), {[()}],  List<int> list = new List<int>() { 1, 2, 3, 4 );
             */

            var parenthesis = new Stack<char>();
            string input = "";
            Dictionary<char, char> bracketPairs = new Dictionary<char, char>() {
                { ')', '('},
                { ']', '['},
                { '}', '{'},
            };

            Console.Clear();
            Console.Write("Skriv in en sträng: ");
            input = Console.ReadLine()!;

            foreach (char c in input)
            {
                if (bracketPairs.ContainsValue(c))
                {
                    parenthesis.Push(c);
                }
                else if (bracketPairs.ContainsKey(c))
                {
                    if (parenthesis.TryPeek(out char result))
                    {
                        if (bracketPairs[c] == result)
                        {
                            _ = parenthesis.Pop();
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Strängen \"{input}\" var ej välformad.");
                        return;
                    }
                }
            }
            if (parenthesis.Count > 0)
            {
                Console.WriteLine($"Strängen \"{input}\" var ej välformad.");

            }
            else
            {
                Console.WriteLine($"Strängen \"{input}\" var välformad.");
            }

        }
        /***********************************************
         * 
         *           SVAR PÅ FRÅGOR ÖVNING 4.6
         *           
         ***********************************************
         *
         *  De iterativa versionerna är mer minnesvänliga då de oavsett hur stor n är 
         *  (dvs hur många iterationer som behövs) använder sig av ett konstant antal
         *  variabler, till skillnad från rekursion som växer med antalet anrop.
         */

        /// <summary>
        /// Calculates the nth even number
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        static int RecursiveEven(int n)
        {
            if (n <= 0) throw new ArgumentOutOfRangeException(nameof(n), "n must be greater than 0");
            if (n == 1) return 0;
            return (RecursiveEven(n - 1) + 2);
        }

        /// <summary>
        /// Calculates F(n), the nth number in the Fibonacci series
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        static int RecursiveFibbonaci(int n)
        {
            if (n <= 0) throw new ArgumentOutOfRangeException(nameof(n), "n must be greater than 0");
            if (n == 1) return 1;
            if (n == 2) return 1;
            return RecursiveFibbonaci(n - 1) + RecursiveFibbonaci(n - 2);
        }

        /// <summary>
        /// Calculates the nth even number
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        static int IterativeEven(int n)
        {
            if (n <= 0) throw new ArgumentOutOfRangeException(nameof(n), "n must be greater than 0");
            if (n == 1) return 0;

            int result = 0;

            for (int i = 0; i < n - 1; i++)
            {
                result += 2;
            }
            return result;

        }

        /// <summary>
        /// Calculates F(n), the nth number in the Fibonacci series
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        static int IterativeFibbonaci(int n)
        {
            if (n <= 0) throw new ArgumentOutOfRangeException(nameof(n), "n must be greater than 0");
            if (n == 1) return 1;
            if (n == 2) return 1;

            int firstNumber = 1, secondNumber = 1, nextNumber = 0;

            for (int i = 2; i < n; i++)
            {
                nextNumber = firstNumber + secondNumber;
                firstNumber = secondNumber;
                secondNumber = nextNumber;
            }
            return secondNumber;
        }

    }
}
