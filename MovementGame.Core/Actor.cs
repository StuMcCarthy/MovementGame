using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Media3D;

namespace MovementGame.Core
{
    public struct Rotation
    {
        public float Yaw;
        public float Pitch;
        public float Roll;
    }
    public enum Visibility
    {
        Visible,
        Hidden
    }

    public abstract class Actor
    {
        public Vector3D Location { get; set; }
        public Vector3D Scale { get; private set; }
        public Rotation Rotation { get; private set; }
        public Visibility Visibility { get; private set; }

        public Vector3D SetLocation(Vector3D newLocation)
        {
            Location = newLocation;
            return Location;
        }
        public Vector3D SetLocation(int x, int y, int z)
        {
            Location = new Vector3D { X = x, Y = y, Z = z };
            return Location;
        }

        public Vector3D SetScale(Vector3D newScale)
        {
            Scale = newScale;
            return Scale;
        }
        public Vector3D SetScale(int x, int y, int z)
        {
            Scale = new Vector3D { X = x, Y = y, Z = z };
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

        public Visibility SetVisibility(Visibility newVisibility)
        {
            Visibility = newVisibility;
            return Visibility;
        }
    }
}
