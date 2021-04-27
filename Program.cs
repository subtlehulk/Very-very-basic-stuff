using System;

namespace csharp
{
    class Program
    {
        static void Main(string[] args)  //This is a method called "Main" and it is called when the program starts so everything must be in here that we wish to be ran when executed
        {



            /*
            Console.WriteLine("Hello there, Player! What class would you like to be?");
            var userInput = Console.ReadLine();
            var newDeck = new Deck();

            //For future builds, when verifying user input for deck choice, convert input to int and depending on the input, create
            //a specific class for that build. I.E. 2 = create new Knight();
            if (userInput == "1")
            {
              newDeck.typeOfDeck = "Druid";
            }
            else if (userInput == "2")
            {
                newDeck.typeOfDeck = "Knight";
            }
            else {
                newDeck.typeOfDeck = "Priest";
            }

            

            Console.WriteLine("Please name your deck.");
            newDeck.nameOfDeck = Console.ReadLine();
            Console.WriteLine("Thank you. Now how many cards would you like to start off with? Please choose below");
            Console.WriteLine("1 = 20, 2 = 25, 3 = 30");
            var cards = Console.ReadLine();
            while (cards != "1" && cards != "2" && cards != "3")
            {
                Console.WriteLine("Please select one of the options.");
                var input = Console.ReadLine();
                Console.WriteLine("How many cards would you like to start off with? Please choose below");
                Console.WriteLine("1 = 20, 2 = 25, 3 = 30");
                if (input == "1" || input == "2" || input == "3") 
                {
                    break;
                }
            }
            if (cards == "1")
            {
                newDeck.numberOfCards = 20;
            }
            else if (cards == "2") 
            {
                newDeck.numberOfCards = 25;
            }
            else
            {
                newDeck.numberOfCards = 30;
            }

            /*Console.WriteLine("What type of deck are you wanting to play?");
            newDeck.typeOfDeck = Console.ReadLine(); 
            
            Console.WriteLine($"And the type of deck you're going to be playing is {newDeck.typeOfDeck}.");
            Console.WriteLine($"The name of your new deck is {newDeck.nameOfDeck}.");
            Console.WriteLine($"You will start off with {newDeck.numberOfCards} cards.");
            
            Console.WriteLine("Is this information correct?");
            var correct = Console.ReadLine();
            if (correct != "yes" && correct != "Yes" && correct != "y")
            {
                Console.WriteLine("Who hurt you?");
                Console.WriteLine("Why do you do this to me?");
                Console.WriteLine("Goodbye..");
            }

            Console.WriteLine("Thanks. Have a good one.");
            */
        }
    }
}
