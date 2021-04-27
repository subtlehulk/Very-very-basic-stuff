namespace csharp
{
    public class Deck
    {
    public string nameOfDeck {get; set;}
    public int numberOfCards {get; set;}
    public string typeOfDeck {get; set;}

    public static string[] CreateDeck()
    {
        string[] cards = new string[20];
        for (int i=0; i < cards.Length; i++)
        {
            cards[i] = "Hello";
        }
        return cards;
        
    }

    }

    /* public static string[] CreateDeck()
    {
        string[] cards = new string[20];
        for (int i = 0; i < cards.Length; i++)
        {
            cards[i] = "Hello";
        }
        return cards;

    } */

    /*public class Druid {
        public string nameOfDeck {get; set;}
        public int numberOfCards {get; set;}
        public string typeOfDeck {get; set;}
    }

    public class Knight {
        public string nameOfDeck {get; set;}
        public int numberOfCards {get; set;}
        public string typeOfDeck {get; set;}
    }

    public class Priest {
        public string nameOfDeck {get; set;}
        public int numberOfCards {get; set;}
        public string typeOfDeck {get; set;}
        
    }
    */
}