using UnityEngine;
using System.Collections;

public class spawner3 : MonoBehaviour {
	public GameObject clue5; //prefab må bli "kobblet" til her
	public GameObject clue6; //prefab må bli "kobblet" til her
	Vector3 spawn_position;
	ArrayList currentinventory;
	
	void spawnclue5(){
		spawn_position = new Vector3 (0, 3, 0);  //hvor object skal spawne <(^_^)>
		Instantiate (clue5, spawn_position, Quaternion.identity);//object -> posisjon -> rotasjon(her blir den satt til 0,0,0)
	}
	void spawnclue6(){
		spawn_position = new Vector3 (0, 1, 0);  //hvor object skal spawne <(^_^)>
		Instantiate (clue6, spawn_position, Quaternion.identity);//object -> posisjon -> rotasjon(her blir den satt til 0,0,0)
	}
	
	void Start () {
		currentinventory = GameObject.FindWithTag("Player").GetComponent<clicker> ().inventory; //henter listen av "clues" som har blitt funnet
		if(!(currentinventory.Contains("clue5(Clone)")))//spawner prefab hvis den ikke har blit plukket opp
			spawnclue5 ();  // prefab spawnes ved start av scene
		if(!(currentinventory.Contains("clue6(Clone)")))//spawner prefab hvis den ikke har blit plukket opp
			spawnclue6 (); // prefab spawnes ved start av scene	
	}
}
