using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Entitas;

namespace Entitas.Game
{
	public class DebugMessageSystem : ReactiveSystem<GameEntity>
    {
        protected DebugMessageSystem(IContext<GameEntity> context) : base(context)
        {

        }

        public DebugMessageSystem(Contexts contexts) : base(contexts.game)
        {

        }

        protected override void Execute(List<GameEntity> entities)
        {
            foreach (var e in entities)
            {
                Debug.Log(e.entitasGameDebugMessage.message);
            }
        }

        protected override bool Filter(GameEntity entity)
        {
            return entity.hasEntitasGameDebugMessage;
        }

        protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
        {
            return context.CreateCollector(GameMatcher.EntitasGameDebugMessage);
        }
	}
}