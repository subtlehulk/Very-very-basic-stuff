using System;

namespace csharp
{
    class Program
    {
        static void Main(string[] args)  //This is a method called "Main" and it is called when the program starts so everything must be in here that we wish to be ran when executed
        {     
            
            /*
            //Here I will create a new object of type Deck
            Deck newDeck = new Deck();

            Deck.DeckCreation(newDeck);

            Deck.PrintToConsole(newDeck);
            */
            Monster monster = new Monster();
            monster.damage();
            Spell spell = new Spell();
            spell.heal();




        }
        

       }
    }