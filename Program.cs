using System;

namespace csharp
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            //Verifying input ==> someone's name
            Console.WriteLine("Please enter your name.");
            var userName = Console.ReadLine();
            Console.WriteLine($"Your name is {userName}, is that correct?");
            var verificationOfName = Console.ReadLine();

            
            Basic if statement
            if (verificationOfName == "yes" || verificationOfName == "Yes" || verificationOfName == "y")
            {
                Console.WriteLine("Thank you");
            } 
            else
                Console.WriteLine("Don't like to me");
            

            //Using a while loop to verifiy someone's name
            while (verificationOfName == "No" || verificationOfName == "no" || verificationOfName == "n")
            {
                Console.WriteLine("Please enter your correct name");
                var name = Console.ReadLine();
                Console.WriteLine("Is this name correct?");
                var correct = Console.ReadLine();
                if (correct == "Yes" || correct == "yes" || correct == "y") 
                {
                    break;
                }
            }
            Console.WriteLine("Thank you");
            
            string nameOne = "";
            string nameTwo = "";
            string nameThree = "";
            

            for (int i=1;i<=3; i++) {
                Console.WriteLine("What is your name?");

            }
            

            //Converting Strings into number values.
            //NOTE: Use decimals/doubles for ease of use. Will convert ints into decimals but will look like a whole integer.

            var number = "30090";
            var numberConverted = Convert.ToInt32(number);
            Console.WriteLine(numberConverted);

            var numberTwo = "30090.5";
            var numberConvertedTwo = Convert.ToDouble(numberTwo);
            Console.WriteLine(numberConvertedTwo);

            var numberThree = "30090.54568568";
            var numberConvertedThree = Convert.ToDecimal(numberThree);
            Console.WriteLine(numberConvertedThree);
            

            var apples = 100;
            var oranges = 2;
            var result = apples % oranges;

            Console.WriteLine(result);
            
            result = oranges % apples;
            
            Console.Write(result + "\n");
           
            Console.WriteLine(DateTime.Now);
            */

            Console.WriteLine("Hello there, Player! What class would you like to be?");
            var userInput = Console.ReadLine();
            var newDeck = new Deck();

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
            newDeck.typeOfDeck = Console.ReadLine(); */
            
            Console.WriteLine($"And the type of deck you're going to be playing is {newDeck.typeOfDeck}.");
            Console.WriteLine($"The name of your new deck is {newDeck.nameOfDeck}.");
            Console.WriteLine($"You will start off with {newDeck.numberOfCards} cards.");
            
            Console.WriteLine("Is this information correct?");
            var correct = Console.ReadLine();
            if (correct != "yes" && correct != "Yes")
            {
                Console.WriteLine("Who hurt you?");
                Console.WriteLine("Why do you do this to me?");
                Console.WriteLine("Goodbye..");
            }

            Console.WriteLine("Thanks. Have a good one.");

        }
    }
}
