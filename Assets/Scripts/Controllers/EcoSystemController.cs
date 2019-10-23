using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using EcoSystem.Models;

namespace EcoSystem.Controllers
{
	public class EcoSystemController : MonoBehaviour
	{
		#region Members

		public static List<Models.EcoSystem> EcoSystems;
		public static Models.EcoSystem ActiveEcoSystem;
		public static EcoSystemController Instance;

		#endregion
		//----------------------------------------------------------------------------------------------------------------------------
		#region MonoBehaviour

		private void Awake()
		{
			if (Instance == null)
			{
				Instance = this;
			}
		}

		#endregion
		//----------------------------------------------------------------------------------------------------------------------------
		#region Public

		public void CreateEcoSystem(List<Animal> animals)
		{
			Models.EcoSystem ecoSystem = new Models.EcoSystem(animals);
			EcoSystems.Add(ecoSystem);
			ActiveEcoSystem = ecoSystem;
		}

		#endregion
	}
}