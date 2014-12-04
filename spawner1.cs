using UnityEngine;
using System.Collections;

public class spawner1 : MonoBehaviour {
	public GameObject clue1; //prefab må bli "kobblet" til her
	public GameObject clue2; //prefab må bli "kobblet" til her
	Vector3 spawn_position;
	ArrayList currentinventory;

	void spawnclue1(){
		spawn_position = new Vector3 (0, 3, 0);  //hvor object skal spawne <(^_^)>
		Instantiate (clue1, spawn_position, Quaternion.identity);//object -> posisjon -> rotasjon(her blir den satt til 0,0,0)
	}
	void spawnclue2(){
		spawn_position = new Vector3 (0, 1, 0);  //hvor object skal spawne <(^_^)>
		Instantiate (clue2, spawn_position, Quaternion.identity);//object -> posisjon -> rotasjon(her blir den satt til 0,0,0)
	}
	
	void Start () {
		currentinventory = GameObject.FindWithTag("Player").GetComponent<clicker> ().inventory; //henter listen av "clues" som har blitt funnet
		if(!(currentinventory.Contains("clue1(Clone)"))) //spawner prefab hvis den ikke har blit plukket opp
			spawnclue1 ();  // prefab spawnes ved start av scene
		if(!(currentinventory.Contains("clue2(Clone)"))) //spawner prefab hvis den ikke har blit plukket opp
			spawnclue2 (); // prefab spawnes ved start av scene	
	}
}
