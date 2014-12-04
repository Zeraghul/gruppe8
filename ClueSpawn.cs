using UnityEngine;
using System.Collections;

public class ClueSpawn : MonoBehaviour {

	public GameObject Clue;		//Clue Prefab
	public Transform CluePos;	//Clue Prefab spawn position


	// Use this for initialization
	void Start () {
		Instantiate(Clue,CluePos.position, CluePos.rotation);
	}
}
