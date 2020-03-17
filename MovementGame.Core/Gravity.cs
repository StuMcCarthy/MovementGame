using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MovementGame.Core
{
    public static class Gravity
    {
        public static void TickApplyGravity(MovementActor actorToAffect, Vector3 gravityForce)
        {
            actorToAffect.MoveActor(gravityForce);
        }
    }
}
