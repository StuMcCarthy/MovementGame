using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovementGame.Core
{
    public class Level
    {
        public Tick LevelTick { get; }
        public string Name { get; set; }
        public List<IActor> ActorList { get; private set; }
        public PlayerCharacterActor PlayerCharacter { get; }

        public Level(PlayerCharacterActor player, Tick tick)
        {
            PlayerCharacter = player;
            LevelTick = tick;
            LevelTick.TickTimer.Elapsed += Level_TickEvent;
        }

        private void Level_TickEvent(object sender, System.Timers.ElapsedEventArgs e)
        {
            Console.WriteLine(string.Format("Level Tick : {0}", DateTime.Now));
        }
    }
}
