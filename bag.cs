using UnityEngine;
using System.Collections;

public class bag : MonoBehaviour {
	
	void OnGUI () {
		ArrayList test = GameObject.FindWithTag("Player").GetComponent<clicker> ().inventory; //henter listen av "clues" som har blitt funnet
		
		// Make a background box
		GUI.Box(new Rect(10,10,100,30 * test.Count + 25), "Inventory");
		
		for (int i = 0; i < test.Count; i++)
						if (GUI.Button (new Rect (15, ((30 * i) + 40), 90, 20), "" + test [i]))
								Application.LoadLevel (2);
		
	}
}
