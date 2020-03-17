using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace MovementGame.Core
{
    public class Tick
    {
        public Timer TickTimer { get; }

        public Tick(int tickInterval)
        {
            TickTimer = new Timer(tickInterval)
            {
                AutoReset = true
            };
        }

        public void StartTick()
        {
            TickTimer.Start();
        }
    }
}
