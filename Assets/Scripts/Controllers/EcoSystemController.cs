using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using EcoSystem.Models;

namespace EcoSystem.Controllers
{
	public class EcoSystemController : MonoBehaviour
	{
		#region Members

		private const string SIMULATION_SCENE_NAME = "Scene_01";

		public static List<Models.EcoSystem> EcoSystems;
		public static Models.EcoSystem ActiveEcoSystem;

		#endregion
		//----------------------------------------------------------------------------------------------------------------------------
		#region MonoBehaviour

		private void Awake()
		{
			
		}

		#endregion
		//----------------------------------------------------------------------------------------------------------------------------
		#region Public

		public void CreateEcoSystem(List<Animal> animals)
		{
			Models.EcoSystem ecoSystem = new Models.EcoSystem(animals);
			EcoSystems.Add(ecoSystem);
			ActiveEcoSystem = ecoSystem;
			SceneManager.LoadScene(SIMULATION_SCENE_NAME, LoadSceneMode.Single);
		}

		#endregion
	}
}