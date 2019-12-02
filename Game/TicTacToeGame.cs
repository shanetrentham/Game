using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class TicTacToeGame : BoardGame
    {
        IDimension dimension;
        WinLoseDrawCondition condition;
        

        public override IGameCondition play()
        {
            showWelcome();
            chooseOpponent();
            chooseFirstPlayer();
            //start();

            return condition;
        }


        public override void showWelcome()
        {
            Console.WriteLine("Welcome to Tic Tac Toe Game!");
            Console.WriteLine("You can play against another player (Human, Computer or the stronegst one Alien)");
        }


       private IPlayer chooseOpponent()
        {
            IPlayer opponentPlayer=null;
            Console.WriteLine("Choose your opponent(Human: H, Computer: C, Alien: A):");
            char opponentType = (char)Console.Read();
            do
            {
                opponentType = (char)Console.Read();
            } while (opponentType != 'H' || opponentType != 'C' || opponentType != 'A');
            


            switch (opponentType)
            {
                case 'H':
                    {
                        opponentPlayer = new HumanPlayer();
                        break;
                    }
                case 'C':
                    {
                        opponentPlayer = new ComputerPlayer();
                        break;
                    }
                case 'A':
                    {
                        opponentPlayer = new AlienPlayer();
                        break;
                    }                
            }
            return opponentPlayer;
        }

      void chooseFirstPlayer()
        {
            Console.WriteLine("Play first?(Y/N)");
            char OpponentFirstChar = (char)Console.Read();
            do
            {
                OpponentFirstChar = (char)Console.Read();
            } while (OpponentFirstChar != 'Y' || OpponentFirstChar != 'N' || OpponentFirstChar != 'y' || OpponentFirstChar != 'n');

            this.OpponentFirst = OpponentFirstChar == 'N' || OpponentFirstChar == 'n';
        }


        /*public void start()
        {

            condition = new WinLoseDrawCondition();

        }
        */

    }
}
