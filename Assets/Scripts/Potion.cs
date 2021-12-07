using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Potion : MonoBehaviour
{
	private int potion = 10;

	private void Awake()
	{
		Debug.Log(Player.getInstance().health);
	}

	void Start()
    {
		Heal();   
		Debug.Log(Player.getInstance().health);

    }

    private void Heal()
    {
	    Player.getInstance().health += potion;
    }


}
