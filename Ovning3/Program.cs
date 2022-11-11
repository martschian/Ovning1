using System.Diagnostics;
using Ovning3.Encapsulation;
using Ovning3.Inheritance;
using Ovning3.Polymorphism;

namespace Ovning3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 3.1.1
            /*
            try
            {
                Person person = new Person(fName: "Ygge", lName: "Yggersson");
            }
            catch (ArgumentException ae)
            {
                Debug.WriteLine(ae.Message);
            }
            */
            #endregion

            #region 3.1.5
            try
            {
                PersonHandler personHandler = new();
                Person person = personHandler.CreatePerson(32, "Hal", "Anderton", 173, 72);
                personHandler.SetAge(person, 33);
                personHandler.SetHeight(person, 175);
            }
            catch (ArgumentNullException ane)
            {
                Console.WriteLine(ane.Message);
            }

            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }

            #endregion

            #region 3.2.7
            List<UserError> errors = new List<UserError>()
            {
                new TextInputError(),
                new NumericInputError(),
                new NumericInputError(),
                new TextInputError(),

            };
            Console.WriteLine($"{Environment.NewLine}Skriv ut samtliga UserError");

            foreach (UserError error in errors)
            {
                Console.WriteLine(error.UEMessage());
            }
            #endregion

            #region 3.2.10
            Console.WriteLine($"{Environment.NewLine}Skriv ut samtliga UserError (fler typer)");
            List<UserError> myErrors = new List<UserError>()
            {
                new TextInputError(),
                new ValueTooLargeError(),
                new DecimalInputError(),
                new NonPositiveIntegerError(),
                new NumericInputError(),
                new TextInputError(),

            };
            foreach (UserError error in myErrors)
            {
                Console.WriteLine(error.UEMessage());
            }
            #endregion

            #region Mer polymorfism 
            // 3.4.3
            List<Animal> animals = new List<Animal>()
            {
                new Bird(),
                new Dog(),
                new Horse(),
                new Wolf(),
                new Wolfman(),
                new Flamingo()
            };
            // 3.4.6
            Console.WriteLine($"{Environment.NewLine}Skriv ut typ av djur och hur de låter");
            foreach (Animal animal in animals)
            {
                // 3.4.17
                // Om jag försöker accessa metoden PlayFetch() som endast
                // finns på klassen Dog när jag använder mig av en instans-
                // variable av typen Animal kommer jag ej komma åt metoden.
                // Jag måste casta till Dog för att komma åt den klassens 
                // unika members
                // 
                // 3.4.18
                if (animal is Dog dog) Console.WriteLine(dog.PlayFetch());
                
                Console.Write(animal.GetType().Name);

                // 3.4.7
                if (animal is IPerson iPerson)
                    Console.WriteLine($" says {iPerson.Talk()}");
                else
                    Console.WriteLine($" says {animal.DoSound()}");
                
            }


            // 3.4.9
            // List<Dog> dogs = new();
            // dogs.Add(new Horse());
            // Fungerar ej för att en häst är inte en hund.

            // 3.4.10
            // För att alla klasser ska kunna lagras i samma lista måste
            // listan vara av samma typ som basklassen de ärver från. 


            // 3.4.13
            // Den mest specifika implementationen av Stats() körs
            Console.WriteLine($"{Environment.NewLine}Skriv ut Stats() alla djur");
            foreach (Animal animal in animals)
            {
                Console.WriteLine($"Stats for {animal.GetType().Name}: {animal.Stats()}");
            }

            // 3.4.14
            Console.WriteLine($"{Environment.NewLine}Skriv ut Stats() endast för hundar");
            foreach (Animal animal in animals)
            {
                
                if (animal is Dog dog) Console.WriteLine(dog.Stats());
            }

            #endregion


        }
    }
}