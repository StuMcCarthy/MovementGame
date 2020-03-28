using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MovementGame.Core
{
    public class MovementActor : Actor
    {
        #region Events
        public event EventHandler ActorMoved;
        public void RaiseActorMoved(object sender, EventArgs e)
        {
            ActorMoved?.Invoke(sender, e);
        }
        #endregion

        #region Properties
        public float MovementSpeed { get; protected set; } = 5;
        public float AdditionalSprintAdder { get; protected set; } = 3;
        public bool AffectedByGravity { get; private set; }
        #endregion

        #region Constructors
        public MovementActor() : base()
        {
            AffectedByGravity = false;
        }
        #endregion

        public void MoveActor(Vector3 movementForce)
        {
            Location += movementForce;
            RaiseActorMoved(Location, null);
            RaiseLocationChanged(Location, null);
        }

        public void SetMovementSpeed(float newSpeed)
        {
            MovementSpeed = newSpeed;
        }
        public void SetHasGravity(bool newValue)
        {
            AffectedByGravity = newValue;
        }
    }
}
