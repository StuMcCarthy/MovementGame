using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovementGame.Core
{
    public interface IGameMode
    {
        string Name { get; }
        Tick GameModeTick { get; }
    }

    public abstract class GameMode : IGameMode
    {
        public string Name { get; protected set; }
        public Tick GameModeTick { get; }

        public GameMode(Tick tick)
        {
            GameModeTick = tick;
            GameModeTick.TickTimer.Elapsed += GameMode_TickEvent;
        }

        private void GameMode_TickEvent(object sender, System.Timers.ElapsedEventArgs e)
        {
            Console.WriteLine(string.Format("GameMode Tick : {0}", DateTime.Now));
        }
    }
}
