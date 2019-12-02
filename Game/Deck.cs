using System;
using System.Collections;
namespace Game
{
    public class Deck
    {
        //deck of cards
        private ArrayList deck = new ArrayList();

        //create all possible cards
        Card twoS = new Card("Two", "Spades", 2);
        Card twoC = new Card("Two", "Clubs", 2);
        Card twoH = new Card("Two", "Hearts", 2);
        Card twoD = new Card("Two", "Diamonds", 2);

        Card threeS = new Card("Three", "Spades", 3);
        Card threeC = new Card("Three", "Clubs", 3);
        Card threeH = new Card("Three", "Hearts", 3);
        Card threeD = new Card("Three", "Diamonds", 3);

        Card fourS = new Card("Four", "Spades", 4);
        Card fourC = new Card("Four", "Clubs", 4);
        Card fourH = new Card("Four", "Hearts", 4);
        Card fourD = new Card("Four", "Diamonds", 4);

        Card fiveS = new Card("Five", "Spades", 5);
        Card fiveC = new Card("Five", "Clubs", 5);
        Card fiveH = new Card("Five", "Hearts", 5);
        Card fiveD = new Card("Five", "Diamonds", 5);

        Card sixS = new Card("Six", "Spades", 6);
        Card sixC = new Card("Six", "Clubs", 6);
        Card sixH = new Card("Six", "Hearts", 6);
        Card sixD = new Card("Six", "Diamonds", 6);

        Card sevenS = new Card("Seven", "Spades", 7);
        Card sevenC = new Card("Seven", "Clubs", 7);
        Card sevenH = new Card("Seven", "Hearts", 7);
        Card sevenD = new Card("Seven", "Diamonds", 7);

        Card eightS = new Card("Eight", "Spades", 8);
        Card eightC = new Card("Eight", "Clubs", 8);
        Card eightH = new Card("Eight", "Hearts", 8);
        Card eightD = new Card("Eight", "Diamonds", 8);

        Card nineS = new Card("Nine", "Spades", 9);
        Card nineC = new Card("Nine", "Clubs", 9);
        Card nineH = new Card("Nine", "Hearts", 9);
        Card nineD = new Card("Nine", "Diamonds", 9);

        Card tenS = new Card("Ten", "Spades", 10);
        Card tenC = new Card("Ten", "Clubs", 10);
        Card tenH = new Card("Ten", "Hearts", 10);
        Card tenD = new Card("Ten", "Diamonds", 10);

        Card jackS = new Card("Jack", "Spades", 10);
        Card jackC = new Card("Jack", "Clubs", 10);
        Card jackH = new Card("Jack", "Hearts", 10);
        Card jackD = new Card("Jack", "Diamonds", 10);

        Card queenS = new Card("Queen", "Spades", 10);
        Card queenC = new Card("Queen", "Clubs", 10);
        Card queenH = new Card("Queen", "Hearts", 10);
        Card queenD = new Card("Queen", "Diamonds", 10);

        Card kingS = new Card("King", "Spades", 10);
        Card kingC = new Card("King", "Clubs", 10);
        Card kingH = new Card("King", "Hearts", 10);
        Card kingD = new Card("King", "Diamonds", 10);

        Card aceS = new Card("Ace", "Spades", 12);
        Card aceC = new Card("Ace", "Clubs", 12);
        Card aceH = new Card("Ace", "Hearts", 12);
        Card aceD = new Card("Ace", "Diamonds", 12);

        //add cards to deck
        public Deck()
        {
            deck.Add(twoS);
            deck.Add(twoC);
            deck.Add(twoH);
            deck.Add(twoD);
            deck.Add(threeS);
            deck.Add(threeC);
            deck.Add(threeH);
            deck.Add(threeD);
            deck.Add(fourS);
            deck.Add(fourC);
            deck.Add(fourH);
            deck.Add(fourD);
            deck.Add(fiveS);
            deck.Add(fiveC);
            deck.Add(fiveH);
            deck.Add(fiveD);
            deck.Add(sixS);
            deck.Add(sixC);
            deck.Add(sixH);
            deck.Add(sixD);
            deck.Add(sevenS);
            deck.Add(sevenC);
            deck.Add(sevenH);
            deck.Add(sevenD);
            deck.Add(eightS);
            deck.Add(eightC);
            deck.Add(eightH);
            deck.Add(eightD);
            deck.Add(nineS);
            deck.Add(nineC);
            deck.Add(nineH);
            deck.Add(nineD);
            deck.Add(tenS);
            deck.Add(tenC);
            deck.Add(tenH);
            deck.Add(tenD);
            deck.Add(jackS);
            deck.Add(jackC);
            deck.Add(jackH);
            deck.Add(jackD);
            deck.Add(queenS);
            deck.Add(queenC);
            deck.Add(queenH);
            deck.Add(queenD);
            deck.Add(kingS);
            deck.Add(kingC);
            deck.Add(kingH);
            deck.Add(kingD);
            deck.Add(aceS);
            deck.Add(aceC);
            deck.Add(aceH);
            deck.Add(aceD);
        }

        public void printDeck()
        {
            foreach (Card card in deck)
            {
                Console.WriteLine(card.ToString());
            }
        }

        public void shuffleDeck()
        {
            ArrayList shuffled = new ArrayList();
            Random random = new Random();
            int randIndex = 0;

            while (deck.Count > 0)
            {
                randIndex = random.Next(0, deck.Count);
                shuffled.Add(deck[randIndex]);
                deck.RemoveAt(randIndex);
            }

            foreach(Card card in shuffled)
            {
                deck.Add(card);
            }
        }

        public Card dealCard()
        {
            Card dealt = (Card)deck[0];
            deck.RemoveAt(0);

            return dealt;
        }

    }
}
