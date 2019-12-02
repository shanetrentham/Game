using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class HumanPlayer : RealPlayer
    {
        int age;
        Hand hand = new Hand();

        public HumanPlayer()
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
    }
}
