using System.Collections;
using System.Collections.Generic;

namespace EcoSystem.Models
{
	public class Wolf : Animal
	{
		public Wolf(float thirst, float hunger, float strength, float speed, List<Gene> genes) : base(thirst, hunger, strength, speed, genes)
		{
		}
	}
}
