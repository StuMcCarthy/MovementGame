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
        [System.Runtime.InteropServices.DllImport("User32.dll")]
        public static extern short GetAsyncKeyState(int vKey);
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
            MoveActor(GetUserMovementInput());

            Console.WriteLine(Location);
        }

        private Vector3 GetUserMovementInput()
        {
            var v = new Vector3(0);
            if (GetAsyncKeyState('A') != 0)
                v += new Vector3(-MovementSpeed, 0, 0);
            if (GetAsyncKeyState('D') != 0)
                v += new Vector3(MovementSpeed, 0, 0);
            if (GetAsyncKeyState('W') != 0)
                v += new Vector3(0, 5, 0);
            if (GetAsyncKeyState('S') != 0)
                v += new Vector3(0, -5, 0);
            return v;
        }
    }
}
