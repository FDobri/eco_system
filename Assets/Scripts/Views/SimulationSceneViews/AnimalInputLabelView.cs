using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace EcoSystem.Views
{
	public class AnimalInputLabelView : MonoBehaviour
	{
		#region Members

		//TODO: Move these consts to a utility file designated for Const values.
		private const char MIN_SINGLE_DIGIT_NUMBER = '0';
		private const char MAX_SINGLE_DIGIT_NUMBER = '9';

		public AnimalType AnimalType;
		public InputField InputField;

		private string _PreviousInputFieldString;

		#endregion
		//----------------------------------------------------------------------------------------------------------------------------
		#region MonoBehaviour

		private void Start()
		{
			InputField.onValueChanged.AddListener(delegate { _ValidateFieldInput(); });
		}

		#endregion
		//----------------------------------------------------------------------------------------------------------------------------
		#region Public

		public int GetInputFieldValue()
		{
			return Int32.Parse(InputField.text);
		}

		#endregion
		//----------------------------------------------------------------------------------------------------------------------------
		#region Private

		private void _ValidateFieldInput()
		{
			_PreviousInputFieldString = string.Empty;
			foreach (char c in InputField.text)
			{
				if (c < MIN_SINGLE_DIGIT_NUMBER || c > MAX_SINGLE_DIGIT_NUMBER)
				{
					InputField.text = _PreviousInputFieldString;
				}
				else
				{
					_PreviousInputFieldString += c;
				}
			}
		}

		#endregion
	}
}
