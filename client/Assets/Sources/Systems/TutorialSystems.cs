using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entitas.Game
{
    class TutorialSystems : Feature
    {
        public TutorialSystems(Contexts contexts) : base("Tutorial Systems")
        {
            Add(new HelloWorldSystem(contexts));
            Add(new DebugMessageSystem(contexts));
            Add(new LogMouseClickSystem(contexts));
            Add(new CleanupDebugMessageSystem(contexts));
        }
    }
}
