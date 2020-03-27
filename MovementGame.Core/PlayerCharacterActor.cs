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
        readonly GameMode GameMode;
        private char leftKey;
        private char rightKey;
        private char upKey;
        private char downKey;

        public Rectangle rectangle;
        public PlayerCharacterActor(GameMode gameMode) : base()
        {
            GameMode = gameMode;
            SetKeyBindings();
            rectangle = new Rectangle() 
            {
                X = Convert.ToInt32(Location.X),
                Y = Convert.ToInt32(Location.Y),
                Width = 50,
                Height = 50
            };
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
            UpdateRectangle();
            Console.WriteLine(string.Format("{0}, {1}", rectangle.X, rectangle.Y));
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
        private void SetKeyBindings()
        {
            var bindings = KeyBindings.GetKeyBindings(GameMode.Name);
            bindings.TryGetValue("West", out leftKey);
            bindings.TryGetValue("East", out rightKey);
            bindings.TryGetValue("North", out upKey);
            bindings.TryGetValue("South", out downKey);
        }

        private void UpdateRectangle()
        {
            rectangle.X = Convert.ToInt32(Location.X);
            rectangle.Y = Convert.ToInt32(Location.Y);
        }
    }
}
