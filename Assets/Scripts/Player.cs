using UnityEngine;

public class Player
{
	private static Player current; // Singleton instance
	public int health { get; set; }

	// Empty constructor
	private Player()
	{
		health = Random.Range(1, 100);
	}

	// Non thread safe singleton returner
	public static Player getInstance()
	{
		if (current == null)
		{
			current = new Player();
		}

		return current;
	}

}

