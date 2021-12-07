using UnityEngine;

public class Rendering : MonoBehaviour
{
	private void OnGUI()
    {
	    GUI.color = Color.white;
	    GUI.Label(new Rect(100, 100, 300, 100), "Player health: " + PlayerSingleton.GetInstance().health);
	    GUI.Label(new Rect(100, 120, 300, 100), "Player state: " + GetComponent<PlayerStateMachine>().currentState);
    }
}
