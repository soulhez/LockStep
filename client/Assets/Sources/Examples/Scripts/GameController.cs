using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Entitas;

namespace Entitas.Game
{
	public class GameController : MonoBehaviour 
	{
        Systems systems;

		// Use this for initialization
		void Start () 
		{
            Contexts contexts = Contexts.sharedInstance;
            systems = new Feature("Systems").Add(new TutorialSystems(contexts));
            systems.Initialize();
		}
	
		// Update is called once per frame
		void Update () 
		{
            systems.Execute();
            systems.Cleanup();
		}
	}
}