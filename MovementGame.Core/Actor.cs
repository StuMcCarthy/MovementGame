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

        public Rotation(float value)
        {
            Yaw = value;
            Pitch = value;
            Roll = value;
        }
        public Rotation(float yaw, float pitch, float roll)
        {
            Yaw = yaw;
            Pitch = pitch;
            Roll = roll;
        }
    }

    public abstract class Actor
    {
        #region Events
        public event EventHandler ActorSpawned;
        public event EventHandler LocationChanged;
        public event EventHandler ScaleChanged;
        public event EventHandler RotationChanged;
        public event EventHandler VisibilityChanged;

        public void RaiseActorSpawned(object sender, EventArgs e)
        {
            ActorSpawned?.Invoke(sender, e);
        }
        public void RaiseLocationChanged(object sender, EventArgs e)
        {
            LocationChanged?.Invoke(sender, e);
        }
        public void RaiseScaleChanged(object sender, EventArgs e)
        {
            ScaleChanged?.Invoke(sender, e);
        }
        public void RaiseRotationChanged(object sender, EventArgs e)
        {
            RotationChanged?.Invoke(sender, e);
        }
        public void RaiseVisibilityChanged(object sender, EventArgs e)
        {
            VisibilityChanged?.Invoke(sender, e);
        }
        #endregion

        #region Properties
        public Vector3 Location { get; internal set; }
        public Vector3 Scale { get; private set; }
        public Rotation Rotation { get; private set; }
        public bool Visibility { get; private set; }
        #endregion

        #region Constructors
        public Actor()
        {
            Location = new Vector3(0);
            Scale = new Vector3(1);
            Rotation = new Rotation(0);
            Visibility = true;
        }

        #endregion


        public void SpawnActor()
        {
            RaiseActorSpawned(this, null);
        }

        #region Setters
        public Vector3 SetLocation(Vector3 newLocation)
        {
            Location = newLocation;
            RaiseLocationChanged(Location, null);
            return Location;
        }
        public Vector3 SetLocation(float x, float y, float z)
        {
            Location = new Vector3(x,y,z);
            RaiseLocationChanged(Location, null);
            return Location;
        }

        public Vector3 SetScale(Vector3 newScale)
        {
            Scale = newScale;
            RaiseScaleChanged(Scale, null);
            return Scale;
        }
        public Vector3 SetScale(float x, float y, float z)
        {
            Scale = new Vector3(x, y, z);
            RaiseScaleChanged(Scale, null);
            return Scale;
        }

        public Rotation SetRotation(Rotation newRotation)
        {
            Rotation = newRotation;
            RaiseRotationChanged(Rotation, null);
            return Rotation;
        }
        public Rotation SetRotation(float yaw, float pitch, float roll)
        {
            Rotation = new Rotation(yaw, pitch, roll);
            RaiseRotationChanged(Rotation, null);
            return Rotation;
        }

        public bool SetVisibility(bool newVisibility)
        {
            Visibility = newVisibility;
            RaiseVisibilityChanged(Visibility, null);
            return Visibility;
        }
        #endregion
    }
}
