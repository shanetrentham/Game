using System;
namespace Game
{
    public class Card
    {
        private string suit, name;
        private int value;


        //empty constructor
        public Card()
        {
        }
        // initialization constructor
        public Card(string name, string suit, int value)
        {
            this.name = name;
            this.suit = suit; 
            this.value = value;
        }
        //Getters for private fields
        public string getName()
        {
            return name;
        }

        public string getSuit()
        {
            return suit;
        }

        public int getValue()
        {
            return value;
        }
        public override string ToString()
        {
            return name + ": " + suit + ", " + value;
        }
    }
}
