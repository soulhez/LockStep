using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Entitas.Game
{
	public class HelloWorldSystem : IInitializeSystem
    {
        readonly GameContext context;

        public HelloWorldSystem(Contexts contexts)
        {
            context = contexts.game;
        }

        public void Initialize()
        {
            context.CreateEntity().AddEntitasGameDebugMessage("Hello World!");
        }
	}
}