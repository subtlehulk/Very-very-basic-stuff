using System;

namespace csharp
{

    //here I am playing with interfaces. Don't think I will be using them just yet, but this is just for practice.
    public class Card
    {
        string name {get; set;}
        int manaCost {get; set;}
        //string cardText;

    }

    public class Monster : Card, IAttack
    {
        public int attack {get; set;}
        public int defense {get; set;}

        public Monster()
        {
            attack = 100;
            defense = 150;
        }
        public void damage()
        {
            int remaining = defense - attack;
            Console.WriteLine(remaining);

        }
        
    }

    public class Spell : Card, IHeal
    {
        public int healPoints {get; set;}

        public Spell ()
        {
            healPoints = 100;
        }
        public void heal()
        {
            int health = 45;
            Console.WriteLine(health + healPoints);
        }
    }

    public interface IAttack
        {
            int attack {get; set;}
            int defense {get; set;}
            void damage();
        }

    public interface IHeal
    {
        int healPoints {get; set;}

        public void heal();
    }
    

}