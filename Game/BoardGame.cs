using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    abstract class BoardGame : IGame
    {
      //protected int playersCount;
      protected List<IPlayer> players;
      protected IRules rules;
      IPlayer OpponentPlayer;
      protected bool OpponentFirst;

      public abstract IGameCondition play();
      public abstract void showWelcome();
       


    }
}
