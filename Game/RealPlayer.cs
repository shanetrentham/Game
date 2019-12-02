using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class RealPlayer : IPlayer
    {
        string name;       
        int level;
        Hand hand = new Hand();
    }
}
