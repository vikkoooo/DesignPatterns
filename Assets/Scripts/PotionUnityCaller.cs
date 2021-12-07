using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotionUnityCaller : MonoBehaviour
{
	private PotionFactory factoryGreat = null;
	private PotionFactory factoryBad = null;

	void Start()
	{
		// Create a couple of potions for the user
		factoryGreat = new PotionGreatFactory(10);
		factoryBad = new PotionBadFactory(5);
		
		HealBad(); // use heal method to show it works
		Debug.Log("Use WSAD, SPACE and MOUSE1 to use character. Press G to heal great, H to heal bad");
	}

	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.G))
		{
			HealGreat();
		}

		if (Input.GetKeyDown(KeyCode.H))
		{
			HealBad();
		}
	}

	private void HealGreat()
	{
		Potion great = factoryGreat.GetPotion();
		PlayerSingleton.GetInstance().health += great.heal;
		great.owned--;
	}
	
	private void HealBad()
	{
		Potion bad = factoryBad.GetPotion();
		PlayerSingleton.GetInstance().health += bad.heal;
		bad.owned--;
	}
	

    
    
}