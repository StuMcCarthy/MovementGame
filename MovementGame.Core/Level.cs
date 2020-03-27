using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovementGame.Core
{
    public class Level
    {
        #region Events
        public event EventHandler ActorAdded;
        public void RaiseActorAdded(object sender, EventArgs e)
        {
            ActorAdded?.Invoke(sender, e);
        }
        #endregion

        public List<Actor> ActorList { get; private set; }
        public PlayerCharacterActor PlayerCharacter { get; }

        public Level()
        {
            ActorList = new List<Actor>();
            PlayerCharacter = new PlayerCharacterActor(new GameModeTopDown());
        }

        public void AddNewActor(Actor actor)
        {
            ActorList.Add(actor);
            RaiseActorAdded(ActorList, null);
        }
    }
}
