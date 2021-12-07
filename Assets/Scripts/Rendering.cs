using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rendering : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnGUI()
    {
	    GUI.color = Color.blue;
	    GUI.Label(new Rect(100, 100, 300, 100), "Player health:" + Player.getInstance().health);
	    
    }
}
