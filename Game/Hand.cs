using System;
using System.Collections;
namespace Game
{
    public class Hand
    {
        //private Deck d
        private ArrayList cards;
        private int cardsValue;
        private Deck deck;

        public Hand()
        {
            cards = new ArrayList();
            cardsValue = 0;
        }

        public void addCard(Card card)
        {
            cards.Add(card);

        }

        public void addValue(Card card)
        {
            if (card.getName() == "Ace")
            {
                if (cardsValue < 11)
                {
                    cardsValue += 11;
                }
                else
                {
                    cardsValue += 1;
                }
            }
            else
                cardsValue += card.getValue();
        }

        public int getValue()
        {
            return cardsValue;
        }

        public override string ToString()
        {
            string output = "";
            foreach(Card card in cards)
            {
                output += card.getName() + ": " + card.getSuit() + ", " + card.getValue();
            }
            return output;
        }
    }
}
