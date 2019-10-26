using EcoSystem.Models;

namespace EcoSystem.Controllers
{
	public enum AnimalType
	{
		Bear,
		Fox,
		Lynx,
		Rabbit,
		Wolf
	}

	public class AnimalController
	{
		public static Animal GetAnimalByType(AnimalType type)
		{
			switch (type)
			{
				case AnimalType.Bear:
					return new Bear();
				case AnimalType.Fox:
					return new Fox();
				case AnimalType.Lynx:
					return new Lynx();
				case AnimalType.Rabbit:
					return new Rabbit();
				case AnimalType.Wolf:
					return new Wolf();
				default:
					return new Animal();
			}
		}
	}
}