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
            System.Console.ReadLine();
            //while (true)
            //{
            //    var input = System.Console.ReadKey();
            //    switch (input.Key)
            //    {
            //        case ConsoleKey.A:
            //            actor.MoveActor(new System.Numerics.Vector3(-5, 0, 0));
            //            break;
            //        case ConsoleKey.D:
            //            actor.MoveActor(new System.Numerics.Vector3(5, 0, 0));
            //            break;
            //        case ConsoleKey.W:
            //            actor.MoveActor(new System.Numerics.Vector3(0, 5, 0));
            //            break;
            //        case ConsoleKey.S:
            //            actor.MoveActor(new System.Numerics.Vector3(0, -5, 0));
            //            break;
            //        default:
            //            break;
            //    }

            //    System.Console.WriteLine(string.Format("Actor Location: X={0},Y={1},Z={2}", actor.Location.X, actor.Location.Y, actor.Location.Z));
            //}
        }

    }
}
