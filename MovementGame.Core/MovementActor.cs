using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Media3D;

namespace MovementGame.Core
{
    public class MovementActor : Actor
    {
        public bool AffectedByGravity { get; private set; } = false;

        public void SetHasGravity(bool newValue)
        {
            AffectedByGravity = newValue;
        }

        public void MoveActor(Vector3D movementForce)
        {
            Location += movementForce;
        }
    }
}
