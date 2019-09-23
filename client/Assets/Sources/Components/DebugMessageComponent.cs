using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Entitas;

namespace Entitas.Game
{
    [Game]
    public class DebugMessageComponent : IComponent
    {
        public string message;
    }
}