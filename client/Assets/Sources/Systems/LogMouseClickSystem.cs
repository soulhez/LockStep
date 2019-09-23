using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Entitas.Game
{
	public class LogMouseClickSystem : IExecuteSystem
    {
        readonly GameContext context;

        public LogMouseClickSystem(Contexts contexts)
        {
            context = contexts.game;
        }

        public void Execute()
        {
            if(Input.GetMouseButtonDown(0))
            {
                context.CreateEntity().AddEntitasGameDebugMessage("Left Mouse Button Clicked");
            }
            if(Input.GetMouseButtonDown(1))
            {
                context.CreateEntity().AddEntitasGameDebugMessage("Right Mouse Button Clicked");
            }
        }
	}
}