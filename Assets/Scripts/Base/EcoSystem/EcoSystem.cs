using System.Collections.Generic;

namespace EcoSystem
{
	public class EcoSystem
	{
		#region Members

		public List<Animal> LivingAnimals { get; set; }
		public List<Animal> DeadAnimals { get; set; }

		#endregion
		//----------------------------------------------------------------------------------------------------------------------------
		#region Public

		public EcoSystem(List<Animal> initialAnimals)
		{
			LivingAnimals = initialAnimals;
		}

		public void AddAnimal(Animal animal)
		{
			LivingAnimals.Add(animal);
		}

		public void RemoveAnimal(Animal animal)
		{
			LivingAnimals.Remove(animal);
			DeadAnimals.Add(animal);
		}

		#endregion
	}
}
