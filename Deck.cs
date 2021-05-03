using System;
namespace csharp
{
    public class Deck
    {
        public string nameOfDeck {get; set;}
        public int numberOfCards {get; set;}
        public string typeOfDeck {get; set;}
        public int numberOfMonsters = 20;
        public int numberOfSpells = 20;
        public string[] cards {get; set;}

          public static string[] CreateDeck()
            {
                string[] cards = new string[20];
                for (int i=0; i < cards.Length; i++)
                {
                    cards[i] = "Hello";
                }
                return cards;
                
                
            } 
        public static Deck DeckCreation(Deck newDeck)
        {
            Console.WriteLine("Hello there, Player! What class would you like to be? There's the Druid, Knight, and Priest class. Please type your selection.");
            var userInput = Console.ReadLine();

            //For future builds, when verifying user input for deck choice, convert input to int and depending on the input, create
            //a specific class for that build. I.E. 2 = create new Knight();
            while (userInput != "Druid" && userInput != "Knight" && userInput != "Priest" && userInput != "druid" && userInput != "knight" && userInput != "priest")
            {
                Console.WriteLine("Please choose from the following options.\n1. Druid\n2. Knight\n3.Priest");
                userInput = Console.ReadLine();
            }
            if (userInput == "Druid" || userInput == "druid")
            {
                Deck.CreateDruidDeck(newDeck);
                return newDeck;
            }
            else if (userInput == "Knight" || userInput == "knight")
            {
                Deck.CreateKnightDeck(newDeck);
                return newDeck;
            }
            else //if (userInput == "Priest" || userInput == "priest" + (newDeck))
            {
                Deck.CreatePriestDeck(newDeck);
                return newDeck;
            }
        }
        public static void PrintToConsole(Deck newDeck)
        {
            Console.WriteLine("Creating deck...");
            //This gives a 2-3 second delay inbetween printing to the console.
            System.Threading.Thread.Sleep(2300);
            Console.WriteLine($"The name of your new deck is {newDeck.nameOfDeck}.");

            System.Threading.Thread.Sleep(2300);
            Console.WriteLine($"And the type of deck you're going to be playing is {newDeck.typeOfDeck}.");

            System.Threading.Thread.Sleep(2300);
            Console.WriteLine($"You will start off with {newDeck.numberOfCards} cards.");

            System.Threading.Thread.Sleep(2300);
            Console.WriteLine("Is this information correct?");
            var correct = Console.ReadLine();
            if (correct != "yes" && correct != "Yes" && correct != "y")
            {
                Console.WriteLine("Who hurt you?");
                Console.WriteLine("Why do you do this to me?");
                Console.WriteLine("Goodbye..");
            }

            Console.WriteLine("Thanks. Have a good one.");
        }

        public static Deck CreateDruidDeck(Deck newDeck)
        {
            newDeck.cards = new string[25];
            newDeck.numberOfCards = 25;
            newDeck.typeOfDeck = "Aggro";
            newDeck.nameOfDeck = "My first Druid deck";
            return newDeck;

        }

        public static Deck CreateKnightDeck(Deck newDeck)
        {
            newDeck.cards = new string[20];
            newDeck.numberOfCards = 20;
            newDeck.typeOfDeck = "Combo";
            newDeck.nameOfDeck = "My first Knight deck";
            return newDeck;
            
        }
        public static Deck CreatePriestDeck(Deck newDeck)
        {
            newDeck.cards = new string[15];
            newDeck.numberOfCards = 15;
            newDeck.typeOfDeck = "Hybrid";
            newDeck.nameOfDeck = "My first Priest deck";
            return newDeck;
            
        }

             
    }

    

}