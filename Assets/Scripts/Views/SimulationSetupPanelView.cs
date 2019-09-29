using UnityEngine;
using UnityEngine.SceneManagement;

public class SimulationSetupPanelView : MonoBehaviour
{
	#region Members

	private const string SIMULATION_SCENE_NAME = "Scene_01";

	#endregion
	//----------------------------------------------------------------------------------------------------------------------------
	#region Public

	public void LaunchScene()
	{
		SceneManager.LoadScene(SIMULATION_SCENE_NAME);
	}

	#endregion
}
