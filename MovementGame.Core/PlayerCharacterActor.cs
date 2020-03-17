using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;
using System.Timers;

namespace MovementGame.Core
{
    public class PlayerCharacterActor : MovementActor
    {
        public Tick CharacterTick = new Tick(10);
        public PlayerCharacterActor() : base()
        {

        }

        public override void SpawnActor()
        {
            base.SpawnActor();
            CharacterTick.TickTimer.Elapsed += CharacterTick_Elapsed;
            CharacterTick.TickTimer.Enabled = true;
        }

        private void CharacterTick_Elapsed(object sender, ElapsedEventArgs e)
        {
            Console.WriteLine(DateTime.Now);
        }
    }
}
