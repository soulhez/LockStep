using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Entitas.Game
{
	public class CleanupDebugMessageSystem : ICleanupSystem
    {
        readonly GameContext context;
        readonly IGroup<GameEntity> debugMessages;

        public CleanupDebugMessageSystem(Contexts contexts)
        {
            context = contexts.game;
            debugMessages = context.GetGroup(GameMatcher.EntitasGameDebugMessage);
        }

        public void Cleanup()
        {
            foreach (var e in debugMessages.GetEntities())
            {
                e.Destroy();
            }
        }
	}
}