using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace EcoSystem.Views
{
	public enum AnimalType
	{
		Bear,
		Fox,
		Lynx,
		Rabbit,
		Wolf
	}

	public class SimulationSetupPanelView : MonoBehaviour
	{
		#region Members

		private const string SIMULATION_SCENE_NAME = "Scene_01";

		public List<InputField> InputFields;

		#endregion
		//----------------------------------------------------------------------------------------------------------------------------
		#region Public

		public void OnGenerateButtonClick()
		{
			//EcoSystemController.CreateEcoSystem();
			SceneManager.LoadScene(SIMULATION_SCENE_NAME, LoadSceneMode.Additive);
			StartCoroutine(_BeginSimulation());

		}

		#endregion
		//----------------------------------------------------------------------------------------------------------------------------
		#region Private

		private IEnumerator _BeginSimulation()
		{
			yield return new WaitUntil(() => SceneManager.GetActiveScene().name.Equals(SIMULATION_SCENE_NAME));
			Debug.Log("Simulation started");
		}

		#endregion
	}
}