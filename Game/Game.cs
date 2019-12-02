using System;
namespace Game
{
    public class Game
    {
        private HumanPlayer human = new HumanPlayer();
        private ComputerPlayer computer = new ComputerPlayer();
        private bool computerStatus = true;
        private bool humanStatus = true;
        Deck deck = new Deck();
        private string difficulty;
        public Game(string difficulty)
        {
            this.difficulty = difficulty;
        }

        public void play()
        {
            deck.shuffleDeck();
            initHands();

            while (computerStatus && humanStatus)
            {
                computerTurn();
                humanTurn();
                statusCheck();
            }


        }
        public void initHands()
        {

            //deals alternating cards into each hand
            human.addCard(deck.dealCard());
            computer.addCard(deck.dealCard());
            human.addCard(deck.dealCard());
            computer.addCard(deck.dealCard());

        }
        //checks both players hands to see if either has busted
        public void statusCheck()
        {
            if (computer.getTotal() > 21)
            {
                Console.WriteLine("Computer Busts!");
                computerStatus = false;
            }
            else if (human.getTotal() > 21)
            {
                Console.WriteLine("Bust!");
                humanStatus = false;
            }
        }

        public void computerTurn()
        {
            if (difficulty == "1")
            {
                if (computer.getTotal() < 19)
                {
                    computer.hit(deck.dealCard());
                }
                else
                {
                    Console.WriteLine("Computer stands");
                }
            }
            else if (difficulty == "2")
            {
                if (computer.getTotal() < 17)
                {
                    computer.hit(deck.dealCard());
                }
                else
                    Console.WriteLine("Computer Stands");
            }
        }
        public void humanTurn()
        {
            Console.WriteLine("\n");
            human.showHand();
            Console.WriteLine(human.getTotal());
            Console.WriteLine("1.Hit");
            Console.WriteLine("2.Stand");
            Console.WriteLine("3.Fold");

            string choice = Console.ReadLine();

            if(choice == "1")
            {
                Console.WriteLine("Hit");
                human.addCard(deck.dealCard());
            }
            else if(choice == "2")
            {
                Console.WriteLine("Stand");
            }
            else if(choice == "3")
            {
                Console.WriteLine("Fold");
                humanStatus = false;
            }
        }
    }
}
