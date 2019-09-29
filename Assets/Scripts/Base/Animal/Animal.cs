using System.Collections.Generic;

public class Animal
{
	public List<Gene> _Genes;

	public float _Thirst;
	public float _Hunger;
	public float _Strength;
	public float _Speed;

	public Animal(float thirst, float hunger, float strength, float speed, List<Gene> genes)
	{
		_Thirst = thirst;
		_Hunger = hunger;
		_Strength = strength;
		_Speed = speed;
		_Genes = genes;
	}
}
