using System.Collections;
using System.Collections.Generic;

namespace EcoSystem.Models
{
	public class Fox : Animal
	{
		public Fox(float thirst, float hunger, float strength, float speed, List<Gene> genes) : base(thirst, hunger, strength, speed, genes)
		{
		}

		public Fox() : base() { }
	}
}
