using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace EcoSystem.Views
{
	public class SimulationSetupPanelView : MonoBehaviour
	{
		#region Members

		public List<InputField> InputFields;

		#endregion
		//----------------------------------------------------------------------------------------------------------------------------
		#region Public

		public void OnGenerateButtonClick()
		{
			//EcoSystemController.CreateEcoSystem();
		}

		#endregion
	}
}