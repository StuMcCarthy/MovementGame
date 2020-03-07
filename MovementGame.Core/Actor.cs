using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MovementGame.Core
{
    public struct Rotation
    {
        public float Yaw;
        public float Pitch;
        public float Roll;
    }

    public abstract class Actor
    {
        public Vector3 Location { get; internal set; }
        public Vector3 Scale { get; private set; }
        public Rotation Rotation { get; private set; }
        public bool Visibility { get; private set; }

        public Vector3 SetLocation(Vector3 newLocation)
        {
            Location = newLocation;
            return Location;
        }
        public Vector3 SetLocation(int x, int y, int z)
        {
            Location = new Vector3 { X = x, Y = y, Z = z };
            return Location;
        }

        public Vector3 SetScale(Vector3 newScale)
        {
            Scale = newScale;
            return Scale;
        }
        public Vector3 SetScale(int x, int y, int z)
        {
            Scale = new Vector3 { X = x, Y = y, Z = z };
            return Scale;
        }

        public Rotation SetRotation(Rotation newRotation)
        {
            Rotation = newRotation;
            return Rotation;
        }
        public Rotation SetRotation(float yaw, float pitch, float roll)
        {
            Rotation = new Rotation { Yaw = yaw, Pitch = pitch, Roll = roll };
            return Rotation;
        }

        public bool SetVisibility(bool newVisibility)
        {
            Visibility = newVisibility;
            return Visibility;
        }
    }
}
