using UnityEngine;
using System.Collections;

public class NextLevel : MonoBehaviour {

	public int nextLevel;
	void OnMouseDown () {
		Application.LoadLevel(nextLevel);
	}
}
