using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class WinLoseDrawCondition : IGameCondition
    {
        int result;

        public WinLoseDrawCondition(int result)
        {
            this.result=result;
        }
    }
}
