using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;

namespace MovementGame.Core
{
    public class PlayerCharacterActor : MovementActor
    {
        public Image PlayerImage { get; private set; }

        public PlayerCharacterActor() : base()
        {

        }

        public void KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.D)
            {
                MoveActor(new Vector3(MovementSpeed, 0, 0));
            }
        }
    }
}
