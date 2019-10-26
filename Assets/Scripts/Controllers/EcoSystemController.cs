using System.Collections.Generic;
using UnityEngine;
using EcoSystem.Models;

namespace EcoSystem.Controllers
{
	public class EcoSystemController : MonoBehaviour
	{
		#region Members

		public static Models.EcoSystem ActiveEcoSystem;
		public static EcoSystemController Instance;

		public static List<Models.EcoSystem> _EcoSystems = new List<Models.EcoSystem>();
		private List<Animal> _AnimalsList = new List<Animal>();

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

		public void CreateEcoSystem()
		{
			Models.EcoSystem ecoSystem = new Models.EcoSystem(_AnimalsList);
			_EcoSystems.Add(ecoSystem);
			ActiveEcoSystem = ecoSystem;
		}

		public void AddAnimalToList(AnimalType animalType)
		{
			Animal animal = AnimalController.GetAnimalByType(animalType);
			_AnimalsList.Add(animal);
		}

		#endregion
	}
}