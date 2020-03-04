using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovementGame.Core
{
    public struct Location
    {
        public int X;
        public int Y;
        public int Z;
    }
    public struct Scale
    {
        public float X;
        public float Y;
        public float Z;
    }
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
        public Location Location { get; set; }
        public Scale Scale { get; set; }
        public Rotation Rotation { get; set; }
        public Visibility Visibility { get; set; }
    }
}
