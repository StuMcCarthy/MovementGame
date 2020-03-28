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

        #region Player Keys
        private char leftKey;
        private char rightKey;
        private char upKey;
        private char downKey;
        private char sprintKey;
        #endregion

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
            sprintKey = bindings["Sprint"];
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
            var speed = GetInputSpeed();
            var v = new Vector3(0);
            if (GetAsyncKeyState(leftKey) != 0)
                v += new Vector3(-speed, 0, 0);
            if (GetAsyncKeyState(rightKey) != 0)
                v += new Vector3(speed, 0, 0);
            if (GetAsyncKeyState(upKey) != 0)
                v += new Vector3(0, speed, 0);
            if (GetAsyncKeyState(downKey) != 0)
                v += new Vector3(0, -speed, 0);
            return v;
        }
        private float GetInputSpeed()
        {
            if (GetAsyncKeyState(sprintKey) != 0)
                return MovementSpeed + AdditionalSprintAdder;
            return MovementSpeed;
        }
    }
}
