using UnityEngine;

public class PlayerSingleton
{
	private static PlayerSingleton current; // Singleton instance
	public int health { get; set; }

	// Constructor
	private PlayerSingleton()
	{
		health = Random.Range(1, 100);
	}

	// Non thread safe singleton returner
	public static PlayerSingleton GetInstance()
	{
		if (current == null)
		{
			current = new PlayerSingleton();
		}
		return current;
	}
	
}

