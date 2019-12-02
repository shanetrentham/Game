using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class ComputerPlayer : IPlayer
    {
        string level;
        Hand hand = new Hand();

        public ComputerPlayer()
        {
           
        }
        public void addCard(Card card)
        {
            hand.addCard(card);
        }
        public int getTotal()
        {
            return hand.getValue();
        }
        public void showHand()
        {
            Console.WriteLine(hand.ToString());
        }
        public void hit(Card card)
        {
            hand.addCard(card);
        }
    }
}
