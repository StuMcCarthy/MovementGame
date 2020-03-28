using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovementGame.Core
{
    public class GameModeTopDown : GameMode
    {
        public GameModeTopDown(Tick tick) : base(tick)
        {
            Name = "TopDown";
        }
    }
}
