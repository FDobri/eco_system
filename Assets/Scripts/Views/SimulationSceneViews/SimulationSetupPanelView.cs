using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using EcoSystem.Controllers;

namespace EcoSystem.Views
{
	public class SimulationSetupPanelView : MonoBehaviour
	{
		#region Members

		private const string SIMULATION_SCENE_NAME = "Scene_01";

		public List<AnimalInputLabelView> AnimalInputLabels;

		private EcoSystemController _EcoSystemController;

		#endregion
		//----------------------------------------------------------------------------------------------------------------------------
		#region MonoBehaviour

		private void Start()
		{
			_EcoSystemController = EcoSystemController.Instance;
		}

		#endregion
		//----------------------------------------------------------------------------------------------------------------------------
		#region Public

		public void OnGenerateButtonClick()
		{
			_FillAnimalList();
			_EcoSystemController.CreateEcoSystem();
			StartCoroutine(_BeginSimulation());
			// Instantiate all the animals from the EcoSystemController's _AnimalsList.
		}

		#endregion
		//----------------------------------------------------------------------------------------------------------------------------
		#region Private

		private IEnumerator _BeginSimulation()
		{
			SceneManager.LoadScene(SIMULATION_SCENE_NAME, LoadSceneMode.Single);
			yield return new WaitUntil(() => SceneManager.GetActiveScene().name.Equals(SIMULATION_SCENE_NAME));
		}

		private void _FillAnimalList()
		{
			foreach (AnimalInputLabelView label in AnimalInputLabels)
			{
				for (int i = 0; i < label.GetInputFieldValue(); i++)
				{
					_EcoSystemController.AddAnimalToList(label.AnimalType);
				}
			}
		}

		#endregion
	}
}