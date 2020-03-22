using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovementGame.Core;

namespace MovementGame.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayerCharacterActor actor = new PlayerCharacterActor();
            System.Console.WriteLine(actor.Location);
            actor.SpawnActor();
            while (true)
            {

            }
        }

    }
}
