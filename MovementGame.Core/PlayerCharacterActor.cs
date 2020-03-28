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
        public Tick CharacterTick { get; }
        public readonly IGameMode GameMode;

        private char leftKey;
        private char rightKey;
        private char upKey;
        private char downKey;

        public PlayerCharacterActor(IGameMode gameMode, Tick tickRef) : base()
        {
            GameMode = gameMode;
            CharacterTick = tickRef;
            SetKeyBindings();
        }
        private void SetKeyBindings()
        {
            var bindings = KeyBindings.GetKeyBindings(GameMode.Name);
            leftKey = bindings["West"];
            rightKey = bindings["East"];
            upKey = bindings["North"];
            downKey = bindings["South"];
        }
        public override void SpawnActor()
        {
            base.SpawnActor();
            CharacterTick.TickTimer.Elapsed += TickEvent;
        }
        private void TickEvent(object sender, ElapsedEventArgs e)
        {
            Console.WriteLine(string.Format("Player Tick : {0}", DateTime.Now));
            Console.WriteLine(Location);

            MoveActor(GetUserMovementInput());
        }
        private Vector3 GetUserMovementInput()
        {
            var v = new Vector3(0);
            if (GetAsyncKeyState(leftKey) != 0)
                v += new Vector3(-MovementSpeed, 0, 0);
            if (GetAsyncKeyState(rightKey) != 0)
                v += new Vector3(MovementSpeed, 0, 0);
            if (GetAsyncKeyState(upKey) != 0)
                v += new Vector3(0, MovementSpeed, 0);
            if (GetAsyncKeyState(downKey) != 0)
                v += new Vector3(0, -MovementSpeed, 0);
            return v;
        }
    }
}
