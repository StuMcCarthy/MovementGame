using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovementGame.Core
{
    public class GameInstance
    {
        public IGameMode GameMode { get; set; }
        public Level Level { get; set; }
        public PlayerCharacterActor PlayerCharacter { get; set; }
        public Tick GlobalTick = new Tick(10);

        public GameInstance()
        {
            GameMode = new GameModeTopDown(GlobalTick);
            PlayerCharacter = new PlayerCharacterActor(GameMode, GlobalTick);
            Level = new Level(PlayerCharacter, GlobalTick);
        }

        public void StartGame()
        {
            GlobalTick.TickTimer.Elapsed += GameInstance_TickEvent;
            GlobalTick.TickTimer.Enabled = true;
            Level.StartLevel();
        }

        private void GameInstance_TickEvent(object sender, System.Timers.ElapsedEventArgs e)
        {
            Console.WriteLine(string.Format("Game Instance Tick : {0}", DateTime.Now));
        }
    }
}
