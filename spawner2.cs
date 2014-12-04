using UnityEngine;
using System.Collections;

public class spawner2 : MonoBehaviour {
	public GameObject clue3; //prefab må bli "kobblet" til her
	public GameObject clue4; //prefab må bli "kobblet" til her
	Vector3 spawn_position;
	ArrayList currentinventory;

	void spawnclue3(){
		spawn_position = new Vector3 (0, 3, 0);  //hvor object skal spawne <(^_^)>
		Instantiate (clue3, spawn_position, Quaternion.identity);//object -> posisjon -> rotasjon(her blir den satt til 0,0,0)
	}
	void spawnclue4(){
		spawn_position = new Vector3 (0, 1, 0);  //hvor object skal spawne <(^_^)>
		Instantiate (clue4, spawn_position, Quaternion.identity);//object -> posisjon -> rotasjon(her blir den satt til 0,0,0)
	}
	
	void Start () {
		currentinventory = GameObject.FindWithTag("Player").GetComponent<clicker> ().inventory; //henter listen av "clues" som har blitt funnet
		if(!(currentinventory.Contains("clue3(Clone)")))//spawner prefab hvis den ikke har blit plukket opp
			spawnclue3 ();  // prefab spawnes ved start av scene
		if(!(currentinventory.Contains("clue4(Clone)")))//spawner prefab hvis den ikke har blit plukket opp
			spawnclue4 (); // prefab spawnes ved start av scene	
	}
}
