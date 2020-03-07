﻿using System;
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
        public int JumpHeight { get; private set; } = 100;
        public bool AffectedByGravity { get; private set; } = false;

        public void SetHasGravity(bool newValue)
        {
            AffectedByGravity = newValue;
        }
        public int SetJumpHeight(int newHeight)
        {
            JumpHeight = newHeight;
            return JumpHeight;
        }

        public void MoveActor(Vector3D movementForce)
        {
            Location += movementForce;
        }

        public void Jump()
        {
            Location = new Vector3D { X = Location.X, Y = Location.Y + JumpHeight, Z = Location.Z };
        }
        public void Land()
        {
            Location = new Vector3D { X = Location.X, Y = Location.Y - JumpHeight, Z = Location.Z };
        }
    }
}
