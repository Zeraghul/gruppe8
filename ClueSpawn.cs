using UnityEngine;
using System.Collections;

public class ClueSpawn : MonoBehaviour {

	public GameObject Clue;
	public Transform CluePos;


	// Use this for initialization
	void Start () {
		Instantiate(Clue,CluePos.position, CluePos.rotation);
	}
}
