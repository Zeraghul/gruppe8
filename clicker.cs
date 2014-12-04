using UnityEngine;
using System.Collections;

public class clicker : MonoBehaviour {
	public float counter = 0f; // trenger ikke tenkte på denne bare teller for å få printe ut arraylist når den har partall verdi
	public ArrayList inventory = new ArrayList (); 

	void Start () {
		DontDestroyOnLoad(gameObject);
	}

	void Update () {
		if ( Input.GetMouseButtonDown(0)){
			RaycastHit hit = new RaycastHit();
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);

			if (Physics.Raycast (ray, out hit, 100.0f) && (hit.transform.gameObject.tag == "Clue" || hit.transform.gameObject.tag == "spheres")){
				counter++;
				inventory.Add(hit.transform.gameObject.name); // adder navnet til det gameobjectet som ble trykket på i inventory
				Destroy(hit.transform.gameObject); //ødelegger objectet som ble trykket på
			
				if(counter == 2)
					Application.LoadLevel(1);
			}
		}
	}
}